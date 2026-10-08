using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaVirtual.Classes
{
    public class Teacher : User
    {
        public Teacher(string password,string name,string nif) : base(password,name,nif,2)
        {

        }



        #region Properties and Members

        private List<TextMessage> m_messages = new List<TextMessage>();
        public List<TextMessage> Messages
        {
            get { return m_messages; }
            set { m_messages = value; }
        }

        #endregion

    }
}
