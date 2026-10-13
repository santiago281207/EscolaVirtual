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
    public partial class FormAbsencesTeacher : Form
    {
        Admin admin;
        Teacher teacher;
        public FormAbsencesTeacher(Teacher teacher,Admin admin)
        {
            InitializeComponent();
            this.teacher = teacher;
            this.admin = admin;
        }
    }
}
