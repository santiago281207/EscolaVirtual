using EscolaVirtual.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaVirtual
{
    public partial class FormAbsencesStudent : Form
    {
        Student student;
        Admin admin;
        public FormAbsencesStudent(Student student,Admin admin)
        {
            InitializeComponent();
            this.student = student;
            this.admin = admin;
        }
        private void FormAbsencesStudent_Load(object sender, EventArgs e)
        {
            rbAllAbsences.Checked = true;

            List<ListViewItem> listViewAbsences = student.Absence.Select(ab => ab.ToListViewItem(ab)).ToList();

            listViewAbsences.ForEach(li => lvwAbsences.Items.Add(li));

        }

        private void rbJustified_CheckedChanged(object sender, EventArgs e)
        {
            if(rbJustified.Checked == true)
            {
                lvwAbsences.Items.Clear();
                List<ListViewItem> listViewAbsences = student.Absence.Where(ab => ab.State == 1).Select(ab => ab.ToListViewItem(ab)).ToList();
                listViewAbsences.ForEach(li => lvwAbsences.Items.Add(li));
            }
        }

        private void rbUnjustified_CheckedChanged(object sender, EventArgs e)
        {
            if (rbJustified.Checked == true)
            {
                lvwAbsences.Items.Clear();
                List<ListViewItem> listViewAbsences = student.Absence.Where(ab => ab.State == 2).Select(ab => ab.ToListViewItem(ab)).ToList();
                listViewAbsences.ForEach(li => lvwAbsences.Items.Add(li));
            }
        }

        private void rbAllAbsences_CheckedChanged(object sender, EventArgs e)
        {
            if (rbJustified.Checked == true)
            {
                lvwAbsences.Items.Clear();
                List<ListViewItem> listViewAbsences = student.Absence.Select(ab => ab.ToListViewItem(ab)).ToList();
                listViewAbsences.ForEach(li => lvwAbsences.Items.Add(li));
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
