using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EscolaVirtual.Classes;

namespace EscolaVirtual
{
    public partial class Form_Login : Form
    {
        Admin admin;
        public Form_Login(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = admin.Users.FirstOrDefault(u => u.Nif == txtLogin.Text && u.Password == txtPassword.Text);

            if (txtPassword.Text == "0000" && txtLogin.Text == "0000")
            {
                FormAdmin adminForm = new FormAdmin(admin);
                adminForm.Show();
                this.Hide();
            }
            else
            {
                if (user != null)
                {
                    //User
                    if (user.UserType == 1)
                    {
                        FormStudent studentForm = new FormStudent(admin,(Student)user);
                        this.Hide();
                        studentForm.Show();
                    }
                    else //Teacher
                    {
                        FormTeacher teacherForm = new FormTeacher(admin,(Teacher)user);
                        this.Hide();
                        teacherForm.Show();
                    }
                }
                else //User not found
                {
                    MessageBox.Show("Número de login ou password errados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != 8 || e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtLogin.Text.Length > 0 && txtPassword.Text.Length == 4)
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {
            if (txtLogin.Text.Length > 0 && txtPassword.Text.Length == 4)
            {
                btnLogin.Enabled = true;
            }
            else
            {
                btnLogin.Enabled = false;
            }
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar) && e.KeyChar != 8 || e.KeyChar == 32)
            {
                e.Handled = true;
            }
        }

        private void Form_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
