using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual.Classes
{
    public class Grade
    {

        public Grade(TeacherClassSubject teacherClassSubject,Module module,double value,Student student,DateTime gradingPeriod)
        {
            this.TeacherClassSubject = teacherClassSubject;
            this.Module = module;
            this.Value = value;
            this.Student = student;
            this.GradingPeriod = gradingPeriod;
        }

        #region Properties and Members

        private TeacherClassSubject m_teacherClassSubject;
        public TeacherClassSubject TeacherClassSubject
        {
            get { return m_teacherClassSubject; }
            set { m_teacherClassSubject = value; }
        }

        private Module m_module;
        public Module Module
        {
            get { return m_module; }
            set { m_module = value; }
        }



        private double m_value;
        public double Value
        {
            get { return m_value; }
            set { m_value = value; }
        }

        private Student m_student;
        public Student Student
        {
            get { return m_student; }
            set { m_student = value; }
        }



        private DateTime m_gradingPeriod;
        public DateTime GradingPeriod
        {
            get { return m_gradingPeriod; }
            set { m_gradingPeriod = value; }
        }




















        #endregion

    }
}
