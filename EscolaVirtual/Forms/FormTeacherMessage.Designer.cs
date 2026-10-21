namespace EscolaVirtual
{
    partial class FormTeacherMessage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTeacherMessage));
            this.lvwMessages = new System.Windows.Forms.ListView();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.cbClass = new System.Windows.Forms.ComboBox();
            this.cbStudent = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblStudent = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.chStudent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chEmissionDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMessageBody = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvwMessages
            // 
            this.lvwMessages.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chStudent,
            this.chEmissionDate,
            this.chTitle,
            this.chMessageBody});
            this.lvwMessages.HideSelection = false;
            this.lvwMessages.Location = new System.Drawing.Point(9, 18);
            this.lvwMessages.Margin = new System.Windows.Forms.Padding(2);
            this.lvwMessages.Name = "lvwMessages";
            this.lvwMessages.Size = new System.Drawing.Size(456, 570);
            this.lvwMessages.TabIndex = 0;
            this.lvwMessages.UseCompatibleStateImageBehavior = false;
            this.lvwMessages.View = System.Windows.Forms.View.Details;
            // 
            // txtTitle
            // 
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(8, 31);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.MaxLength = 70;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(238, 20);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.TextChanged += new System.EventHandler(this.txtTitle_TextChanged);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Green;
            this.btnSend.Enabled = false;
            this.btnSend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSend.Location = new System.Drawing.Point(590, 5);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(131, 37);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Green;
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(8, 5);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(131, 37);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cbClass
            // 
            this.cbClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbClass.FormattingEnabled = true;
            this.cbClass.Location = new System.Drawing.Point(7, 13);
            this.cbClass.Margin = new System.Windows.Forms.Padding(2);
            this.cbClass.Name = "cbClass";
            this.cbClass.Size = new System.Drawing.Size(238, 21);
            this.cbClass.TabIndex = 4;
            this.cbClass.SelectedIndexChanged += new System.EventHandler(this.cbClass_SelectedIndexChanged);
            // 
            // cbStudent
            // 
            this.cbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStudent.Enabled = false;
            this.cbStudent.FormattingEnabled = true;
            this.cbStudent.Location = new System.Drawing.Point(7, 56);
            this.cbStudent.Margin = new System.Windows.Forms.Padding(2);
            this.cbStudent.Name = "cbStudent";
            this.cbStudent.Size = new System.Drawing.Size(239, 21);
            this.cbStudent.TabIndex = 5;
            this.cbStudent.SelectedIndexChanged += new System.EventHandler(this.cbStudent_SelectedIndexChanged);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(5, 0);
            this.lblClass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(40, 13);
            this.lblClass.TabIndex = 6;
            this.lblClass.Text = "Turma:";
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Location = new System.Drawing.Point(5, 41);
            this.lblStudent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(37, 13);
            this.lblStudent.TabIndex = 7;
            this.lblStudent.Text = "Aluno:";
            // 
            // txtMessage
            // 
            this.txtMessage.Enabled = false;
            this.txtMessage.Location = new System.Drawing.Point(8, 87);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(2);
            this.txtMessage.MaxLength = 2000;
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(238, 363);
            this.txtMessage.TabIndex = 8;
            this.txtMessage.TextChanged += new System.EventHandler(this.txtMessage_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Assunto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mensagem:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.cbStudent);
            this.panel1.Controls.Add(this.lblStudent);
            this.panel1.Controls.Add(this.cbClass);
            this.panel1.Controls.Add(this.lblClass);
            this.panel1.Location = new System.Drawing.Point(486, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 91);
            this.panel1.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Green;
            this.panel6.Location = new System.Drawing.Point(7, 75);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(237, 3);
            this.panel6.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Green;
            this.panel5.Location = new System.Drawing.Point(8, 36);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(237, 3);
            this.panel5.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Silver;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtTitle);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtMessage);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(486, 130);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 457);
            this.panel2.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Green;
            this.panel4.Location = new System.Drawing.Point(8, 446);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(237, 3);
            this.panel4.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Location = new System.Drawing.Point(8, 46);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 3);
            this.panel3.TabIndex = 13;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Silver;
            this.panel7.Controls.Add(this.btnBack);
            this.panel7.Controls.Add(this.btnSend);
            this.panel7.Location = new System.Drawing.Point(9, 592);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(728, 49);
            this.panel7.TabIndex = 13;
            // 
            // chStudent
            // 
            this.chStudent.Text = "Aluno";
            this.chStudent.Width = 80;
            // 
            // chEmissionDate
            // 
            this.chEmissionDate.Text = "Data de envio";
            this.chEmissionDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chEmissionDate.Width = 100;
            // 
            // chTitle
            // 
            this.chTitle.Text = "Titulo da mensagem";
            this.chTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chTitle.Width = 130;
            // 
            // chMessageBody
            // 
            this.chMessageBody.Text = "Corpo da mensagem";
            this.chMessageBody.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chMessageBody.Width = 140;
            // 
            // FormTeacherMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 650);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvwMessages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FormTeacherMessage";
            this.Text = "FormTeacherMessage";
            this.Load += new System.EventHandler(this.FormTeacherMessage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwMessages;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cbClass;
        private System.Windows.Forms.ComboBox cbStudent;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ColumnHeader chStudent;
        private System.Windows.Forms.ColumnHeader chEmissionDate;
        private System.Windows.Forms.ColumnHeader chTitle;
        private System.Windows.Forms.ColumnHeader chMessageBody;
    }
}