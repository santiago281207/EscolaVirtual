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
    public partial class FormAbsencesStudent : Form
    {
        Student student;
        Admin admin;
        public FormAbsencesStudent(Student student,Admin admin)
        {
            InitializeComponent();
            this.student = student;
            this.admin = admin;
        }

        private void btnJustification_Click(object sender, EventArgs e)
        {
            //Faz com que o botão armazene a justificativa do aluno na falta que ele justificou
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Faz com que o botão feche a tela de justificar faltas e volte para a tela do aluno
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
        private void FormAbsencesStudent_Load(object sender, EventArgs e)
        {
            rbAllAbsences.Checked = true;

            List<ListViewItem> listViewAbsences = student.Absence.Select(ab => ab.ToListViewItem(ab)).ToList();

            listViewAbsences.ForEach(li => lvwAbsences.Items.Add(li));

        }
    }
}
