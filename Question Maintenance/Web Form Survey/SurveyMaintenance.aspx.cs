using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BOCClassLibrary;

namespace Web_Form_Survey
{
    public partial class SurveyMaintenance : System.Web.UI.Page
    {
        public QuestionsList ql;
        public Surveys newSurvey = new Surveys();
        SurveysList sl;
        public int count;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                ql = QuestionsList.CreateList();

                ddlQuestion1.Items.Add("Please select a question.");
                ddlQuestion2.Items.Add("Please select a question.");
                ddlQuestion3.Items.Add("Please select a question.");
                ddlQuestion4.Items.Add("Please select a question.");
                ddlQuestion5.Items.Add("Please select a question.");

                foreach (Questions q in ql.questions)
                {
                    ddlQuestion1.Items.Add(q.GetDisplayText());
                    ddlQuestion2.Items.Add(q.GetDisplayText());
                    ddlQuestion3.Items.Add(q.GetDisplayText());
                    ddlQuestion4.Items.Add(q.GetDisplayText());
                    ddlQuestion5.Items.Add(q.GetDisplayText());
                }

                ddlQuestion1.SelectedIndex = 0;
                ddlQuestion2.SelectedIndex = 0;
                ddlQuestion3.SelectedIndex = 0;
                ddlQuestion4.SelectedIndex = 0;
                ddlQuestion5.SelectedIndex = 0;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                sl = SurveysList.Create();

                if (txtSurveyName.Text != string.Empty &&
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

                    newSurvey.SurveyQuestions.Add(new Questions { QuestionContent = ddlQuestion1.Text, QuestionID = ddlQuestion1.SelectedIndex });
                    newSurvey.SurveyQuestions.Add(new Questions { QuestionContent = ddlQuestion2.Text, QuestionID = ddlQuestion2.SelectedIndex });
                    newSurvey.SurveyQuestions.Add(new Questions { QuestionContent = ddlQuestion3.Text, QuestionID = ddlQuestion3.SelectedIndex });
                    newSurvey.SurveyQuestions.Add(new Questions { QuestionContent = ddlQuestion4.Text, QuestionID = ddlQuestion4.SelectedIndex });
                    newSurvey.SurveyQuestions.Add(new Questions { QuestionContent = ddlQuestion5.Text, QuestionID = ddlQuestion5.SelectedIndex });

                    newSurvey.SurveyID = count++;
                    newSurvey.Name = txtSurveyName.Text;

                    sl.surveys.Add(newSurvey);

                    txtSurveyName.Text = string.Empty;

                    ddlQuestion1.SelectedIndex = 0;
                    ddlQuestion2.SelectedIndex = 0;
                    ddlQuestion3.SelectedIndex = 0;
                    ddlQuestion4.SelectedIndex = 0;
                    ddlQuestion5.SelectedIndex = 0;

                    txtSurveyName.Focus();

                    lblSurveySave.Visible = false;
                }
                else
                {
                    lblSurveySave.Visible = true;
                }
            }
        }

        protected void btnTakeSurvey_Click(object sender, EventArgs e)
        {
            Response.Redirect("TakeSurvey.aspx", false);
        }
    }
}