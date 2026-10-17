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
    public partial class FormAddYear : Form
    {
        Admin admin;
        public FormAddYear(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void FormAddYear_Load(object sender, EventArgs e)
        {

        }

        private void txtAddYear_TextChanged(object sender, EventArgs e)
        {
            if (txtAddYear.Text == "")
            {
                btnCreate.Enabled = false;
            }
            else
            {
                btnCreate.Enabled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
