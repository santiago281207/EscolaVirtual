using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual.Classes
{
    public abstract class User
    {
        public User(string password,string name,string nif,int userType)
        {
            this.Password = password;
            this.Name = name;
            this.Nif = nif;
            this.UserType = userType;
        }

        #region Properties and Members
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

        private string m_nif;
        public string Nif
        {
            get { return m_nif; }
            set { m_nif = value; }
        }
        #endregion


    }
}
