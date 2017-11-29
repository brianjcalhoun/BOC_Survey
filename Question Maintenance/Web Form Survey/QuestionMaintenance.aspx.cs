using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BOCClassLibrary;


namespace Web_Form_Survey
{
    public partial class QuestionMaintenance : System.Web.UI.Page
    {

        public Questions newQuestion = new Questions();
        QuestionsList ql;
        public int count;

        protected void Page_Load(object sender, EventArgs e)
        {
            ql = QuestionsList.CreateList();

            if (!IsPostBack)
            if (ql.questions.Count > 0)
                FillQuestionListBox();

            txtQuestion.Focus();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                ql = QuestionsList.CreateList();

                ListItem x = new ListItem();
                x.Value = txtQuestion.Text.Trim();

                if (txtQuestion.Text != "" && !(lstQuestions.Items.Contains(x)))
                {
                    newQuestion = new Questions();

                    newQuestion.QuestionContent = txtQuestion.Text.Trim();
                    newQuestion.QuestionID = count++;

                    ql.questions.Add(newQuestion);

                    this.FillQuestionListBox();

                    txtQuestion.Text = "";
                    txtQuestion.Focus();

                    lblValidate.Visible = false;
                }
                else
                {
                    lblValidate.Visible = true;
                }
            }

        }

        private void FillQuestionListBox()
        {

            lstQuestions.Items.Clear();
            foreach (Questions q in ql.questions)
            {
                lstQuestions.Items.Add(q.GetDisplayText());
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            ql = QuestionsList.CreateList();

            int i = lstQuestions.SelectedIndex;

            if (i != -1)
            {
                ql.questions.RemoveAt(i);
                FillQuestionListBox();
            }

            txtQuestion.Focus();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            ql = QuestionsList.CreateList();

            int i = lstQuestions.SelectedIndex;

            if (i != -1)
            {
                txtQuestion.Text = lstQuestions.SelectedItem.Text.ToString();
                ql.questions.RemoveAt(i);
                FillQuestionListBox();
            }
        }

        protected void btnCreateSurvey_Click(object sender, EventArgs e)
        {
            Response.Redirect("SurveyMaintenance.aspx", false);
        }
    }
}