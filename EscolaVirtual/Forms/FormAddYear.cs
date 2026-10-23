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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EscolaVirtual
{
    public partial class FormAddYear : Form
    {
        private bool changed;

        public bool Changed
        {
            get { return changed; }
            set { changed = value; }
        }

        Admin admin;
        public FormAddYear(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void FormAddYear_Load(object sender, EventArgs e)
        {

        }

        private void txtAddYear_TextChanged(object sender, EventArgs e)
        {
            if (txtAddYear.Text == "")
            {
                btnCreate.Enabled = false;
            }
            else
            {
                btnCreate.Enabled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (admin.ClassYears.Any(cy => cy.YearName == txtAddYear.Text))
            {
                MessageBox.Show("Ano letivo já existe!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ClassYear newYear = new ClassYear(txtAddYear.Text);
                admin.ClassYears.Add(newYear);
                MessageBox.Show("Ano letivo adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
                changed = true;
            }
        }

        private void txtAddYear_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != 'º')
            {
                e.Handled = true;
            }

            if (e.KeyChar == 'º' && txtAddYear.SelectionStart != txtAddYear.Text.Length)
            {
                e.Handled = true;
            }

            if (e.KeyChar == 'º' && txtAddYear.Text.Contains("º"))
            {
                e.Handled = true;
            }

            if (char.IsDigit(e.KeyChar) && txtAddYear.Text.Length >= 2)
            {
                e.Handled = true;
            }
        }
    }
}
