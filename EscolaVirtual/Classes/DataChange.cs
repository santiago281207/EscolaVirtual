using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual.Classes
{
    public class DataChange
    {
        public DataChange(Teacher teacher,string changeTitle,string description)
        {
            this.Teacher = teacher;
            this.ChangeTitle = changeTitle;
            this.Description = description;
        }

        public DataChange(Student student, string changeTitle, string description)
        {
            this.Student = student;
            this.ChangeTitle = changeTitle;
            this.Description = description;
        }

        private Teacher m_teacher;
        public Teacher Teacher
        {
            get { return m_teacher; }
            set { m_teacher = value; }
        }

        private Student m_student;
        public Student Student
        {
            get { return m_student; }
            set { m_student = value; }
        }

        private string m_changeTitle;
        public string ChangeTitle
        {
            get { return m_changeTitle; }
            set { m_changeTitle = value; }
        }
        private string m_description;
        public string Description
        {
            get { return m_description; }
            set { m_description = value; }
        }




    }
}
