using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOCClassLibrary
{
    public class Surveys
    {

        public Surveys()
        {
            SurveyQuestions = new List<Questions>();
        }


        public string Name { get; set; }

        public int SurveyID { get; set; }

        public List<Questions> SurveyQuestions { get; set; }

        public string GetDisplayText()
        {
            return Name;
        }
    }
}
