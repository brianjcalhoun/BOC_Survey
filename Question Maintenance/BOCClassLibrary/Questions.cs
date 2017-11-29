using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOCClassLibrary
{
    public class Questions
    {

        public Questions()
        {
        }

        public int QuestionID { get; set; }

        public string QuestionContent { get; set; }

        public string GetDisplayText()
        {
            return QuestionContent;
        }
    }

}
