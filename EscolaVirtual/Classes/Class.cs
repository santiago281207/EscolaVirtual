using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaVirtual.Classes
{
    public class Class
    {
        // Construtor atualizado com o parâmetro maxStudents
        public Class(string name, ClassYear classYear, int maxStudents)
        {
            this.Name = name;
            this.SchoolYear = classYear;
            this.m_maxStudents = maxStudents;

            classYear.Classes.Add(this);
        }

        // Mantém uma sobrecarga caso precises noutra parte do código,ex: valoe padrão de 30 alunos
        public Class(string name, ClassYear classYear) : this(name, classYear, 30)
        {
        }

        #region Properties and Members

        private string m_name;
        public string Name
        {
            get { return m_name; }
            set { m_name = value; }
        }

        private int m_maxStudents;
        public int MaxStudents
        {
            get { return m_maxStudents; }
            set { m_maxStudents = value; }
        }

        List<Student> m_students = new List<Student>();
        public List<Student> Student
        {
            get { return m_students; }
            set { m_students = value; }
        }

        private ClassYear m_schoolYear;
        public ClassYear SchoolYear
        {
            get { return m_schoolYear; }
            set { m_schoolYear = value; }
        }

        #endregion

        // Método auxiliar para verificar se a turma ainda tem vagas
        public bool HasAvailableSlots()
        {
            return Student.Count < MaxStudents;
        }

        public ListViewItem ToListViewItem(Class @class)
        {
            ListViewItem listViewItem = new ListViewItem(@class.Name);
            ListViewItem.ListViewSubItem lisiStudentQtt = new ListViewItem.ListViewSubItem(listViewItem, @class.Student.Count.ToString());
            ListViewItem.ListViewSubItem lisiClassYear = new ListViewItem.ListViewSubItem(listViewItem, @class.SchoolYear.YearName);

            listViewItem.SubItems.Add(lisiStudentQtt);
            listViewItem.SubItems.Add(lisiClassYear);

            return listViewItem;
        }

        public string ClassNameWithYear
        {
            get { return Name + " - " + SchoolYear.YearName + " Ano"; }
        }
    }
}