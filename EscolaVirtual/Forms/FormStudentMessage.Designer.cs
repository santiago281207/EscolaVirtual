namespace EscolaVirtual.Forms
{
    partial class FormStudentMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStudentMessage));
            this.lvwMessage = new System.Windows.Forms.ListView();
            this.chTeacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnLogOut = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSeeMore = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwMessage
            // 
            this.lvwMessage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chTeacher,
            this.chDate,
            this.chTitle,
            this.chMessage});
            this.lvwMessage.HideSelection = false;
            this.lvwMessage.Location = new System.Drawing.Point(12, 12);
            this.lvwMessage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvwMessage.MultiSelect = false;
            this.lvwMessage.Name = "lvwMessage";
            this.lvwMessage.Size = new System.Drawing.Size(539, 374);
            this.lvwMessage.TabIndex = 0;
            this.lvwMessage.UseCompatibleStateImageBehavior = false;
            this.lvwMessage.View = System.Windows.Forms.View.Details;
            this.lvwMessage.SelectedIndexChanged += new System.EventHandler(this.lvwMessage_SelectedIndexChanged);
            // 
            // chTeacher
            // 
            this.chTeacher.Text = "Professor";
            this.chTeacher.Width = 120;
            // 
            // chDate
            // 
            this.chDate.Text = "Data";
            this.chDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chDate.Width = 130;
            // 
            // chTitle
            // 
            this.chTitle.Text = "Título";
            this.chTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chTitle.Width = 80;
            // 
            // chMessage
            // 
            this.chMessage.Text = "Mensagem";
            this.chMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chMessage.Width = 70;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.Green;
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogOut.Location = new System.Drawing.Point(287, 12);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(236, 46);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Sair";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnSeeMore);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Location = new System.Drawing.Point(12, 393);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 71);
            this.panel1.TabIndex = 2;
            // 
            // btnSeeMore
            // 
            this.btnSeeMore.BackColor = System.Drawing.Color.Green;
            this.btnSeeMore.Enabled = false;
            this.btnSeeMore.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeeMore.Location = new System.Drawing.Point(16, 12);
            this.btnSeeMore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSeeMore.Name = "btnSeeMore";
            this.btnSeeMore.Size = new System.Drawing.Size(241, 46);
            this.btnSeeMore.TabIndex = 2;
            this.btnSeeMore.Text = "Ver Mais";
            this.btnSeeMore.UseVisualStyleBackColor = false;
            this.btnSeeMore.Click += new System.EventHandler(this.btnSeeMore_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Location = new System.Drawing.Point(12, 382);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(539, 4);
            this.panel2.TabIndex = 3;
            // 
            // FormStudentMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 476);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvwMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormStudentMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mensagens";
            this.Load += new System.EventHandler(this.FormStudentMessage_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwMessage;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ColumnHeader chTeacher;
        private System.Windows.Forms.ColumnHeader chDate;
        private System.Windows.Forms.ColumnHeader chTitle;
        private System.Windows.Forms.ColumnHeader chMessage;
        private System.Windows.Forms.Button btnSeeMore;
    }
}