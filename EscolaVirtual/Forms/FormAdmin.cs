using EscolaVirtual.Classes;
using EscolaVirtual.Forms;
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
    public partial class FormAdmin : Form
    {
        Admin admin;
        public FormAdmin(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form_Login loginForm = new Form_Login(admin);
            this.Hide();
            loginForm.Show();
        }

        private void btnAddYear_Click(object sender, EventArgs e)
        {
            FormAddYear formaddyear = new FormAddYear(admin);
            formaddyear.ShowDialog();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            FormAddStudent formaddstudent = new FormAddStudent(admin);
            formaddstudent.ShowDialog();
        }

        private void tcCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (tcCategories.SelectedIndex)
            {
                case 0: //Aluno
                    lvwStudent.Items.Clear();
                    List<ListViewItem> listViewItems1 = admin.Users.Where(u => u.UserType == UserRole.Student).Select(u => u.ToListViewItem(u,admin)).ToList();
                    listViewItems1.ForEach(li => lvwStudent.Items.Add(li));

                    break;
                case 1: //Professor
                    lvwTeacher.Items.Clear();
                    List<ListViewItem> listViewItems2 = admin.Users.Where(u => u.UserType == UserRole.Teacher).Select(u => u.ToListViewItem(u,admin)).ToList();
                    listViewItems2.ForEach(li => lvwTeacher.Items.Add(li));

                    break;
                case 2: //Turma
                    lvwClass.Items.Clear();
                    List<ListViewItem> listViewItems3 = admin.ClassYears.SelectMany(cy => cy.Classes).Select(c => c.ToListViewItem(c)).ToList();
                    listViewItems3.ForEach(li => lvwClass.Items.Add(li));
                    break;
                case 3: //Ano
                    lvwYear.Items.Clear();
                    List<ListViewItem> listViewItems4 = admin.ClassYears.Select(cy => cy.ToListViewItem(cy)).ToList();
                    listViewItems4.ForEach(li => lvwYear.Items.Add(li));
                    break;
                case 4: //Disciplina
                    lvwSubject.Items.Clear();
                    List<ListViewItem> listViewItems5 = admin.ClassYears.SelectMany(cy => cy.Subject.Select(s => s.ToListViewItem(s))).ToList();
                    listViewItems5.ForEach(li => lvwSubject.Items.Add(li)); 
                    break;
                default:
                    break;
            }
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
            //Para ativar evento - "tcCategories_SelectedIndexChanged"
            tcCategories.SelectedIndex = 1;
            tcCategories.SelectedIndex = 0;

        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            FormCreateSubject formaddsubject = new FormCreateSubject(admin);
            formaddsubject.ShowDialog();
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            FormAddTeacher formaddteacher = new FormAddTeacher(admin);
            formaddteacher.ShowDialog();
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            FormCreateClass formcreateclass  = new FormCreateClass(admin);
            formcreateclass.ShowDialog();
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            FormAssociate formassociate = new FormAssociate(admin);
            formassociate.ShowDialog();
        }
    }
}
