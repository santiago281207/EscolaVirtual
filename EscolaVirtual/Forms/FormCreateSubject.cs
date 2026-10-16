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
    public partial class FormCreateSubject : Form
    {
        Admin admin;
        public FormCreateSubject(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void cbClassYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbClassYear == null || txtSubjectName.Text == "")
            {
                btnCreateSubject.Enabled = false;
            }
            else
            {
                btnCreateSubject.Enabled = true;
            }
        }

        private void txtSubjectName_TextChanged(object sender, EventArgs e)
        {
            if (cbClassYear == null || txtSubjectName.Text == "")
            {
                btnCreateSubject.Enabled = false;
            }
            else
            {
                btnCreateSubject.Enabled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
