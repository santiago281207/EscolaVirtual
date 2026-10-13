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
    public partial class FormAssociate : Form
    {
        Admin admin;
        public FormAssociate(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
        }
    }
}
