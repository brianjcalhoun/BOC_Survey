using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BOCClassLibrary
{
    public class SurveysList
    {
        public List<Surveys> surveys;

        public SurveysList()
        {
            surveys = new List<Surveys>();
        }

        public static SurveysList Create()
        {
            SurveysList s = (SurveysList)HttpContext.Current.Session["S"];
            if (s == null)
                HttpContext.Current.Session["S"] = new SurveysList();
            return (SurveysList)HttpContext.Current.Session["S"];

        }
    }
}
