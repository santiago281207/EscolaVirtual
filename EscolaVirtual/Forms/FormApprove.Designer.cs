namespace EscolaVirtual.Forms
{
    partial class FormApprove
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormApprove));
            this.btnReject = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chRequestOwner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvwRequest = new System.Windows.Forms.ListView();
            this.chDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSeeMore = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.Green;
            this.btnReject.Enabled = false;
            this.btnReject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReject.Location = new System.Drawing.Point(316, 20);
            this.btnReject.Margin = new System.Windows.Forms.Padding(2);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(96, 46);
            this.btnReject.TabIndex = 1;
            this.btnReject.Text = "Rejeitar";
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.Green;
            this.btnApprove.Enabled = false;
            this.btnApprove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnApprove.Location = new System.Drawing.Point(6, 20);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(2);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(96, 46);
            this.btnApprove.TabIndex = 2;
            this.btnApprove.Text = "Aprovar";
            this.btnApprove.UseVisualStyleBackColor = false;
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Green;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(110, 20);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(96, 46);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnSeeMore);
            this.panel1.Controls.Add(this.btnApprove);
            this.panel1.Controls.Add(this.btnReject);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Location = new System.Drawing.Point(9, 321);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 81);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Location = new System.Drawing.Point(10, 313);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(422, 3);
            this.panel2.TabIndex = 5;
            // 
            // chRequestOwner
            // 
            this.chRequestOwner.Text = "Utilizador";
            this.chRequestOwner.Width = 100;
            // 
            // lvwRequest
            // 
            this.lvwRequest.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chRequestOwner,
            this.chDescription});
            this.lvwRequest.HideSelection = false;
            this.lvwRequest.Location = new System.Drawing.Point(9, 10);
            this.lvwRequest.Margin = new System.Windows.Forms.Padding(2);
            this.lvwRequest.MultiSelect = false;
            this.lvwRequest.Name = "lvwRequest";
            this.lvwRequest.Size = new System.Drawing.Size(424, 306);
            this.lvwRequest.TabIndex = 0;
            this.lvwRequest.UseCompatibleStateImageBehavior = false;
            this.lvwRequest.View = System.Windows.Forms.View.Details;
            this.lvwRequest.SelectedIndexChanged += new System.EventHandler(this.lvwRequest_SelectedIndexChanged);
            // 
            // chDescription
            // 
            this.chDescription.Text = "Pedido de alteração";
            this.chDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chDescription.Width = 140;
            // 
            // btnSeeMore
            // 
            this.btnSeeMore.BackColor = System.Drawing.Color.Green;
            this.btnSeeMore.Enabled = false;
            this.btnSeeMore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeeMore.Location = new System.Drawing.Point(213, 20);
            this.btnSeeMore.Margin = new System.Windows.Forms.Padding(2);
            this.btnSeeMore.Name = "btnSeeMore";
            this.btnSeeMore.Size = new System.Drawing.Size(96, 46);
            this.btnSeeMore.TabIndex = 4;
            this.btnSeeMore.Text = "Ver Mais";
            this.btnSeeMore.UseVisualStyleBackColor = false;
            this.btnSeeMore.Click += new System.EventHandler(this.btnSeeMore_Click);
            // 
            // FormApprove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 410);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvwRequest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormApprove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aprovar";
            this.Load += new System.EventHandler(this.FormApprove_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColumnHeader chRequestOwner;
        private System.Windows.Forms.ListView lvwRequest;
        private System.Windows.Forms.Button btnSeeMore;
        private System.Windows.Forms.ColumnHeader chDescription;
    }
}