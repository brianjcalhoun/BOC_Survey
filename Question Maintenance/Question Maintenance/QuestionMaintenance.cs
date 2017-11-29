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
    public partial class QuestionMaintenance : Form
    {

        public Questions newQuestion = new Questions();
        public List<Questions> newQuestionList = new List<Questions>();
        public int count;

        //populates the existing list of questions when directed back to the question maint form from Survey Maintenance form
        public QuestionMaintenance(List<Questions> existingQuestionList)
        {
            InitializeComponent();

            foreach (Questions q in existingQuestionList)
            {
                newQuestionList.Add(q);
            }
            
        }

        public QuestionMaintenance()
        {
            InitializeComponent();
        }

        //If questions List contains any questions, call the fill list box method
        private void QuestionMaintenance_Load(object sender, EventArgs e)
        {
            if (newQuestionList.Count > 0)
            FillQuestionListBox();

            txtQuestion.Focus();

        }
        
        //Add new question event, adds the questions content from txtbox and and quesiton id.
        //Then adds the question to a question List and calls fill list box method
        //clears txtbox and focus cursor back on it to easily enter another questions if desired
        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtQuestion.Text != "" && !(lstQuestions.Items.Contains(txtQuestion.Text)))
            {
                newQuestion = new Questions();

                newQuestion.QuestionContent = txtQuestion.Text.Trim();
                newQuestion.QuestionID = count++;

                newQuestionList.Add(newQuestion);

                this.FillQuestionListBox();

                txtQuestion.Text = "";
                txtQuestion.Focus();
            }
        }

        //Event that calls the survey Maint form and passes the question list made with it
        private void btnCreateSurvey_Click(object sender, EventArgs e)
        {
            
            SurveyMaintenance surveyMaintenance = new SurveyMaintenance(newQuestionList);
            this.Hide();
            surveyMaintenance.ShowDialog();

        }


        //Opens up update question form so user can updated the question. Will only open if an item is selected from the listbox.
        //passes the selected index from the list of questions to the update form
        //returns the update to the question content only, not the question ID
        private void btnUpdate_Click(object sender, EventArgs e)
        {          
            int i = lstQuestions.SelectedIndex;
            if (i != -1)
            {
                UpdateQuestion updateQuestionForm = new UpdateQuestion(newQuestionList[lstQuestions.SelectedIndex]);
                DialogResult result = updateQuestionForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    newQuestionList[lstQuestions.SelectedIndex].QuestionContent = updateQuestionForm.ReturnUpdate;

                    FillQuestionListBox();
                }
            }
            else
            {
                MessageBox.Show( "Please select a question from the list to update.", "Selection Error" );
            }
        }

        //Method that cycles through the questions list and adds them to the desired listbox
        private void FillQuestionListBox()
        {
            
            lstQuestions.Items.Clear();
            foreach (Questions q in newQuestionList)
            {
                lstQuestions.Items.Add(q.GetDisplayText());
            }
        }

        //Event that deletes the selected question and cycles through the question list and re populates the list box
        //has some validation to process this if something is actually selected before it performs the function
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstQuestions.SelectedIndex;

            if (i != -1)
            {
                Questions question = newQuestionList[i];
                string message = "Are you sure you want to delete this question?";
                DialogResult button = MessageBox.Show(message, "Confrim Delete", MessageBoxButtons.YesNo);

                if (button == DialogResult.Yes)
                {
                    newQuestionList.Remove(question);
                    FillQuestionListBox();
                }
            }

            txtQuestion.Focus();
        }
    }
}
