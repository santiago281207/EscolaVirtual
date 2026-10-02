using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaVirtual.Classes
{
    public class TextMessage
    {
        public TextMessage(User sender,User recipient,string title,string body,DateTime emissionDate)
        {
            this.Sender = sender;
            this.Recipient = recipient;
            this.Title = title;
            this.Body = body;
            this.EmissionDate = emissionDate;
        }

        #region Properties and Members

        private User m_sender;
        public User Sender
        {
            get { return m_sender; }
            set { m_sender = value; }
        }

        private User m_recipient;
        public User Recipient
        {
            get { return m_recipient; }
            set { m_recipient = value; }
        }

        private string m_title;
        public string Title
        {
            get { return m_title; }
            set { m_title = value; }
        }

        private string m_body;
        public string Body
        {
            get { return m_body; }
            set { m_body = value; }
        }

        private DateTime m_emissionDate;
        public DateTime EmissionDate
        {
            get { return m_emissionDate; }
            set { m_emissionDate = value; }
        }



        #endregion


    }
}
