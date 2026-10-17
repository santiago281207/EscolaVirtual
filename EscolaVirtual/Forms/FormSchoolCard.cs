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
    public partial class FormSchoolCard : Form
    {
        Student student;
        public FormSchoolCard(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != 8;
        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if(txtAmount.Text.Length > 0)
            {
                btnDeposit.Enabled = true;
            }else
            {
                btnDeposit.Enabled = false;
            }
        }
    }
}
