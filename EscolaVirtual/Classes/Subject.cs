using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaVirtual.Classes
{
    public class Subject
    {
        public Subject(ClassYear classYear,string subjectName)
        {
            this.ClassYear = classYear;
            this.SubjectName = subjectName;
        }

        #region Properties and Members

        private ClassYear m_classYear;
        public ClassYear ClassYear
        {
            get { return m_classYear; }
            set { m_classYear = value; }
        }

        private string m_subjectName;
        public string SubjectName
        {
            get { return m_subjectName; }
            set { m_subjectName = value; }
        }

        private List<Module> m_module = new List<Module>();
        public List<Module> Module
        {
            get { return m_module; }
            set { m_module = value; }
        }

        #endregion

        public ListViewItem ToListViewItem(Subject subject)
        {
            ListViewItem listViewItem = new ListViewItem(subject.SubjectName);
            ListViewItem.ListViewSubItem lisiSubjectYear = new ListViewItem.ListViewSubItem(listViewItem, subject.ClassYear.YearName);
            ListViewItem.ListViewSubItem lisiModuleQtt = new ListViewItem.ListViewSubItem(listViewItem, subject.Module.Count.ToString());

            listViewItem.SubItems.Add(lisiSubjectYear);
            listViewItem.SubItems.Add(lisiModuleQtt);

            return listViewItem;
        }


    }
}
