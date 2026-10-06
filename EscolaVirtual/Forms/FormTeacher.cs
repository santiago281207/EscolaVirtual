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
        public FormTeacher()
        {
            InitializeComponent();
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
    }
}
