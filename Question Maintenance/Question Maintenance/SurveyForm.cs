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
    public partial class SurveyForm : Form
    {
        public List<Questions> qList = new List<Questions>();
        public CompletedSurvey sComplete = new CompletedSurvey();
        int count;

        //Takes the questions from the selected survey ads them to the group box text
        //assigns selected survey name to a label
        public SurveyForm(Surveys selectedSurvey)
        {
            InitializeComponent();
            foreach (Questions q in selectedSurvey.SurveyQuestions)
            {
                qList.Add(q);
            }

            lblSurveyName.Text = selectedSurvey.Name;

            groupBox1.Text = qList[0].QuestionContent;
            groupBox2.Text = qList[1].QuestionContent;
            groupBox3.Text = qList[2].QuestionContent;
            groupBox4.Text = qList[3].QuestionContent;
            groupBox5.Text = qList[4].QuestionContent;

        }

        public SurveyForm()
        {
            InitializeComponent();
        }

        //assigns the lbl text to the the completed survey name
        private void SurveyForm_Load(object sender, EventArgs e)
        {
            sComplete.CompletedSurveyName = lblSurveyName.Text;
        }

        //statement that assigns the Q1 answer to the text of the checked radio button
        private void Answer1(object sender, EventArgs e)
        {
            if (rbQ1Agree.Checked)
            {
                sComplete.Answer1 = rbQ1Agree.Text;
            }
            else if (rbQ1Disagree.Checked)
            {
                sComplete.Answer1 = rbQ1Disagree.Text;
            }
            else if (rbQ1NA.Checked)
            {
                sComplete.Answer1 = rbQ1NA.Text;
            }
        }

        //statement that assigns the Q2 answer to the text of the checked radio button
        private void Answer2(object sender, EventArgs e)
        {
            if (rbQ2Agree.Checked)
            {
                sComplete.Answer2 = rbQ2Agree.Text;
            }
            else if (rbQ2Disagree.Checked)
            {
                sComplete.Answer2 = rbQ2Disagree.Text;
            }
            else if (rbQ2NA.Checked)
            {
                sComplete.Answer2 = rbQ2NA.Text;
            }
        }

        //statement that assigns the Q3 answer to the text of the checked radio button
        private void Answer3(object sender, EventArgs e)
        {
            if (rbQ3Agree.Checked)
            {
                sComplete.Answer3 = rbQ3Agree.Text;
            }
            else if (rbQ3Disagree.Checked)
            {
                sComplete.Answer3 = rbQ3Disagree.Text;
            }
            else if (rbQ3NA.Checked)
            {
                sComplete.Answer3 = rbQ3NA.Text;
            }
        }

        //statement that assigns the Q4 answer to the text of the checked radio button
        private void Answer4(object sender, EventArgs e)
        {
            if (rbQ4Agree.Checked)
            {
                sComplete.Answer4 = rbQ4Agree.Text;
            }
            else if (rbQ4Disagree.Checked)
            {
                sComplete.Answer4 = rbQ4Disagree.Text;
            }
            else if (rbQ4NA.Checked)
            {
                sComplete.Answer4 = rbQ4NA.Text;
            }
        }

        //statement that assigns the Q5 answer to the text of the checked radio button
        private void Answer5(object sender, EventArgs e)
        {
            if (rbQ5Agree.Checked)
            {
                sComplete.Answer5 = rbQ5Agree.Text;
            }
            else if (rbQ5Disagree.Checked)
            {
                sComplete.Answer5 = rbQ5Disagree.Text;
            }
            else if (rbQ5NA.Checked)
            {
                sComplete.Answer5 = rbQ5NA.Text;
            }
        }

        //submit event that makes sure every question has an answer and gives the completed survey an id
        //message box shows the survey name in title bar and all the questions and answer chosen for the survey
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (sComplete.Answer1 != "" && sComplete.Answer2 != "" && sComplete.Answer3 != "" && sComplete.Answer4 != "" && sComplete.Answer5 != "")
            {
                MessageBox.Show("Question 1: " + groupBox1.Text + "\n" + "Answer 1: " + sComplete.Answer1 + "\n\n" +
                                "Question 2: " + groupBox2.Text + "\n" + "Answer 2: " + sComplete.Answer2 + "\n\n" +
                                "Question 3: " + groupBox3.Text + "\n" + "Answer 3: " + sComplete.Answer3 + "\n\n" +
                                "Question 4: " + groupBox4.Text + "\n" + "Answer 4: " + sComplete.Answer4 + "\n\n" +
                                "Question 5: " + groupBox5.Text + "\n" + "Answer 5: " + sComplete.Answer5 + "\n\n", sComplete.CompletedSurveyName);

                sComplete.CompletedSurveyID = count++;
            }
        }
    }
}
