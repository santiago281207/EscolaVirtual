using EscolaVirtual.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaVirtual.Forms
{
    public partial class FormAddStudent : Form
    {
        private bool changed;

        public bool Changed
        {
            get { return changed; }
            set { changed = value; }
        }
        Admin admin;
        public FormAddStudent(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsDigit(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if(txtName.Text != "")
            {
                txtNif.Enabled = true;
            }else
            {
                txtNif.Enabled = false;
            }
        }

        private void txtNif_TextChanged(object sender, EventArgs e)
        {
            if(txtNif.Text.Length == 9)
            {
                txtEmail.Enabled = true;
            }else
            {
                txtEmail.Enabled = false;
            }
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbClass.SelectedItem != null)
            {
                btnCreateStudent.Enabled = true;
            }else
            {
                btnCreateStudent.Enabled = false;
            }
        }

        private void btnCreateStudent_Click(object sender, EventArgs e)
        {
            List<ClassYear> classYears = admin.ClassYears;
            List<Class> classes = classYears.SelectMany(cy => cy.Classes).ToList();
            List<Student> students = classes.SelectMany(cls => cls.Student).ToList();

            Class selectedClass = cbClass.SelectedItem as Class;

            if (selectedClass == null)
            {
                MessageBox.Show("Seleciona uma turma.", "Erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedClass.Student.Count >= Constants.MAX_STUDENTS_PER_CLASS)
            {
                MessageBox.Show("Esta turma já atingiu o número máximo de alunos!","Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtName.Text.Trim() == "" ||
                txtNif.Text.Length != 9 ||
                !Methods.IsEmail(txtEmail.Text) ||
                txtPhoneNumber.Text.Length != 9 ||
                txtAddress.Text.Trim().Length <= 6 ||
                txtPassword.Text == "" ||
                txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Verifica os dados introduzidos.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (students.Any(std => std.Nif == txtNif.Text))
            {
                MessageBox.Show("Já existe um aluno com este NIF.",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Random random = new Random();
            string schoolNumber;

            do
            {
                schoolNumber = random.Next(100000, 1000000).ToString();
            }while (students.Any(std => std.SchoolNumber == schoolNumber));

            Student student = new Student(
                txtPassword.Text,
                txtName.Text.Trim(),
                schoolNumber,
                txtNif.Text,
                txtAddress.Text.Trim(),
                txtPhoneNumber.Text,
                txtEmail.Text,
                selectedClass
            );

            selectedClass.Student.Add(student);

            MessageBox.Show("Aluno criado com sucesso!\nNúmero de aluno: " + schoolNumber,"Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
            changed = true;

            this.Close();
        }

        private void txtNif_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void FormAddStudent_Load(object sender, EventArgs e)
        {
            List<ClassYear> classYears = admin.ClassYears;
            List<Class> classes = classYears.SelectMany(cy => cy.Classes).ToList();

            txtNif.Enabled = false;
            cbClass.Enabled = false;
            cbClass.DataSource = classes;
            cbClass.DisplayMember = "ClassNameWithYear";
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if(Methods.IsEmail(txtEmail.Text) == true)
            {
                txtPhoneNumber.Enabled = true;
            }else
            {
                txtPhoneNumber.Enabled = false;
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsSymbol(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar);
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtPhoneNumber.Text.Length == 9)
            {
                txtAddress.Enabled = true;
            }
            else
            {
                txtAddress.Enabled = false;
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if(txtPassword.Text != "")
            {
                txtConfirmPassword.Enabled = true;
            }else
            {
                txtConfirmPassword.Enabled = false;
            }

            if(txtPassword.Text == txtConfirmPassword.Text)
            {
                cbClass.Enabled = true;
            }else
            {
                cbClass.Enabled = false;
            }
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "" && txtConfirmPassword.Text != "" && txtPassword.Text == txtConfirmPassword.Text)
            {
                cbClass.Enabled = true;
            }
            else
            {
                cbClass.Enabled = false;
                btnCreateStudent.Enabled = false;
            }
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if (txtAddress.Text.Trim().Length > 6)
            {
                txtPassword.Enabled = true;
            }
            else
            {
                txtPassword.Enabled = false;
                txtConfirmPassword.Enabled = false;
                cbClass.Enabled = false;
            }
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsSymbol(e.KeyChar);
        }

        private void txtNif_EnabledChanged(object sender, EventArgs e)
        {
            if (txtNif.Enabled == false)
            {
                txtEmail.Enabled = false;
            }else if (txtNif.Text.Length == 9)
            {
                txtEmail.Enabled = true;
            }
            else
            {
                txtEmail.Enabled = false;
            }
        }

        private void txtEmail_EnabledChanged(object sender, EventArgs e)
        {
            if (!txtEmail.Enabled)
            {
                txtPhoneNumber.Enabled = false;
            }
            else
            {
                txtPhoneNumber.Enabled = Methods.IsEmail(txtEmail.Text);
            }
        }

        private void txtPhoneNumber_EnabledChanged(object sender, EventArgs e)
        {
            if (!txtPhoneNumber.Enabled)
            {
                txtAddress.Enabled = false;
            }
            else
            {
                txtAddress.Enabled = txtPhoneNumber.Text.Length == 9;
            }
        }

        private void txtAddress_EnabledChanged(object sender, EventArgs e)
        {
            if(txtAddress.Enabled == false)
            {
                txtPassword.Enabled = false;
            }else if (txtAddress.Text.Length > 6)
            {
                txtPassword.Enabled = true;
            }
            else
            {
                txtConfirmPassword.Enabled = false;
            }
        }

        private void txtPassword_EnabledChanged(object sender, EventArgs e)
        {
            if (txtPassword.Enabled == false)
            {
                txtConfirmPassword.Enabled = false;
            }else if (txtPassword.Text != "")
            {
                txtConfirmPassword.Enabled = true;
            }
            else
            {
                txtConfirmPassword.Enabled = false;
            }

            if (txtPassword.Text == txtConfirmPassword.Text)
            {
                cbClass.Enabled = true;
            }
            else
            {
                cbClass.Enabled = false;
            }
        }

        private void txtConfirmPassword_EnabledChanged(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Enabled == false)
            {
                cbClass.Enabled = false;
            }else if (txtPassword.Text == txtConfirmPassword.Text && txtPassword.Text != "")
            {
                cbClass.Enabled = true;
            }
            else
            {
                cbClass.Enabled = false;
            }
        }

        private void cbClass_EnabledChanged(object sender, EventArgs e)
        {
            if(cbClass.Enabled == false)
            {
                btnCreateStudent.Enabled = false;
            }
        }

        private void txtConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }
    }
}
