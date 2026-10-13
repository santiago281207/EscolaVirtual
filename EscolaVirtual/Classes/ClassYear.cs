using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EscolaVirtual.Classes
{
    public class ClassYear 
    {
        public ClassYear(string yearName)
        {
            this.m_yearName = yearName;
        }

        #region Properties and Members


        private string m_yearName;
        public string YearName
        {
            get { return m_yearName; }
            set { m_yearName = value; }
        }

        private List<Subject> m_subjects = new List<Subject>();
        public List<Subject> Subject
        {
            get { return m_subjects; }
            set { m_subjects = value; }
        }

        private List<Class> m_classes = new List<Class>();
        public List<Class> Classes
        {
            get { return m_classes; }
            set { m_classes = value; }
        }



        #endregion

        public ListViewItem ToListViewItem(ClassYear classYear)
        {
            ListViewItem listViewItem = new ListViewItem(classYear.YearName);
            ListViewItem.ListViewSubItem lisiClassQtt = new ListViewItem.ListViewSubItem(listViewItem, classYear.Classes.Count.ToString());
            ListViewItem.ListViewSubItem lisiSubjectQtt = new ListViewItem.ListViewSubItem(listViewItem, classYear.Subject.Count.ToString());

            listViewItem.SubItems.Add(lisiClassQtt);
            listViewItem.SubItems.Add(lisiSubjectQtt);

            return listViewItem;
        }

    }
}
