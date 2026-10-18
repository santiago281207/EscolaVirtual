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
            this.Close();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Transaction transaction;

            if (rbDeposit.Checked)
            {
                try
                {
                    transaction = new Transaction(TransactionType.Deposit, nudAmount.Value, DateTime.Now, student.SchoolCard);
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
            }else
            {
                try
                {
                    transaction = new Transaction(TransactionType.Withdraw, nudAmount.Value, DateTime.Now, student.SchoolCard);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            lvwMovementsHistory.Items.Add(transaction.ToListViewitem(transaction));
            lblBalance.Text = $"Saldo atual: {student.SchoolCard.Balance.ToString()}€";
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        

        private void FormSchoolCard_Load(object sender, EventArgs e)
        {
            lblBalance.Text = $"Saldo atual: {student.SchoolCard.Balance.ToString()}€";
            if(student.SchoolCard.Movements.Count > 0)
            {
                List<ListViewItem> listViewItems = student.SchoolCard.Movements.Select(mov => mov.ToListViewitem(mov)).ToList();
                listViewItems.ForEach(lvi => lvwMovementsHistory.Items.Add(lvi));
            }
            
            

        }

        private void rdbSortDeposit_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbSortDeposit.Checked)
            {
                lvwMovementsHistory.Items.Clear();
                List<ListViewItem> movementDeposit = student.SchoolCard.Movements.FindAll(mov => mov.TransactionType == TransactionType.Deposit).Select(tra => tra.ToListViewitem(tra)).ToList();
                movementDeposit.ForEach(mov => lvwMovementsHistory.Items.Add(mov));
                List<ListViewItem> movementWithdraw = student.SchoolCard.Movements.FindAll(mov => mov.TransactionType == TransactionType.Withdraw).Select(tra => tra.ToListViewitem(tra)).ToList();
                movementWithdraw.ForEach(mov => lvwMovementsHistory.Items.Add(mov));
                
                
            }
            

        }

        private void rdbDontSort_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbDontSort.Checked)
            {
                lvwMovementsHistory.Items.Clear();
                List<ListViewItem> listViewItems = student.SchoolCard.Movements.Select(mov => mov.ToListViewitem(mov)).ToList();
                listViewItems.ForEach(lvi => lvwMovementsHistory.Items.Add(lvi));
            }
        }

        private void rdbSortWithdraw_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbSortWithdraw.Checked)
            {
                lvwMovementsHistory.Items.Clear();
                List<ListViewItem> movementWithdraw = student.SchoolCard.Movements.FindAll(mov => mov.TransactionType == TransactionType.Withdraw).Select(tra => tra.ToListViewitem(tra)).ToList();
                movementWithdraw.ForEach(mov => lvwMovementsHistory.Items.Add(mov));
                List<ListViewItem> movementDeposit = student.SchoolCard.Movements.FindAll(mov => mov.TransactionType == TransactionType.Deposit).Select(tra => tra.ToListViewitem(tra)).ToList();
                movementDeposit.ForEach(mov => lvwMovementsHistory.Items.Add(mov));
                
                
            }
        }
    }
}
