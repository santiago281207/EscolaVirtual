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
    public partial class FormSchoolCard : Form
    {
        Student student;
        public FormSchoolCard(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == null) {
                MessageBox.Show("Por favor, insira um valor para depositar.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else {
                decimal amount;

                if (decimal.TryParse(txtAmount.Text, out amount))
                {
                    student.(amount);
                    MessageBox.Show($"Depósito de {amount:€} realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAmount.Clear();
                }
                else
                {
                    MessageBox.Show("Por favor, insira um valor válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}
