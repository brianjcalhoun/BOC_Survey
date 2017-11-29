using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOCClassLibrary;

namespace Question_Maintenance
{
    public partial class UpdateQuestion : Form
    {

        //gets question content from selected question from the question maintenance form and set lbl text to that grabbed content
        public UpdateQuestion(Questions newQuestion)
        {
            InitializeComponent();

            lblUpdateQuestion.Text = newQuestion.QuestionContent;
        }

        public UpdateQuestion()
        {
            InitializeComponent();
        }

        private void UpdateQuestion_Load(object sender, EventArgs e)
        {
            
        }

        //public property return updated info back to question maint form
        public string ReturnUpdate { get; set; }

        //event handler that makes sure text was entered into the txt box, trims the text and sets the string ReturnUpdate property to what was entered into text
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtUpdateQuestion.Text != "")
            {
                ReturnUpdate = txtUpdateQuestion.Text.Trim();
                this.DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("Text field can not be empty to update the question", "Entry Error");
            }
        }


    }
}
