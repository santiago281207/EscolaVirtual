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
            this.lvwRequest = new System.Windows.Forms.ListView();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwRequest
            // 
            this.lvwRequest.HideSelection = false;
            this.lvwRequest.Location = new System.Drawing.Point(12, 12);
            this.lvwRequest.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwRequest.Name = "lvwRequest";
            this.lvwRequest.Size = new System.Drawing.Size(564, 376);
            this.lvwRequest.TabIndex = 0;
            this.lvwRequest.UseCompatibleStateImageBehavior = false;
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.Green;
            this.btnReject.Enabled = false;
            this.btnReject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReject.Location = new System.Drawing.Point(16, 25);
            this.btnReject.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(128, 57);
            this.btnReject.TabIndex = 1;
            this.btnReject.Text = "Rejeitar";
            this.btnReject.UseVisualStyleBackColor = false;
            // 
            // btnApprove
            // 
            this.btnApprove.BackColor = System.Drawing.Color.Green;
            this.btnApprove.Enabled = false;
            this.btnApprove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnApprove.Location = new System.Drawing.Point(221, 25);
            this.btnApprove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(128, 57);
            this.btnApprove.TabIndex = 2;
            this.btnApprove.Text = "Aprovar";
            this.btnApprove.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Green;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(419, 25);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 57);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnApprove);
            this.panel1.Controls.Add(this.btnReject);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Location = new System.Drawing.Point(12, 395);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 100);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Location = new System.Drawing.Point(13, 385);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 4);
            this.panel2.TabIndex = 5;
            // 
            // FormApprove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 505);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvwRequest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormApprove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aprovar";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwRequest;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}