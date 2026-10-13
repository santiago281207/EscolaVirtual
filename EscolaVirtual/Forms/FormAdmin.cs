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
            FormAddYear form = new FormAddYear(admin);
            form.Show();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            FormAddStudent form = new FormAddStudent(admin);
            form.Show();
        }

        private void tcCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (tcCategories.SelectedIndex)
            {
                case 0: //Aluno
                    lvwStudent.Items.Clear();
                    List<ListViewItem> listViewItems1 = admin.Users.Where(u => u.UserType == 1).Select(u => u.ToListViewItem(u,admin)).ToList();
                    listViewItems1.ForEach(li => lvwStudent.Items.Add(li));

                    break;
                case 1: //Professor
                    lvwTeacher.Items.Clear();
                    List<ListViewItem> listViewItems2 = admin.Users.Where(u => u.UserType == 2).Select(u => u.ToListViewItem(u,admin)).ToList();
                    listViewItems2.ForEach(li => lvwTeacher.Items.Add(li));

                    break;
                case 2: //Turma
                    lvwClass.Items.Clear();
                    List<ListViewItem> listViewItems3 = admin.ClassYears.SelectMany(cy => cy.Classes).Select(c => c.ToListViewItem(c)).ToList();
                    listViewItems3.ForEach(li => lvwClass.Items.Add(li));
                    break;
                case 3: //Ano
                    lvwYear.Items.Clear();

                    break;
                case 4: //Disciplina
                    lvwSubject.Items.Clear();
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
            FormCreateSubject form = new FormCreateSubject(admin);
            form.Show();
        }

        private void btnAddTeacher_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Show();
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            Form form = new Form();
            form.Show();
        }
    }
}
