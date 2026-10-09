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
            FormAddYear form = new FormAddYear();
            form.Show();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            FormAddStudent form = new FormAddStudent();
            form.Show();
        }
    }
}
