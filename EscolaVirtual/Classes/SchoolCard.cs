using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual.Classes
{
    public class SchoolCard
    {

        public SchoolCard(string cardNumber,decimal balance,Student student)
        {
            this.m_cardNumber = cardNumber;
            this.Balance = balance;
            this.Student = student;
        }


        #region Properties and Members
        private string m_cardNumber;
        public string CardNumber
        {
            get { return m_cardNumber; }
            set { m_cardNumber = value; }
        }

        private Student m_student;
        public Student Student
        {
            get { return m_student; }
            set { m_student = value; }
        }

        private List<Transaction> m_movements = new List<Transaction>();
        public List<Transaction> Movements
        {
            get { return m_movements; }
            set { m_movements = value; }
        }

        private decimal m_balance;

        public decimal Balance
        {
            get { return m_balance; }
            set 
            {
                if(value < 0)
                {
                    throw new Exception("Saldo tem de ser positivo!");
                }
                m_balance = value;
            }
        }

        #endregion


    }
}
