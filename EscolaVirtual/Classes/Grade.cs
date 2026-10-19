using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual.Classes
{
    public class Grade
    {

        public Grade(Teacher teacher,Module module,double value,Student student,DateTime gradingPeriod)
        {
            this.Teacher = teacher;
            this.Student = student;
            this.Module = module;
            this.Value = value;
            this.GradingPeriod = gradingPeriod;

            if(student.Grades.Find(gr => gr.Module == Module) != null)
            {
                throw new Exception("Módulo já avaliado!");
            }else
            {
                student.Grades.Add(this);
            }
        }

        #region Properties and Members

        private Teacher m_teacher;
        public Teacher Teacher
        {
            get { return m_teacher; }
            set { m_teacher = value; }
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
