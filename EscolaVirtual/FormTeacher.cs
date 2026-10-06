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
        public FormTeacher()
        {
            InitializeComponent();
            this.admin = Admin;
        }

        private void FormTeacher_Load(object sender, EventArgs e)
        {

        }

        private void btnAbsence_Click(object sender, EventArgs e)
        {
            //criar novo form para registar faltas dos alunos.
        }

        private void btnGradeStudent_Click(object sender, EventArgs e)
        {
            //criar novo form para lançar notas dos alunos.
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //criar novo form para alterar dados do professor, sendo q n sei q dados sao esses??
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            //criar form novo para mandar msg para os alunos.
        }
    }
}
