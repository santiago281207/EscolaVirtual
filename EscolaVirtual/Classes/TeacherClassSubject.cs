using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual.Classes
{
    public class TeacherClassSubject
    {

        public TeacherClassSubject(Teacher teacher,Subject subject,Class @class)
        {
            this.Teacher = teacher;
            this.Subject = subject;
            this.Class = @class;
        }

        #region Properties and Members
        private Teacher m_teacher;
        public Teacher Teacher
        {
            get { return m_teacher; }
            set { m_teacher = value; }
        }

        private Subject m_subject;
        public Subject Subject
        {
            get { return m_subject; }
            set { m_subject = value; }
        }

        private Class m_class;
        public Class Class
        {
            get { return m_class; }
            set { m_class = value; }
        }
        #endregion




    }
}
