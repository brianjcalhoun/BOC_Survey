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
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }

        //Opens the Survey Maintenance Form
        private void btnCreateSurvey_Click(object sender, EventArgs e)
        {
            SurveyMaintenance surveyMaintenance = new SurveyMaintenance();
            surveyMaintenance.ShowDialog();

           
        }

        //Opens the Question Maintenance Form
        private void btnCreateQuestions_Click(object sender, EventArgs e)
        {
            QuestionMaintenance questionMaintenance = new QuestionMaintenance();
            questionMaintenance.ShowDialog();
            
        }

        //Opens the Take Survey List
        private void btnTakeSurvey_Click(object sender, EventArgs e)
        {
            SelectSurvey surveyForm = new SelectSurvey();
            surveyForm.ShowDialog();
        }

        private void btnCreateSurvey_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("This functionality will be available in the future.", "Coming soon");
        }

        private void btnTakeSurvey_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("This functionality will be available in the future.", "Coming soon");
        }
    }
}
