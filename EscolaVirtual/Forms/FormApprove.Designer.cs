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
            this.lvwRequest = new System.Windows.Forms.ListView();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvwRequest
            // 
            this.lvwRequest.HideSelection = false;
            this.lvwRequest.Location = new System.Drawing.Point(12, 12);
            this.lvwRequest.Name = "lvwRequest";
            this.lvwRequest.Size = new System.Drawing.Size(484, 349);
            this.lvwRequest.TabIndex = 0;
            this.lvwRequest.UseCompatibleStateImageBehavior = false;
            // 
            // btnReject
            // 
            this.btnReject.Location = new System.Drawing.Point(12, 367);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(128, 56);
            this.btnReject.TabIndex = 1;
            this.btnReject.Text = "Rejeitar";
            this.btnReject.UseVisualStyleBackColor = true;
            // 
            // btnApprove
            // 
            this.btnApprove.Location = new System.Drawing.Point(191, 367);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(128, 56);
            this.btnApprove.TabIndex = 2;
            this.btnApprove.Text = "Aprovar";
            this.btnApprove.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(368, 367);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 56);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // FormApprove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 433);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnApprove);
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.lvwRequest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormApprove";
            this.Text = "Aprovar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwRequest;
        private System.Windows.Forms.Button btnReject;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnBack;
    }
}