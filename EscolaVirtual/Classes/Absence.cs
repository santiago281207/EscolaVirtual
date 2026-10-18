using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaVirtual.Classes
{
    public class Absence
    {
        public Absence(int state,Student student,DateTime date,Subject subject,string justification)
        {
            this.Id = student.AbsenceId++;
            this.State = state;
            this.Student = student;
            this.Date = date;
            this.Subject = subject;
            this.Justification = justification;

            student.Absence.Add(this);
        }

        #region Properties and Members

        private int m_id;
        public int Id
        {
            get { return m_id; }
            set { m_id = value; }
        }

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
            
        private string m_justification;
        public string Justification
        {
            get { return m_justification; }
            set { m_justification = value; }
        }


        #endregion






        public ListViewItem ToListViewItem(Absence absence)
        {
             ListViewItem item = new ListViewItem(absence.Date.ToShortDateString());

            item.SubItems.Add(absence.Subject.SubjectName);
            item.SubItems.Add(absence.State == 1 ? "Justificada" : "Injustificada");

            if (absence.Justification == null)
            {
                item.SubItems.Add("Sem justificação.");
            }else
            {
                item.SubItems.Add(absence.Justification);
            }

            item.Tag = this.Id;
            return item;
        }

    }
}
