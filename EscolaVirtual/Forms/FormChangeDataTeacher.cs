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

namespace EscolaVirtual.Forms
{
    public partial class FormChangeDataTeacher : Form
    {
        Teacher teacher;
        Admin admin;
        public FormChangeDataTeacher(Teacher teacher, Admin admin)
        {
            InitializeComponent();
            this.teacher = teacher;
            this.admin = admin;
        }

        private void FormChangeDataTeacher_Load(object sender, EventArgs e)
        {
            txtName.Text = teacher.Name;
            txtEmail.Text = teacher.Email;
            txtAddress.Text = teacher.Address;
            txtPhoneNumber.Text = teacher.PhoneNumber;
        }

        private void btnChangeData_Click(object sender, EventArgs e)
        {
            string titleText = $"Alterar dados de aluno: {teacher.Name}.";
            string descriptionText = "Caro administrador gostaria de alterar os seguintes dados:";

            if (txtName.Text != teacher.Name)
            {
                descriptionText += $"\nO meu nome de {teacher.Name} para {txtName.Text}";
            }

            if (txtEmail.Text != teacher.Email)
            {
                descriptionText += $"\nO meu email de {teacher.Email} para {txtEmail.Text}";
            }

            if (txtPhoneNumber.Text != teacher.PhoneNumber)
            {
                descriptionText += $"\nO meu número de telemóvel de {teacher.PhoneNumber} para {txtPhoneNumber.Text}";
            }

            if (txtAddress.Text != teacher.Address)
            {
                descriptionText += $"\nA minha morada de {teacher.Address} para {txtAddress.Text}";
            }

            descriptionText += $"\nCom os melhores cumprimentos,\nProfessor {teacher.Name}";

            DataChange dataChange = new DataChange(admin, teacher, titleText, descriptionText, txtName.Text, txtEmail.Text, txtAddress.Text, txtPhoneNumber.Text);

            MessageBox.Show("Pedido de alteração de dados enviado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if ((txtAddress.Text != "" && txtEmail.Text != "" && txtName.Text != "" && txtPhoneNumber.Text != "") &&
             (txtAddress.Text != teacher.Address || txtEmail.Text != teacher.Email || txtName.Text != teacher.Name || txtPhoneNumber.Text != teacher.PhoneNumber)
             && txtPhoneNumber.Text.Length == 9)
            {
                btnChangeData.Enabled = Methods.IsEmail(txtEmail.Text);
            }
            else
            {
                btnChangeData.Enabled = false;
            }
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            if ((txtAddress.Text != "" && txtEmail.Text != "" && txtName.Text != "" && txtPhoneNumber.Text != "") &&
            (txtAddress.Text != teacher.Address || txtEmail.Text != teacher.Email || txtName.Text != teacher.Name || txtPhoneNumber.Text != teacher.PhoneNumber)
            && txtPhoneNumber.Text.Length == 9)
            {
                btnChangeData.Enabled = Methods.IsEmail(txtEmail.Text);
            }
            else
            {
                btnChangeData.Enabled = false;
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if ((txtAddress.Text != "" && txtEmail.Text != "" && txtName.Text != "" && txtPhoneNumber.Text != "") &&
             (txtAddress.Text != teacher.Address || txtEmail.Text != teacher.Email || txtName.Text != teacher.Name || txtPhoneNumber.Text != teacher.PhoneNumber)
             && txtPhoneNumber.Text.Length == 9)
            {
                btnChangeData.Enabled = Methods.IsEmail(txtEmail.Text);
            }
            else
            {
                btnChangeData.Enabled = false;
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if ((txtAddress.Text != "" && txtEmail.Text != "" && txtName.Text != "" && txtPhoneNumber.Text != "") &&
         (txtAddress.Text != teacher.Address || txtEmail.Text != teacher.Email || txtName.Text != teacher.Name || txtPhoneNumber.Text != teacher.PhoneNumber)
         && txtPhoneNumber.Text.Length == 9)
            {
                btnChangeData.Enabled = Methods.IsEmail(txtEmail.Text);
            }
            else
            {
                btnChangeData.Enabled = false;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8;
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsSymbol(e.KeyChar);
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
