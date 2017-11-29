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
    public partial class SurveyMaintenance : Form
    {
        
        public List<Questions> existingQuestionLIst = new List<Questions>();
        public List<Questions> surveyQuestionList = new List<Questions>();
        public Surveys newSurvey = new Surveys();
        public List<Surveys> newSurveyList = new List<Surveys>();
        
        int count;

        //I refer to my combox boxes as dropdownlists(ddl)
        //I add the the first index of my ddls to a string to help guide user and set the display to that on load
        //The foreach loop adds all existing questions into each combo box
        public SurveyMaintenance(List<Questions> newQuestionList)
        {
            InitializeComponent();

            ddlQuestion1.Items.Add("Please select a question.");
            ddlQuestion2.Items.Add("Please select a question.");
            ddlQuestion3.Items.Add("Please select a question.");
            ddlQuestion4.Items.Add("Please select a question.");
            ddlQuestion5.Items.Add("Please select a question.");

            foreach (Questions q in newQuestionList)
            {
                ddlQuestion1.Items.Add(q.GetDisplayText());
                ddlQuestion2.Items.Add(q.GetDisplayText());
                ddlQuestion3.Items.Add(q.GetDisplayText());
                ddlQuestion4.Items.Add(q.GetDisplayText());
                ddlQuestion5.Items.Add(q.GetDisplayText());
                existingQuestionLIst.Add(q);
            }

            ddlQuestion1.SelectedIndex = 0;
            ddlQuestion2.SelectedIndex = 0;
            ddlQuestion3.SelectedIndex = 0;
            ddlQuestion4.SelectedIndex = 0;
            ddlQuestion5.SelectedIndex = 0;

        }

        public SurveyMaintenance()
        {
            InitializeComponent();
        }

        //Validates to makes sure Survey has a name, a questions is selected and 2 of the same questions are not selected
        //assigns selected quesitons to the surveys list of questions
        //assigned survey name and ID
        //Add completed survey to a LIST of surveys
        //resets text box and ddl index back to 0, gives confrimation that Survey was saved
        
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtSurveyName.Text != "" &&
                ddlQuestion1.SelectedIndex > 0 &&
                ddlQuestion2.SelectedIndex > 0 &&
                ddlQuestion3.SelectedIndex > 0 &&
                ddlQuestion4.SelectedIndex > 0 &&
                ddlQuestion5.SelectedIndex > 0 &&
                ddlQuestion1.SelectedIndex != ddlQuestion2.SelectedIndex &&
                ddlQuestion1.SelectedIndex != ddlQuestion3.SelectedIndex &&
                ddlQuestion1.SelectedIndex != ddlQuestion4.SelectedIndex &&
                ddlQuestion1.SelectedIndex != ddlQuestion5.SelectedIndex &&
                ddlQuestion2.SelectedIndex != ddlQuestion3.SelectedIndex &&
                ddlQuestion2.SelectedIndex != ddlQuestion4.SelectedIndex &&
                ddlQuestion2.SelectedIndex != ddlQuestion5.SelectedIndex &&
                ddlQuestion3.SelectedIndex != ddlQuestion4.SelectedIndex &&
                ddlQuestion3.SelectedIndex != ddlQuestion5.SelectedIndex &&
                ddlQuestion4.SelectedIndex != ddlQuestion5.SelectedIndex)
            {

                newSurvey = new Surveys();

                newSurvey.SurveyQuestions.Add(new Questions { QuestionContent = ddlQuestion1.Text,
                    QuestionID = ddlQuestion1.SelectedIndex });
                newSurvey.SurveyQuestions.Add(new Questions { QuestionContent = ddlQuestion2.Text,
                    QuestionID = ddlQuestion2.SelectedIndex });
                newSurvey.SurveyQuestions.Add(new Questions { QuestionContent = ddlQuestion3.Text,
                    QuestionID = ddlQuestion3.SelectedIndex });
                newSurvey.SurveyQuestions.Add(new Questions { QuestionContent = ddlQuestion4.Text,
                    QuestionID = ddlQuestion4.SelectedIndex });
                newSurvey.SurveyQuestions.Add(new Questions { QuestionContent = ddlQuestion5.Text,
                    QuestionID = ddlQuestion5.SelectedIndex });

                newSurvey.SurveyID = count++;
                newSurvey.Name = txtSurveyName.Text;

                newSurveyList.Add(newSurvey);

                txtSurveyName.Text = "";

                ddlQuestion1.SelectedIndex = 0;
                ddlQuestion2.SelectedIndex = 0;
                ddlQuestion3.SelectedIndex = 0;
                ddlQuestion4.SelectedIndex = 0;
                ddlQuestion5.SelectedIndex = 0;

                txtSurveyName.Focus();

                MessageBox.Show("Survey was successfully saved.");

                //newSurvey.SurveyQuestions.Clear();
            }
            else
            {
                MessageBox.Show("Please make sure you have 5 different questions selected.", "Selection Error");
            }
        }

        //takes user the Survey selection form and pass the list of surveys and list of survey questions.
        private void btnTakeSurvey_Click(object sender, EventArgs e)
        {
            SelectSurvey selectSurveyForm = new SelectSurvey(newSurveyList);
            this.Hide();
            selectSurveyForm.ShowDialog();
        }

        //takes user back to question maintenance form to add a new questions, passes over existingquestion list to add on to
        private void btnAddNewQuestion_Click(object sender, EventArgs e)
        {
            QuestionMaintenance questionMaintenance = new QuestionMaintenance(existingQuestionLIst);
            this.Hide();
            questionMaintenance.ShowDialog();
        }

    }
}
