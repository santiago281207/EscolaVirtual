using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EscolaVirtual.Classes
{
    public class Teacher : User
    {
        public Teacher(string password,string name,string nif,string email,string phoneNumber,string address) : base(password, name, nif, email, phoneNumber, address, 2)
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
