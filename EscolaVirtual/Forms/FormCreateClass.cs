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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCreateClass_Load(object sender, EventArgs e)
        {
            btnCreateClass.Enabled = false;

            List<ClassYear> classYears = admin.ClassYears;
            cbClassYear.DataSource = classYears;
            cbClassYear.DisplayMember = "YearName";
            
        }

        private void cbClassYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbClassYear.SelectedItem != null)
            {
                txtClassName.Enabled = true;
            }
        }

        private void txtClassName_TextChanged(object sender, EventArgs e)
        {
            if(txtClassName.Text != "")
            {
                btnCreateClass.Enabled = true;
            }else
            {
                btnCreateClass.Enabled = false;
            }
        }

        private void btnCreateClass_Click(object sender, EventArgs e)
        {
            ClassYear classYear = cbClassYear.SelectedItem as ClassYear;

            Class classValid = classYear.Classes.FirstOrDefault(cls => cls.Name == txtClassName.Text);

            if(classValid != null)
            {
                MessageBox.Show("Turma já existente nesse ano escolar!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                classValid = new Class(txtClassName.Text, classYear);
                MessageBox.Show("Turma criada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                changed = true;
            }
            txtClassName.Text = "";
        }

        private void txtClassName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsDigit(e.KeyChar) || e.KeyChar == 32 || Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar);
        }
    }
}
