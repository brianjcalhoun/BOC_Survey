using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BOCClassLibrary
{
    public class QuestionsList
    {
        public List<Questions> questions;

        public QuestionsList()
        {
            questions = new List<Questions>();
        }

        public static QuestionsList CreateList()
        {
            QuestionsList q = (QuestionsList)HttpContext.Current.Session["Q"];
            if (q == null)
                HttpContext.Current.Session["Q"] = new QuestionsList();
            return (QuestionsList)HttpContext.Current.Session["Q"];

        }
    }
}
