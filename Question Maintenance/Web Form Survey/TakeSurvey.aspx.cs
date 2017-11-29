using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BOCClassLibrary;

namespace Web_Form_Survey
{
    public partial class TakeSurvey : System.Web.UI.Page
    {
        SurveysList sl;
        public CompletedSurvey sComplete = new CompletedSurvey();
        int count;

        protected void Page_Load(object sender, EventArgs e)
        {
            sl = SurveysList.Create();

            if (!IsPostBack)
            {
                ddlSurveyList.Items.Add("Please select a survey");

                foreach (Surveys s in sl.surveys)
                {
                    ddlSurveyList.Items.Add(s.GetDisplayText());
                }
            }
        }

        protected void ddlSurveyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = ddlSurveyList.SelectedIndex;

            if (i != -1 && i > 0)
            {
                lblQuestion1.Visible = true;
                lblQuestion2.Visible = true;
                lblQuestion3.Visible = true;
                lblQuestion4.Visible = true;
                lblQuestion5.Visible = true;

                RadioButtonList1.Visible = true;
                RadioButtonList2.Visible = true;
                RadioButtonList3.Visible = true;
                RadioButtonList4.Visible = true;
                RadioButtonList5.Visible = true;

                RadioButtonList1.Enabled = true;
                RadioButtonList2.Enabled = true;
                RadioButtonList3.Enabled = true;
                RadioButtonList4.Enabled = true;
                RadioButtonList5.Enabled = true;

                lblQuestion1.Text = sl.surveys[i - 1].SurveyQuestions[0].QuestionContent;
                lblQuestion2.Text = sl.surveys[i - 1].SurveyQuestions[1].QuestionContent;
                lblQuestion3.Text = sl.surveys[i - 1].SurveyQuestions[2].QuestionContent;
                lblQuestion4.Text = sl.surveys[i - 1].SurveyQuestions[3].QuestionContent;
                lblQuestion5.Text = sl.surveys[i - 1].SurveyQuestions[4].QuestionContent;

                lblSaved.Visible = false;
            }
            else if (i == 0)
            {
                lblQuestion1.Visible = false;
                lblQuestion2.Visible = false;
                lblQuestion3.Visible = false;
                lblQuestion4.Visible = false;
                lblQuestion5.Visible = false;

                RadioButtonList1.Visible = false;
                RadioButtonList2.Visible = false;
                RadioButtonList3.Visible = false;
                RadioButtonList4.Visible = false;
                RadioButtonList5.Visible = false;

            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            sComplete.CompletedSurveyID = count++;

            sComplete.CompletedSurveyName = ddlSurveyList.Text;

            sComplete.Answer1 = RadioButtonList1.SelectedValue;
            sComplete.Answer2 = RadioButtonList2.SelectedValue;
            sComplete.Answer3 = RadioButtonList3.SelectedValue;
            sComplete.Answer4 = RadioButtonList4.SelectedValue;
            sComplete.Answer5 = RadioButtonList5.SelectedValue;

            sComplete.Question1 = lblQuestion1.Text;
            sComplete.Question2 = lblQuestion2.Text;
            sComplete.Question3 = lblQuestion3.Text;
            sComplete.Question4 = lblQuestion4.Text;
            sComplete.Question5 = lblQuestion5.Text;

            if (sComplete.Answer1 != string.Empty && sComplete.Answer2 != string.Empty &&
                sComplete.Answer3 != string.Empty && sComplete.Answer4 != string.Empty && sComplete.Answer5 != string.Empty)
            {
                lblSaved.Visible = true;

                ddlSurveyList.SelectedIndex = 0;

                lblQuestion1.Visible = false;
                lblQuestion2.Visible = false;
                lblQuestion3.Visible = false;
                lblQuestion4.Visible = false;
                lblQuestion5.Visible = false;

                RadioButtonList1.Visible = false;
                RadioButtonList2.Visible = false;
                RadioButtonList3.Visible = false;
                RadioButtonList4.Visible = false;
                RadioButtonList5.Visible = false;

                RadioButtonList1.ClearSelection();
                RadioButtonList2.ClearSelection();
                RadioButtonList3.ClearSelection();
                RadioButtonList4.ClearSelection();
                RadioButtonList5.ClearSelection();
            }

        }
    }
}