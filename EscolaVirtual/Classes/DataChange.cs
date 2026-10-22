using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaVirtual.Classes
{
    public class DataChange
    {
        public DataChange(Admin admin,Teacher teacher,string changeTitle,string description,string newName,string newEmail,string newAddress,string newPhoneNumber)
        {
            this.Id = admin.DataChanges.Count + 1;
            this.Teacher = teacher;
            this.ChangeTitle = changeTitle;
            this.Description = description;
            IsApproved = null;

            this.NewName = newName;
            this.NewEmail = newEmail;
            this.NewAddress = newAddress;
            this.NewPhoneNumber = newPhoneNumber;

            admin.DataChanges.Add(this);
        }

        public DataChange(Admin admin,Student student, string changeTitle, string description, string newName, string newEmail, string newAddress, string newPhoneNumber)
        {
            this.Id = admin.DataChanges.Count + 1;
            this.Student = student;
            this.ChangeTitle = changeTitle;
            this.Description = description;
            IsApproved = null;

            this.NewName = newName;
            this.NewEmail = newEmail;
            this.NewAddress = newAddress;
            this.NewPhoneNumber = newPhoneNumber;

            admin.DataChanges.Add(this);
        }

        private int m_id;
        public int Id
        {
            get { return m_id; }
            set { m_id = value; }
        }

        private bool? m_isApproved;
        public bool? IsApproved
        {
            get { return m_isApproved; }
            set
            {
                m_isApproved = value;

                if (m_isApproved == true)
                {
                    if (Teacher != null)
                    {
                        Teacher.Name = NewName;
                        Teacher.Email = NewEmail;
                        Teacher.Address = NewAddress;
                        Teacher.PhoneNumber = NewPhoneNumber;
                    }
                    else if (Student != null)
                    {
                        Student.Name = NewName;
                        Student.Email = NewEmail;
                        Student.Address = NewAddress;
                        Student.PhoneNumber = NewPhoneNumber;
                    }
                }
            }
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

        private string m_newName;
        public string NewName
        {
            get { return m_newName; }
            set { m_newName = value; }
        }
        private string m_newEmail;
        public string NewEmail
        {
            get { return m_newEmail; }
            set { m_newEmail = value; }
        }
        private string m_newAddress;
        public string NewAddress
        {
            get { return m_newAddress; }
            set { m_newAddress = value; }
        }
        private string m_newPhoneNumber;
        public string NewPhoneNumber
        {
            get { return m_newPhoneNumber; }
            set { m_newPhoneNumber = value; }
        }

        public ListViewItem ToListViewItem(DataChange dataChange)
        {

            ListViewItem listViewItem = new ListViewItem(Student == null ? Teacher.Name : Student.Name);
            ListViewItem.ListViewSubItem lisiDescription = new ListViewItem.ListViewSubItem(listViewItem,Description);

            listViewItem.SubItems.Add(lisiDescription);
            listViewItem.Tag = Id;
            return listViewItem;
        }


    }
}
