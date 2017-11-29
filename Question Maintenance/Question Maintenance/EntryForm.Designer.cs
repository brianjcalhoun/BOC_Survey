namespace Question_Maintenance
{
    partial class EntryForm
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
            this.btnCreateQuestions = new System.Windows.Forms.Button();
            this.btnCreateSurvey = new System.Windows.Forms.Button();
            this.btnTakeSurvey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateQuestions
            // 
            this.btnCreateQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateQuestions.Location = new System.Drawing.Point(47, 38);
            this.btnCreateQuestions.Name = "btnCreateQuestions";
            this.btnCreateQuestions.Size = new System.Drawing.Size(120, 79);
            this.btnCreateQuestions.TabIndex = 0;
            this.btnCreateQuestions.Text = "Create Questions";
            this.btnCreateQuestions.UseVisualStyleBackColor = true;
            this.btnCreateQuestions.Click += new System.EventHandler(this.btnCreateQuestions_Click);
            // 
            // btnCreateSurvey
            // 
            this.btnCreateSurvey.Location = new System.Drawing.Point(209, 38);
            this.btnCreateSurvey.Name = "btnCreateSurvey";
            this.btnCreateSurvey.Size = new System.Drawing.Size(120, 79);
            this.btnCreateSurvey.TabIndex = 1;
            this.btnCreateSurvey.Text = "Create Survey";
            this.btnCreateSurvey.UseVisualStyleBackColor = true;
            this.btnCreateSurvey.Click += new System.EventHandler(this.btnCreateSurvey_Click);
            this.btnCreateSurvey.MouseHover += new System.EventHandler(this.btnCreateSurvey_MouseHover);
            // 
            // btnTakeSurvey
            // 
            this.btnTakeSurvey.Location = new System.Drawing.Point(379, 38);
            this.btnTakeSurvey.Name = "btnTakeSurvey";
            this.btnTakeSurvey.Size = new System.Drawing.Size(120, 79);
            this.btnTakeSurvey.TabIndex = 2;
            this.btnTakeSurvey.Text = "Take Survey";
            this.btnTakeSurvey.UseVisualStyleBackColor = true;
            this.btnTakeSurvey.Click += new System.EventHandler(this.btnTakeSurvey_Click);
            this.btnTakeSurvey.MouseHover += new System.EventHandler(this.btnTakeSurvey_MouseHover);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 167);
            this.Controls.Add(this.btnTakeSurvey);
            this.Controls.Add(this.btnCreateSurvey);
            this.Controls.Add(this.btnCreateQuestions);
            this.Name = "EntryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Broad Overall Coverage Insurance Survey";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateQuestions;
        private System.Windows.Forms.Button btnCreateSurvey;
        private System.Windows.Forms.Button btnTakeSurvey;
    }
}