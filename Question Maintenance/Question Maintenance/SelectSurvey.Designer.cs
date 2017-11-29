namespace Question_Maintenance
{
    partial class SelectSurvey
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
            this.label1 = new System.Windows.Forms.Label();
            this.lstSurveys = new System.Windows.Forms.ListBox();
            this.btnTakeSurvey = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 35);
            this.label1.MaximumSize = new System.Drawing.Size(350, 40);
            this.label1.MinimumSize = new System.Drawing.Size(200, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a Survey from the list below.";
            // 
            // lstSurveys
            // 
            this.lstSurveys.FormattingEnabled = true;
            this.lstSurveys.ItemHeight = 16;
            this.lstSurveys.Location = new System.Drawing.Point(45, 89);
            this.lstSurveys.Name = "lstSurveys";
            this.lstSurveys.Size = new System.Drawing.Size(313, 388);
            this.lstSurveys.TabIndex = 1;
            // 
            // btnTakeSurvey
            // 
            this.btnTakeSurvey.Location = new System.Drawing.Point(138, 493);
            this.btnTakeSurvey.Name = "btnTakeSurvey";
            this.btnTakeSurvey.Size = new System.Drawing.Size(120, 30);
            this.btnTakeSurvey.TabIndex = 2;
            this.btnTakeSurvey.Text = "Take Survey";
            this.btnTakeSurvey.UseVisualStyleBackColor = true;
            this.btnTakeSurvey.Click += new System.EventHandler(this.btnTakeSurvey_Click);
            // 
            // SelectSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 537);
            this.Controls.Add(this.btnTakeSurvey);
            this.Controls.Add(this.lstSurveys);
            this.Controls.Add(this.label1);
            this.Name = "SelectSurvey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Survey Selection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstSurveys;
        private System.Windows.Forms.Button btnTakeSurvey;
    }
}