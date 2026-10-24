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

    public partial class FormAddTeacher : Form
    {
        private bool changed;

        public bool Changed
        {
            get { return changed; }
            set { changed = value; }
        }

        Admin admin;
        public FormAddTeacher(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsDigit(e.KeyChar) || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar);
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                txtNif.Enabled = true;
            }
            else
            {
                txtNif.Enabled = false;
            }
        }

        private void txtNif_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void txtNif_TextChanged(object sender, EventArgs e)
        {
            if (txtNif.Text.Length == 9)
            {
                txtEmail.Enabled = true;
            }
            else
            {
                txtEmail.Enabled = false;
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsSymbol(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (Methods.IsEmail(txtEmail.Text) == true)
            {
                txtPhoneNumber.Enabled = true;
            }
            else
            {
                txtPhoneNumber.Enabled = false;
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
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

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsSymbol(e.KeyChar);
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
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                txtConfirmPassword.Enabled = true;
            }
            else
            {
                txtConfirmPassword.Enabled = false;
            }
        }

        private void txtConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "" && txtConfirmPassword.Text != "" && txtPassword.Text == txtConfirmPassword.Text)
            {
                btnAddTeacher.Enabled = true;
            }
            else
            {
                btnAddTeacher.Enabled = false;
            }
        }

        private void txtNif_EnabledChanged(object sender, EventArgs e)
        {
            if (txtNif.Enabled == false)
            {
                txtEmail.Enabled = false;
            }
            else if (txtNif.Text.Length == 9)
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
            if (txtAddress.Enabled == false)
            {
                txtPassword.Enabled = false;
            }
            else if (txtAddress.Text.Length > 6)
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
            }
            else if (txtPassword.Text != "")
            {
                txtConfirmPassword.Enabled = true;
            }
            else
            {
                txtConfirmPassword.Enabled = false;
            }

        }

        private void txtConfirmPassword_EnabledChanged(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Enabled == false)
            {
                btnAddTeacher.Enabled = false;
            }
            else if (txtPassword.Text == txtConfirmPassword.Text && txtPassword.Text != "")
            {
                btnAddTeacher.Enabled = true;
            }
            else
            {
                btnAddTeacher.Enabled = false;
            }
        }

        private void FormAddTeacher_Load(object sender, EventArgs e)
        {
            txtNif.Enabled = false;
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();

            if (txtName.Text.Trim() == "" ||
                txtNif.Text.Length != 9 ||
                !Methods.IsEmail(email) ||
                txtPhoneNumber.Text.Length != 9 ||
                txtAddress.Text.Trim().Length <= 6 ||
                txtPassword.Text.Length != 4 ||
                txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Verifica os dados introduzidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (admin.Users.Any(u => u.Nif == txtNif.Text))
            {
                MessageBox.Show("Já existe um utilizador com este NIF.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Teacher teacher = new Teacher(
                txtPassword.Text,
                txtName.Text.Trim(),
                txtNif.Text,
                email,
                txtPhoneNumber.Text,
                txtAddress.Text.Trim()
            );

            admin.Teachers.Add(teacher);
            admin.Users.Add(teacher);

            MessageBox.Show("Professor criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            changed = true;
            this.Close();
        }
    }
}
