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

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void lvwStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
