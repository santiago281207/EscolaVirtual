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
    public partial class FormChangeDataStudent : Form
    {
        Student student;
        public FormChangeDataStudent(Student student)
        {
            InitializeComponent();
            this.student = student;
        }
    }
}
