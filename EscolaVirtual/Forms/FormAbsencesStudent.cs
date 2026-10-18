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
                lvwAbsences.SelectedItems.Clear();
                btnConfirm.Enabled = false;
                btnSeeMore.Enabled = false;
            }
        }

        private void rbUnjustified_CheckedChanged(object sender, EventArgs e)
        {
            if (rbUnjustified.Checked == true)
            {
                lvwAbsences.Items.Clear();
                List<ListViewItem> listViewAbsences = student.Absence.Where(ab => ab.State == 2).Select(ab => ab.ToListViewItem(ab)).ToList();
                listViewAbsences.ForEach(li => lvwAbsences.Items.Add(li));
                lvwAbsences.SelectedItems.Clear();
                btnConfirm.Enabled = false;
                btnSeeMore.Enabled = false;
            }
        }

        private void rbAllAbsences_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAllAbsences.Checked == true)
            {
                lvwAbsences.Items.Clear();
                List<ListViewItem> listViewAbsences = student.Absence.Select(ab => ab.ToListViewItem(ab)).ToList();
                listViewAbsences.ForEach(li => lvwAbsences.Items.Add(li));
                lvwAbsences.SelectedItems.Clear();

                btnConfirm.Enabled = false;
                btnSeeMore.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FormStudent formStudent = new FormStudent(admin, student);
            this.Hide();
            formStudent.Show();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Absence absenceSelected = student.Absence.Find(ab => ab.Id == (int)lvwAbsences.SelectedItems[0].Tag);

            if(absenceSelected.State == 1)
            {
                MessageBox.Show("Falta selecionada já está justificada!", "Erro de seleção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else
            {
                absenceSelected.Justification = txtJustification.Text;
                absenceSelected.State = 1;
                MessageBox.Show("Falta justificada com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                lvwAbsences.SelectedItems[0].Remove();
                lvwAbsences.Items.Add(absenceSelected.ToListViewItem(absenceSelected));
            }

            if (rbJustified.Checked == true)
            {
                lvwAbsences.Items.Clear();
                List<ListViewItem> listViewAbsences = student.Absence.Where(ab => ab.State == 1).Select(ab => ab.ToListViewItem(ab)).ToList();
                listViewAbsences.ForEach(li => lvwAbsences.Items.Add(li));
                lvwAbsences.SelectedItems.Clear();
                btnConfirm.Enabled = false;
                btnSeeMore.Enabled = false;
            }else if (rbUnjustified.Checked == true)
            {
                lvwAbsences.Items.Clear();
                List<ListViewItem> listViewAbsences = student.Absence.Where(ab => ab.State == 2).Select(ab => ab.ToListViewItem(ab)).ToList();
                listViewAbsences.ForEach(li => lvwAbsences.Items.Add(li));
                lvwAbsences.SelectedItems.Clear();
                btnConfirm.Enabled = false;
                btnSeeMore.Enabled = false;
            }else if (rbAllAbsences.Checked == true)
            {
                lvwAbsences.Items.Clear();
                List<ListViewItem> listViewAbsences = student.Absence.Select(ab => ab.ToListViewItem(ab)).ToList();
                listViewAbsences.ForEach(li => lvwAbsences.Items.Add(li));
                lvwAbsences.SelectedItems.Clear();

                btnConfirm.Enabled = false;
                btnSeeMore.Enabled = false;
            }

        }

        private void lvwAbsences_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvwAbsences.SelectedIndices.Count == 0 ||txtJustification.Text.Length == 0)
            {
                btnConfirm.Enabled = false;
            }else if(txtJustification.Text.Length > 0 && lvwAbsences.SelectedItems.Count > 0)
            {
                btnConfirm.Enabled = true;
            }

            if (lvwAbsences.SelectedItems.Count == 0)
            {
                btnSeeMore.Enabled = false;
            }
            else
            {
                btnSeeMore.Enabled = true;
            }
        }

        private void txtJustification_TextChanged(object sender, EventArgs e)
        {
            if(txtJustification.Text.Length > 0 && lvwAbsences.SelectedIndices.Count > 0)
            {
                btnConfirm.Enabled = true;
            }else
            {
                btnConfirm.Enabled = false;
            }
        }

        private void FormAbsencesStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSeeMore_Click(object sender, EventArgs e)
        {
            string titleMessage = $"Falta às {lvwAbsences.SelectedItems[0].Text} em {lvwAbsences.SelectedItems[0].SubItems[1].Text}";
            string descriptionMessage = $"Estado da falta: {lvwAbsences.SelectedItems[0].SubItems[2].Text}\n Justificação: {lvwAbsences.SelectedItems[0].SubItems[3].Text}";

            MessageBox.Show(descriptionMessage, titleMessage, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
