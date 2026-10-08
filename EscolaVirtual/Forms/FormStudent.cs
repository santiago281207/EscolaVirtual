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
    public partial class FormStudent : Form
    {
        Student student;
        Admin admin;
        public FormStudent(Admin admin,Student student)
        {
            InitializeComponent();
            this.student = student;
            this.admin = admin;
        }

        private void FormStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form_Login loginForm = new Form_Login(admin);
            this.Hide();
            loginForm.Show();
        }
    }
}
