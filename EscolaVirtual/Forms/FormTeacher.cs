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
    public partial class FormTeacher : Form
    {
        Admin admin;
        Teacher teacher;
        public FormTeacher(Admin admin,Teacher teacher)
        {
            InitializeComponent();
            this.admin = admin;
            this.teacher = teacher;
        }

        private void btnGrades_Click(object sender, EventArgs e)
        {
            // criar um form novo para poder editar e por notas 
        }

        private void btnAbsences_Click(object sender, EventArgs e)
        {
            // criar um form novo para poder marcar faltas
        }

        private void btnChangeData_Click(object sender, EventArgs e)
        {
            // criar form para poder mudar os dados do professor
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            // criar form para poder mandar mensagens para os alunos
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form_Login loginForm = new Form_Login(admin);
            this.Hide();
            loginForm.Show();
        }
    }
}
