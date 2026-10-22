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
    
    public partial class FormApprove : Form
    {
        Admin admin;
        private bool changed;

        public bool Changed
        {
            get { return changed; }
            set { changed = value; }
        }
        public FormApprove(Admin admin)
        {
            InitializeComponent();
            this.admin = admin;
            this.changed = changed;
            Changed = false;
        }

        
        private void FormApprove_Load(object sender, EventArgs e)
        {
            List<DataChange> dataChanges = admin.DataChanges;

            List<ListViewItem> listViewItems = dataChanges.FindAll(dtc => dtc.IsApproved == null).Select(dtc => dtc.ToListViewItem(dtc)).ToList();

            listViewItems.ForEach(lvi => lvwRequest.Items.Add(lvi));
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lvwRequest_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvwRequest.SelectedItems.Count == 0)
            {
                btnApprove.Enabled = false;
                btnReject.Enabled = false;
                btnSeeMore.Enabled = false;
            }else
            {
                btnApprove.Enabled = true;
                btnReject.Enabled = true;
                btnSeeMore.Enabled = true;
            }
        }

        private void btnSeeMore_Click(object sender, EventArgs e)
        {
            DataChange dataChange = admin.DataChanges.FirstOrDefault(dtc => dtc.Id == (int)lvwRequest.SelectedItems[0].Tag);

            MessageBox.Show($"De:{lvwRequest.SelectedItems[0].Text}\n{dataChange.Description}", dataChange.ChangeTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            DataChange dataChange = admin.DataChanges.FirstOrDefault(dtc => dtc.Id == (int)lvwRequest.SelectedItems[0].Tag);

            dataChange.IsApproved = true;

            MessageBox.Show("Pedido aceite com sucesso", "Pedido aceite!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lvwRequest.Items.Clear();

            List<DataChange> dataChanges = admin.DataChanges;

            List<ListViewItem> listViewItems = dataChanges.FindAll(dtc => dtc.IsApproved == null).Select(dtc => dtc.ToListViewItem(dtc)).ToList();

            listViewItems.ForEach(lvi => lvwRequest.Items.Add(lvi));

            btnApprove.Enabled = false;
            btnReject.Enabled = false;
            btnSeeMore.Enabled = false;

            Changed = true;
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            DataChange dataChange = admin.DataChanges.FirstOrDefault(dtc => dtc.Id == (int)lvwRequest.SelectedItems[0].Tag);

            dataChange.IsApproved = false;

            MessageBox.Show("Pedido rejeitado com sucesso", "Pedido rejeitado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            lvwRequest.Items.Clear();

            List<DataChange> dataChanges = admin.DataChanges;

            List<ListViewItem> listViewItems = dataChanges.FindAll(dtc => dtc.IsApproved == null).Select(dtc => dtc.ToListViewItem(dtc)).ToList();

            listViewItems.ForEach(lvi => lvwRequest.Items.Add(lvi));

            btnApprove.Enabled = false;
            btnReject.Enabled = false;
            btnSeeMore.Enabled = false;
        }
    }
}
