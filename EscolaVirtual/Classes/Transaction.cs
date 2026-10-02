using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual.Classes
{
    public class Transaction
    {

        public Transaction(int id,int transactionType,decimal amount,decimal resultingBalance,DateTime movementDate,SchoolCard schoolCard)
        {
            this.Id = id;
            this.TransactionType = transactionType;
            this.Amount = amount;
            this.ResultingBalance = resultingBalance;
            this.MovementDate = movementDate;

            this.SchoolCard = schoolCard;
        }

        #region Properties and Members

        private SchoolCard m_schoolCard;
        public SchoolCard SchoolCard
        {
            get { return m_schoolCard; }
            set { m_schoolCard = value; }
        }

        private int m_id;
        public int Id
        {
            get { return m_id; }
            set { m_id = value; }
        }

        //Valor 1 = Deposit
        //Valor 2 = Withdraw
        private int m_transactionType;
        public int TransactionType
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
                    if (value <= 0 || value > SchoolCard.Balance)
                    {
                        throw new Exception("Montante inválido!");
                    }
                    m_amount = value;
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

    }
}
