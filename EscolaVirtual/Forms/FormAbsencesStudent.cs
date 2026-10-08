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
    public partial class FormAbsencesStudent : Form
    {
        public FormAbsencesStudent()
        {
            InitializeComponent();
        }

        private void btnJustification_Click(object sender, EventArgs e)
        {
            //Faz com que o botão armazene a justificativa do aluno na falta que ele justificou
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Faz com que o botão feche a tela de justificar faltas e volte para a tela do aluno
        }

        private void pCorUsername_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tvwAbsences_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
