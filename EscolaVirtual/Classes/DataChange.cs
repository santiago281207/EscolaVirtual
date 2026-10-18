using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual.Classes
{
    public class DataChange
    {
        public DataChange(Admin admin,Teacher teacher,string changeTitle,string description,string newName,string newEmail,string newAddress,string newPhoneNumber)
        {
            
            this.Teacher = teacher;
            this.ChangeTitle = changeTitle;
            this.Description = description;
            IsApproved = false;

            this.NewName = newName;
            this.NewEmail = newEmail;
            this.NewAddress = newAddress;
            this.NewPhoneNumber = NewPhoneNumber;

            admin.DataChanges.Add(this);
        }

        public DataChange(Admin admin,Student student, string changeTitle, string description, string newName, string newEmail, string newAddress, string newPhoneNumber)
        {
            this.Student = student;
            this.ChangeTitle = changeTitle;
            this.Description = description;
            IsApproved = false;

            this.NewName = newName;
            this.NewEmail = newEmail;
            this.NewAddress = newAddress;
            this.NewPhoneNumber = NewPhoneNumber;

        }

        private bool m_isApproved;
        public bool IsApproved 
        { 
          get { return m_isApproved; }
          set { m_isApproved = value; } 
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


    }
}
