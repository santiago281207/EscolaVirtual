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

        private void cbClassYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClassYear == null || txtSubjectName.Text == "")
            {
                btnCreateSubject.Enabled = false;
            }
            else
            {
                btnCreateSubject.Enabled = true;
            }
        }

        private void txtSubjectName_TextChanged(object sender, EventArgs e)
        {
            if (cbClassYear == null || txtSubjectName.Text == "")
            {
                btnCreateSubject.Enabled = false;
            }
            else
            {
                btnCreateSubject.Enabled = true;
            }
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
                MessageBox.Show("Introduz o nome da disciplina!");
                return;
            }

            ClassYear selectedClassYear = cbClassYear.SelectedItem as ClassYear;

            if(selectedClassYear == null) 
            {
                MessageBox.Show("O ano escolar selecionado é Invalido!");
                return;
            }

            //var alreadyExists = selectedClassYear.Subject.FirstOrDefault(s => s.SubjectName  selectedClassYear.Subject));

            //if (alreadyExists) 
            //{
            //    MessageBox.Show("A disciplina já existe para este ano escolar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
