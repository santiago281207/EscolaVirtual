using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual.Classes
{
    public class Absence
    {
        public Absence(int state,Student student,DateTime date,Subject subject)
        {
            this.State = state;
            this.Student = student;
            this.Date = date;
            this.Subject = subject;
        }

        #region Properties and Members

        //Valor 1 = Justificada
        //Valor 2 = Injustificada
        private int m_state;
        public int State
        {
            get { return m_state; }
            set { m_state = value; }
        }

        private Student m_student;
        public Student Student
        {
            get { return m_student; }
            set { m_student = value; }
        }

        private DateTime m_date;
        public DateTime Date
        {
            get { return m_date; }
            set { m_date = value; }
        }

        private Subject m_subject;
        public Subject Subject
        {
            get { return m_subject; }
            set { m_subject = value; }
        }

        #endregion








    }
}
