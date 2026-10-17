using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual.Classes
{
    public class SchoolCard
    {

        public SchoolCard(decimal balance,Student student)
        {
            this.Balance = balance;
            this.Student = student;

            student.SchoolCard = this;
        }


        #region Properties and Members
    

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

        private int m_id;
        public int Id
        {
            get { return m_id; }
            set { m_id = value; }
        }

        #endregion


    }
}
