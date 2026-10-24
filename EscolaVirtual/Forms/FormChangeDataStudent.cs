using EscolaVirtual.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EscolaVirtual.Forms
{
    public partial class FormChangeDataStudent : Form
    {
        Student student;
        Admin admin;
        public FormChangeDataStudent(Student student,Admin admin)
        {
            InitializeComponent();
            this.student = student;
            this.admin = admin;
        }

        private void FormChangeDataStudent_Load(object sender, EventArgs e)
        {
            txtName.Text = student.Name;
            txtEmail.Text = student.Email;
            txtAddress.Text = student.Address;
            txtPhoneNumber.Text = student.PhoneNumber;
        }

        private void btnChangeData_Click(object sender, EventArgs e)
        {
            string titleText = $"Alterar dados de aluno: {student.Name}.";
            string descriptionText = "Caro administrador gostaria de alterar os seguintes dados:";

            if (txtName.Text != student.Name)
            {
                descriptionText += $"\nO meu nome de {student.Name} para {txtName.Text}";
            }

            if (txtEmail.Text != student.Email)
            {
                descriptionText += $"\nO meu email de {student.Email} para {txtEmail.Text}";
            }

            if (txtPhoneNumber.Text != student.PhoneNumber)
            {
                descriptionText += $"\nO meu número de telemóvel de {student.PhoneNumber} para {txtPhoneNumber.Text}";
            }

            if (txtAddress.Text != student.Address)
            {
                descriptionText += $"\nA minha morada de {student.Address} para {txtAddress.Text}";
            }

            descriptionText += $"\nCom os melhores cumprimentos,\n{student.Name}";

            DataChange dataChange = new DataChange(admin, student, titleText, descriptionText, txtName.Text, txtEmail.Text, txtAddress.Text, txtPhoneNumber.Text);

            MessageBox.Show("Pedido de alteração de dados enviado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
            if ((txtAddress.Text != "" && txtEmail.Text != "" && txtName.Text != "" && txtPhoneNumber.Text != "") &&
               (txtAddress.Text != student.Address || txtEmail.Text != student.Email || txtName.Text != student.Name || txtPhoneNumber.Text != student.PhoneNumber)
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
             (txtAddress.Text != student.Address || txtEmail.Text != student.Email || txtName.Text != student.Name || txtPhoneNumber.Text != student.PhoneNumber)
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
               (txtAddress.Text != student.Address || txtEmail.Text != student.Email || txtName.Text != student.Name || txtPhoneNumber.Text != student.PhoneNumber)
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
            (txtAddress.Text != student.Address || txtEmail.Text != student.Email || txtName.Text != student.Name || txtPhoneNumber.Text != student.PhoneNumber)
            && txtPhoneNumber.Text.Length == 9)
            {
                btnChangeData.Enabled = Methods.IsEmail(txtEmail.Text);
            }
            else
            {
                btnChangeData.Enabled = false;
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsWhiteSpace(e.KeyChar);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsLetter(e.KeyChar) && !Char.IsWhiteSpace(e.KeyChar) && e.KeyChar != 8;
        }

        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Char.IsSymbol(e.KeyChar);
        }

        private void txtPhoneNumber_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }
    }
}




