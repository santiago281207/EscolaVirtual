using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaVirtual.Classes
{
    public class Student : User
    {
        public Student(string password ,string name, string nif, string email, string phoneNumber, string address, Class schoolClass,SchoolCard schoolCard) : base(password,name,nif,email,phoneNumber,address,1)
        {
            this.Class = schoolClass;
            this.SchoolCard = schoolCard;
        }

        #region Properties and Members

        private int m_absenceId;
        public int AbsenceId
        {
            get { return m_absenceId; }
            set { m_absenceId = value; }
        }

        private SchoolCard m_schoolCard;
        public SchoolCard SchoolCard
        {
            get { return m_schoolCard; }
            set { m_schoolCard = value; }
        }

        private Class m_class;
        public Class Class
        {
            get { return m_class; }
            set { m_class = value; }
        }

        private List<Grade> m_grades = new List<Grade>();
        public List<Grade> Grades
        {
            get { return m_grades; }
            set { m_grades = value; }
        }

        private List<Absence> m_absences = new List<Absence>();
        public List<Absence> Absence
        {
            get { return m_absences; }
            set { m_absences = value; }
        }




        #endregion

        



    }
}
