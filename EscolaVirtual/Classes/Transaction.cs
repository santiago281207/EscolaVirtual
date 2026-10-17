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

        public Transaction(int transactionType,decimal amount,DateTime movementDate,SchoolCard schoolCard)
        {
            this.SchoolCard = schoolCard;
            this.TransactionType = transactionType;
            try
            {
                this.Amount = amount;
            }catch(Exception)
            {
                MessageBox.Show("Montante inválido para operação selecionada!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            this.Id = SchoolCard.Id++;
            
            if(transactionType == 1) //Deposito
            {
                this.ResultingBalance = Amount + schoolCard.Balance;
            }else   //Levantamento
            {
                this.ResultingBalance = SchoolCard.Balance - amount;
            }

            schoolCard.Balance = this.ResultingBalance;
            this.MovementDate = movementDate;

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
                    if ((value <= 0 || value > SchoolCard.Balance) && TransactionType == 2)
                    {
                        throw new Exception("Montante inválido!");
                    }else if(TransactionType == 1 && value <= 0)
                    {
                    throw new Exception("Montante inválido!");
                }else
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

    }
}
