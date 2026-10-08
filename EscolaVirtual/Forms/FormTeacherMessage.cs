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
    public partial class FormTeacherMessage : Form
    {
        public FormTeacherMessage()
        {
            InitializeComponent();
        }

        private void cbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            //faz uma que se chame todos e mande msg para todos os alunos
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text == "")
            {
                btnSend.Enabled = false;
            }
            else { 
                btnSend.Enabled = true;
            }
        }
    }
}
