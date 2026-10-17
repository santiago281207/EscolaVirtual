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
        private List<DataChange> m_dataChanges = new List<DataChange>();
        public List<DataChange> DataChanges
        {
            get { return m_dataChanges; }
            set { m_dataChanges = value; }
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


            //         REMOVER ANTES DE ENVIAR
            //=========================================
            //=========================================
            //=========================================
            //               TESTE
            //=========================================
            //=========================================
            //=========================================

            #region TURMAS TESTE
            Class class1 = new Class("TGPSI",classYear10);
            Class class2 = new Class("MAV", classYear11);
            #endregion

            #region PROFESSORES TESTE

            Teacher teacher1 = new Teacher("1111", "Santiago", "111111111","santiagodias238@gmail.com","932514290","Rua Santo Tiago n9 10A");
            this.Teachers.Add(teacher1);
            this.Users.Add(teacher1);

            Teacher teacher2 = new Teacher("2222", "Vicente", "222222222","vicentemsalves@gmail.com","933396899","Rua Vicentino n77 7C");
            this.Teachers.Add(teacher2);
            this.Users.Add(teacher2);

            #endregion

            #region ALUNOS TESTE

            Student student1 = new Student("3333", "João", "333333333","joazinhofixe143@gmail.com","982910238","Avenida dos aliados 38 2735",class1,null);
            SchoolCard schoolCard1 = new SchoolCard(0, student1);

            class1.Student.Add(student1);
            this.Users.Add(student1);

            #endregion

            #region MODULOS TESTE

            Module module1 = new Module("Módulo 1",subject1);
            Module module2 = new Module("Módulo 2", subject2);
            Module module3 = new Module("Módulo 3", subject1);

            #endregion

            #region NOTAS TESTE

            Grade grade1 = new Grade(teacher1, module1, 15, student1, DateTime.Now);
            Grade grade2 = new Grade(teacher1, module2, 10, student1, DateTime.Now);


            #endregion

            #region REGISTOS TESTE
            TeacherClassSubject teacherClassSubject1 = new TeacherClassSubject(teacher1, subject1, class1);
            TeacherClassSubject teacherClassSubject2 = new TeacherClassSubject(teacher1, subject2, class1);
            TeacherClassSubject teacherClassSubject3 = new TeacherClassSubject(teacher1, subject3, class1);
            TeacherClassSubject teacherClassSubject4 = new TeacherClassSubject(teacher1, subject4, class1);
            TeacherClassSubject teacherClassSubject5 = new TeacherClassSubject(teacher1, subject5, class1);

            this.TeacherClassSubjects.Add(teacherClassSubject1);
            this.TeacherClassSubjects.Add(teacherClassSubject2);
            this.TeacherClassSubjects.Add(teacherClassSubject3);
            this.TeacherClassSubjects.Add(teacherClassSubject4);

            TeacherClassSubject teacherClassSubject6 = new TeacherClassSubject(teacher2, subject6, class2);
            TeacherClassSubject teacherClassSubject7 = new TeacherClassSubject(teacher2, subject7, class2);
            TeacherClassSubject teacherClassSubject8 = new TeacherClassSubject(teacher2, subject8, class2);
            TeacherClassSubject teacherClassSubject9 = new TeacherClassSubject(teacher2, subject9, class2);
            TeacherClassSubject teacherClassSubject10 = new TeacherClassSubject(teacher2, subject10, class2);

            this.TeacherClassSubjects.Add(teacherClassSubject5);
            this.TeacherClassSubjects.Add(teacherClassSubject6);
            this.TeacherClassSubjects.Add(teacherClassSubject7);
            this.TeacherClassSubjects.Add(teacherClassSubject8);
            #endregion

            #region MENSAGENS TESTE

            TextMessage textMessage1 = new TextMessage(teacher1, student1, "Bem vindo à escola!", "Sê bem vindo à nossa escola virtual!", DateTime.Now);


            #endregion

            //=========================================
            //=========================================
            //=========================================
            //               TESTE
            //=========================================
            //=========================================
            //=========================================

        }


    }
}
