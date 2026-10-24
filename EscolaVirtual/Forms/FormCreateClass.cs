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
    public partial class FormCreateClass : Form
    {
        Admin admin;
        private bool changed;

        public bool Changed
        {
            get { return changed; }
            set { changed = value; }
        }

        public FormCreateClass(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void FormCreateClass_Load(object sender, EventArgs e)
        {
            btnCreateClass.Enabled = false;
            txtClassName.Enabled = false;
            txtMaxStudents.Enabled = false;

            List<ClassYear> classYears = admin.ClassYears;
            cbClassYear.DataSource = classYears;
            cbClassYear.DisplayMember = "YearName";
        }

        private void cbClassYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClassYear.SelectedItem != null)
            {
                txtClassName.Enabled = true;
                txtMaxStudents.Enabled = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtClassName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsDigit(e.KeyChar) || e.KeyChar == 32 || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar);
        }

        private void btnCreateClass_Click(object sender, EventArgs e)
        {
            ClassYear classYear = cbClassYear.SelectedItem as ClassYear;

            Class classValid = classYear.Classes.FirstOrDefault(cls => cls.Name == txtClassName.Text);

            if (classValid != null)
            {
                MessageBox.Show("Turma já existente nesse ano escolar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
               
                if (int.TryParse(txtMaxStudents.Text, out int maxStudents) && maxStudents > 0)
                {
                   
                    classValid = new Class(txtClassName.Text, classYear, maxStudents);

                    MessageBox.Show("Turma criada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    changed = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Insere um número máximo de alunos válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }
            }

            txtClassName.Text = "";
            txtMaxStudents.Text = "";
        }

      
        private void CheckFields()
        {
            if (!string.IsNullOrWhiteSpace(txtClassName.Text) && !string.IsNullOrWhiteSpace(txtMaxStudents.Text))
            {
                btnCreateClass.Enabled = true;
            }
            else
            {
                btnCreateClass.Enabled = false;
            }
        }

        private void txtClassName_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }

        private void txtMaxStudents_TextChanged(object sender, EventArgs e)
        {
            CheckFields();
        }
    }
}