using EscolaVirtual.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscolaVirtual.Forms
{
    public partial class FormCreateSubject : Form
    {
        Admin admin;
        public FormCreateSubject(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            
        }

        private void UpdateBouttuonState() 
        {
            bool isValid = cbClassYear.SelectedItem != null && !string.IsNullOrWhiteSpace(txtSubjectName.Text);
            btnCreateSubject.Enabled = isValid;
        }
        private void cbClassYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateBouttuonState();
        }

        private void txtSubjectName_TextChanged(object sender, EventArgs e)
        {
            UpdateBouttuonState();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreateSubject_Click(object sender, EventArgs e)
        {

           if(cbClassYear.SelectedItem == null) 
            {
                MessageBox.Show("Seleciona um ano!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string subjectName = txtSubjectName.Text.Trim();

            if (string.IsNullOrWhiteSpace(subjectName)) 
            {
                MessageBox.Show("Introduz o nome da disciplina!","ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedYearText = cbClassYear.SelectedItem.ToString();

       
            string cleanYearName = selectedYearText.Replace(" Ano", "").Trim();

           
            ClassYear selectedClassYear = admin.ClassYears.FirstOrDefault(cy => cy.YearName.Equals(cleanYearName, StringComparison.OrdinalIgnoreCase));

            if (selectedClassYear == null) 
            {
                MessageBox.Show("O ano escolar selecionado é Invalido!","ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool alreadyExists = selectedClassYear.Subject != null && selectedClassYear.Subject.Any(s => s.SubjectName == subjectName);

            if (alreadyExists)
            {
                MessageBox.Show("A Disciplina ja existe para este ano escolar!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Subject newSubject = new Subject(selectedClassYear, subjectName);

            if(selectedClassYear.Subject == null) 
            { 
                selectedClassYear.Subject = new List<Subject>();
            }

            selectedClassYear.Subject.Add(newSubject);

            MessageBox.Show("Disciplina criada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            txtSubjectName.Clear();
            cbClassYear.SelectedIndex = -1;
        }
    }
}
