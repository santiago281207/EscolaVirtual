using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            sender.Messages.Add(this);
            recipient.Messages.Add(this);
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


        public ListViewItem ToListViewItem(TextMessage txtMessage)
        {
            ListViewItem listViewItem = new ListViewItem(txtMessage.Sender.Name);
            ListViewItem.ListViewSubItem lisiDate = new ListViewItem.ListViewSubItem(listViewItem, txtMessage.EmissionDate.Date.ToString("G"));
            ListViewItem.ListViewSubItem lisiTitle = new ListViewItem.ListViewSubItem(listViewItem, txtMessage.Title);
            ListViewItem.ListViewSubItem lisiBody = new ListViewItem.ListViewSubItem(listViewItem, txtMessage.Body);

            listViewItem.SubItems.Add(lisiDate);
            listViewItem.SubItems.Add(lisiTitle);
            listViewItem.SubItems.Add(lisiBody);

            return listViewItem;
        }

    }
}
