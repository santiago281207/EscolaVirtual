using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaVirtual.Classes
{
    public abstract class User
    {
        public User(string password,string name,string nif,string email,string phoneNumber,string address,UserRole userType)
        {
            this.Password = password;
            this.Name = name;
            this.Nif = nif;
            this.Email = email;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.UserType = userType;
           
        }

        #region Properties and Members
        private string m_nif;
        public string Nif
        {
            get { return m_nif; }
            set { m_nif = value; }
        }

        private string m_password;
        public string Password
        {
            get { return m_password; }
            set { m_password = value; }
        }
        private List<TextMessage> m_messages = new List<TextMessage>();
        public List<TextMessage> Messages
        {
            get { return m_messages; }
            set { m_messages = value; }
        }
        private string m_name;

        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        private UserRole m_userType;
        public UserRole UserType
        {
            get { return m_userType; }
            set { m_userType = value; }
        }

        private string m_email;
        public string Email
        {
            get { return m_email; }
            set { m_email = value; }
        }

        private string m_phoneNumber;
        public string PhoneNumber
        {
            get { return m_phoneNumber; }
            set { m_phoneNumber = value; }
        }
        
        private string m_address;
        public string Address
        {
            get { return m_address; }
            set { m_address = value; }
        }

        #endregion


        public ListViewItem ToListViewItem(User user,Admin admin)
        {
            ListViewItem listViewItem = new ListViewItem(user.Name);    //Nome do user


            if(user.UserType == UserRole.Student) //Aluno
            {
                Student student = (Student)user;
                ListViewItem.ListViewSubItem lisiSchoolNumber = new ListViewItem.ListViewSubItem(listViewItem, student.SchoolNumber); //Número escolar
                ListViewItem.ListViewSubItem lisiNif = new ListViewItem.ListViewSubItem(listViewItem, student.Nif); //Nif
                ListViewItem.ListViewSubItem lisiClassYear = new ListViewItem.ListViewSubItem(listViewItem, student.Class.SchoolYear.YearName); //Ano
                ListViewItem.ListViewSubItem lisiClass = new ListViewItem.ListViewSubItem(listViewItem, student.Class.Name); //Turma
                ListViewItem.ListViewSubItem lisiMessageCount = new ListViewItem.ListViewSubItem(listViewItem, student.Messages.Count.ToString()); //Quantidade de mensagem

                List<Grade> grades = student.Grades.FindAll(g => g.Student == student).ToList();
                string text;
                if (grades.Count > 0)
                {
                    // Média geral
                    double average = grades.Average(g => g.Value);
                    text = average.ToString();
                }
                else
                {
                    // Não existem notas
                    text = "Sem notas";
                }

                ListViewItem.ListViewSubItem lisiAvg = new ListViewItem.ListViewSubItem(listViewItem, text);    //Media
                ListViewItem.ListViewSubItem lisiEmail = new ListViewItem.ListViewSubItem(listViewItem, user.Email); //Email
                ListViewItem.ListViewSubItem lisiContact = new ListViewItem.ListViewSubItem(listViewItem, user.PhoneNumber); //Numero
                ListViewItem.ListViewSubItem lisiAddr = new ListViewItem.ListViewSubItem(listViewItem,user.Address); //Morada

                listViewItem.SubItems.Add(lisiSchoolNumber);
                listViewItem.SubItems.Add(lisiNif);
                listViewItem.SubItems.Add(lisiClassYear);
                listViewItem.SubItems.Add(lisiClass);
                listViewItem.SubItems.Add(lisiMessageCount);
                listViewItem.SubItems.Add(lisiAvg);
                listViewItem.SubItems.Add(lisiEmail);
                listViewItem.SubItems.Add(lisiContact);
                listViewItem.SubItems.Add(lisiAddr);

            }
            else  //Professor
            {
                Teacher teacher = (Teacher)user;

                List<TeacherClassSubject> teacherClassSubjects = admin.TeacherClassSubjects.FindAll(tcs => tcs.Teacher == teacher);
                string differentClasses = teacherClassSubjects.Select(tcs => tcs.Class).Distinct().Count().ToString();

                ListViewItem.ListViewSubItem lisiQttClass = new ListViewItem.ListViewSubItem(listViewItem, differentClasses); //Qtd turmas diferentes
                ListViewItem.ListViewSubItem lisiNif = new ListViewItem.ListViewSubItem(listViewItem, teacher.Nif); //Nif
                ListViewItem.ListViewSubItem lisiEmail = new ListViewItem.ListViewSubItem(listViewItem, user.Email); //Email
                ListViewItem.ListViewSubItem lisiContact = new ListViewItem.ListViewSubItem(listViewItem, user.PhoneNumber); //Numero
                ListViewItem.ListViewSubItem lisiAddr = new ListViewItem.ListViewSubItem(listViewItem, user.Address); //Morada


                listViewItem.SubItems.Add(lisiQttClass);
                listViewItem.SubItems.Add(lisiNif);
                listViewItem.SubItems.Add(lisiEmail);
                listViewItem.SubItems.Add(lisiContact);
                listViewItem.SubItems.Add(lisiAddr);


            }
            

            return listViewItem;
        }

    }
}
