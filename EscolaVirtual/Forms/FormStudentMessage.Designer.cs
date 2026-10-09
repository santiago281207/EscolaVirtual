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
            this.lvwMessage = new System.Windows.Forms.ListView();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwMessage
            // 
            this.lvwMessage.HideSelection = false;
            this.lvwMessage.Location = new System.Drawing.Point(12, 12);
            this.lvwMessage.Name = "lvwMessage";
            this.lvwMessage.Size = new System.Drawing.Size(539, 374);
            this.lvwMessage.TabIndex = 0;
            this.lvwMessage.UseCompatibleStateImageBehavior = false;
            this.lvwMessage.View = System.Windows.Forms.View.Details;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(428, 392);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(123, 46);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Sair";
            this.btnLogOut.UseVisualStyleBackColor = true;
            // 
            // FormStudentMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lvwMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormStudentMessage";
            this.Text = "Mensagens";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwMessage;
        private System.Windows.Forms.Button btnLogOut;
    }
}