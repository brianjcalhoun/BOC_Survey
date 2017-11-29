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
    public partial class SelectSurvey : Form
    {
        public List<Surveys> newSurveyList = new List<Surveys>();

        //takes data from survey maintenance form
        //foreach loop to to add surveys to the list 
        public SelectSurvey(List<Surveys> newSurveys)
        {
            InitializeComponent();

            lstSurveys.Items.Clear();
            foreach (Surveys s in newSurveys)
            {
                lstSurveys.Items.Add(s.GetDisplayText());
                newSurveyList.Add(s);
            }
        }

        public SelectSurvey()
        {
            InitializeComponent();
        }

        //Takes survey from selected index and survey questions and adds them to a survey form
        private void btnTakeSurvey_Click(object sender, EventArgs e)
        {
            int i = lstSurveys.SelectedIndex;

            SurveyForm newSurveyForm = new SurveyForm(newSurveyList[i]);
            this.Hide();
            newSurveyForm.ShowDialog();
        }

    }
}
