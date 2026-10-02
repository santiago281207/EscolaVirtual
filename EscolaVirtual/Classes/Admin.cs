using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual.Classes
{
    public class Admin
    {

        public Admin()
        {
            this.Login = "0000";
            this.Password = "0000";
        }

        const int maxStudentsPerClass = 25;

        #region Properties and Members
        private List<ClassYear> m_classYears = new List<ClassYear>();
        public List<ClassYear> ClassYears
        {
            get { return m_classYears; }
            set { m_classYears = value; }
        }

        private List<Teacher> m_teachers = new List<Teacher>();
        public List<Teacher> Teachers
        {
            get { return m_teachers; }
            set { m_teachers = value; }
        }

        private List<TeacherClassSubject> m_teacherClassSubject = new List<TeacherClassSubject>();
        public List<TeacherClassSubject> TeacherClassSubjects
        {
            get { return m_teacherClassSubject; }
            set { m_teacherClassSubject = value; }
        }

        private List<User> m_users = new List<User>();
        public List<User> Users
        {
            get { return m_users; }
            set { m_users = value; }
        }

        private string m_login;
        public string Login
        {
            get { return m_login; }
            set { m_login = value; }
        }

        private string m_password;
        public string Password
        {
            get { return m_password; }
            set { m_password = value; }
        }


        #endregion


        public void StartUp()
        {
            ClassYear classYear10 = new ClassYear("10º");
            ClassYear classYear11 = new ClassYear("11º");

            #region 10ºAno
            Subject subject1 = new Subject(classYear10, "Português");
            Subject subject2 = new Subject(classYear10, "Matemática");
            Subject subject3 = new Subject(classYear10, "Inglês");
            Subject subject4 = new Subject(classYear10, "Educação Física");
            Subject subject5 = new Subject(classYear10, "Física e Química");

            classYear10.Subject.Add(subject1);
            classYear10.Subject.Add(subject2);
            classYear10.Subject.Add(subject3);
            classYear10.Subject.Add(subject4);
            classYear10.Subject.Add(subject5);
            #endregion

            #region 11ºAno
            Subject subject6 = new Subject(classYear11, "Português");
            Subject subject7 = new Subject(classYear11, "Matemática");
            Subject subject8 = new Subject(classYear11, "Inglês");
            Subject subject9 = new Subject(classYear11, "Educação Física");
            Subject subject10 = new Subject(classYear11, "Física e Química");

            classYear11.Subject.Add(subject6);
            classYear11.Subject.Add(subject7);
            classYear11.Subject.Add(subject8);
            classYear11.Subject.Add(subject9);
            classYear11.Subject.Add(subject10);
            #endregion


            this.ClassYears.Add(classYear10);
            this.ClassYears.Add(classYear11);

        }


    }
}
