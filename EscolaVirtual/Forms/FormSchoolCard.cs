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
        SchoolCard schoolCard => student.SchoolCard;
        public FormSchoolCard(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            decimal amount;

            if(decimal.TryParse(txtAmount.Text, out amount))
            {
                try { Transaction transaction = new Transaction(1, amount, DateTime.Now, schoolCard); }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show($"Depósito de {amount} € realizado com sucesso!", "Depósito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtAmount.Clear();
                lblBalance.Text = $"Saldo Atual: {amount} €";
                lvMovementsHistory.Items.Add(new ListViewItem(new string[] { DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"), "Depósito", amount.ToString("F2"), schoolCard.Balance.ToString("F2") }));

            }
            else
            {
                MessageBox.Show("Por favor, insira um valor válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtAmount.Text.Length > 0)
            {
                btnDeposit.Enabled = true;
            }
            else
            {
                btnDeposit.Enabled = false;
            }
        }
    }
}
