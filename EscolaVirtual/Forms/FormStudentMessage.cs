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
    public partial class FormStudentMessage : Form
    {
        Student student;
        public FormStudentMessage(Student student)
        {
            InitializeComponent();
            this.student = student;
        }

        private void FormStudentMessage_Load(object sender, EventArgs e)
        {
            List<ListViewItem> listViewItems = student.Messages.Select(msg => msg.ToListViewItem(msg)).ToList();
            listViewItems.ForEach(lvi => lvwMessage.Items.Add(lvi));
        }

        private void lvwMessage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvwMessage.SelectedIndices.Count == 0)
            {
                btnSeeMore.Enabled = false;
            }
            else
            {
                btnSeeMore.Enabled = true;
            }
            
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeeMore_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"De Professor {lvwMessage.SelectedItems[0].Text} às {lvwMessage.SelectedItems[0].SubItems[1].Text}\n{lvwMessage.SelectedItems[0].SubItems[3].Text}",
                            $"{lvwMessage.SelectedItems[0].SubItems[2].Text}",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
