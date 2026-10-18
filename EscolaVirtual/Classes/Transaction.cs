using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaVirtual.Classes
{
    public class Transaction
    {

        public Transaction(TransactionType transactionType,decimal amount,DateTime movementDate,SchoolCard schoolCard)
        {
            this.SchoolCard = schoolCard;
            this.TransactionType = transactionType;
            try
            {
                this.Amount = amount;
            }catch(Exception ex)
            {
                throw ex;
            }
            
            if(transactionType == TransactionType.Deposit) //Deposito
            {
                this.ResultingBalance = Amount + schoolCard.Balance;
            }else   //Levantamento
            {
                this.ResultingBalance = SchoolCard.Balance - amount;
            }

            schoolCard.Balance = this.ResultingBalance;
            this.MovementDate = movementDate;

            schoolCard.Movements.Add(this);
        }

        #region Properties and Members

        private SchoolCard m_schoolCard;
        public SchoolCard SchoolCard
        {
            get { return m_schoolCard; }
            set { m_schoolCard = value; }
        }


        private TransactionType m_transactionType;
        public TransactionType TransactionType
        {
            get { return m_transactionType; }
            set { m_transactionType = value; }
        }

        private decimal m_amount;
        //Usar try catch
        public decimal Amount
        {
            get { return m_amount; }
            set
            {
                if ((value <= 0 || value > SchoolCard.Balance) && TransactionType == TransactionType.Withdraw)
                {
                    throw new Exception("Montante inválido!");
                }
                else if (TransactionType == TransactionType.Deposit && value <= 0)
                {
                    throw new Exception("Montante inválido!");
                }
                else
                {
                    m_amount = value;
                }

            }
        }

        private decimal m_resultingBalance;
        public decimal ResultingBalance
        {
            get { return m_resultingBalance; }
            set { m_resultingBalance = value; }
        }

        private DateTime m_movementDate;
        public DateTime MovementDate
        {
            get { return m_movementDate; }
            set { m_movementDate = value; }
        }
        #endregion


        public ListViewItem ToListViewitem(Transaction transaction)
        {
            ListViewItem listViewItem = new ListViewItem(transaction.TransactionType == TransactionType.Deposit ? "Depósito" : "Levantamento");

            ListViewItem.ListViewSubItem lisiDate = new ListViewItem.ListViewSubItem(listViewItem, transaction.MovementDate.ToString("G"));
            ListViewItem.ListViewSubItem lisiAmount = new ListViewItem.ListViewSubItem(listViewItem, transaction.Amount.ToString());
            ListViewItem.ListViewSubItem lisiResultingBalance = new ListViewItem.ListViewSubItem(listViewItem, transaction.ResultingBalance.ToString());

            listViewItem.SubItems.Add(lisiDate);
            listViewItem.SubItems.Add(lisiAmount);
            listViewItem.SubItems.Add(lisiResultingBalance);

            listViewItem.Tag = transaction.TransactionType;
            return listViewItem;
        }


    }
}
