namespace Question_Maintenance
{
    partial class UpdateQuestion
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
            this.txtUpdateQuestion = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblUpdateQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtUpdateQuestion
            // 
            this.txtUpdateQuestion.Location = new System.Drawing.Point(36, 56);
            this.txtUpdateQuestion.Name = "txtUpdateQuestion";
            this.txtUpdateQuestion.Size = new System.Drawing.Size(641, 22);
            this.txtUpdateQuestion.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(534, 93);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(143, 37);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblUpdateQuestion
            // 
            this.lblUpdateQuestion.AutoSize = true;
            this.lblUpdateQuestion.Location = new System.Drawing.Point(33, 19);
            this.lblUpdateQuestion.Name = "lblUpdateQuestion";
            this.lblUpdateQuestion.Size = new System.Drawing.Size(0, 17);
            this.lblUpdateQuestion.TabIndex = 2;
            // 
            // UpdateQuestion
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 152);
            this.Controls.Add(this.lblUpdateQuestion);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtUpdateQuestion);
            this.Name = "UpdateQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Question";
            this.Load += new System.EventHandler(this.UpdateQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUpdateQuestion;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblUpdateQuestion;
    }
}