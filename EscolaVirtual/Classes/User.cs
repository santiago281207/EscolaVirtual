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
        public User(string password,string name,string nif,string email,string phoneNumber,string address,int userType)
        {
            this.Password = password;
            this.Name = name;
            this.Nif = nif;
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

        private string m_name;

        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        //Valor 1 = Aluno 
        //Valor 2 = Professor
        private int m_userType; 
        public int UserType
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
            ListViewItem listViewItem = new ListViewItem(user.Name);


            if(user.UserType == 1) //Aluno
            {
                Student student = (Student)user;
                ListViewItem.ListViewSubItem lisiNif = new ListViewItem.ListViewSubItem(listViewItem, student.Nif);
                ListViewItem.ListViewSubItem lisiClassYear = new ListViewItem.ListViewSubItem(listViewItem, student.Class.SchoolYear.YearName);
                ListViewItem.ListViewSubItem lisiClass = new ListViewItem.ListViewSubItem(listViewItem, student.Class.Name);
                ListViewItem.ListViewSubItem lisiMessageCount = new ListViewItem.ListViewSubItem(listViewItem, student.Messages.Count.ToString());

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

                ListViewItem.ListViewSubItem lisiAvg = new ListViewItem.ListViewSubItem(listViewItem, text);

                listViewItem.SubItems.Add(lisiNif);
                listViewItem.SubItems.Add(lisiClassYear);
                listViewItem.SubItems.Add(lisiClass);
                listViewItem.SubItems.Add(lisiMessageCount);
                listViewItem.SubItems.Add(lisiAvg);

            }
            else  //Professor
            {
                Teacher teacher = (Teacher)user;

                List<TeacherClassSubject> teacherClassSubjects = admin.TeacherClassSubjects.FindAll(tcs => tcs.Teacher == teacher);
                string differentClasses = teacherClassSubjects.Select(tcs => tcs.Class).Distinct().Count().ToString();

                ListViewItem.ListViewSubItem lisiNif = new ListViewItem.ListViewSubItem(listViewItem, teacher.Nif);
                ListViewItem.ListViewSubItem lisiQttClass = new ListViewItem.ListViewSubItem(listViewItem, differentClasses);

            }
            

            return listViewItem;
        }

    }
}
