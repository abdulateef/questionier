using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZenithPensionsQuestionier.Models
{
    public class ViewModelToDisplay
    {
        public string question { get; set; }
        public string optionA { get; set; }
        public string optionB { get; set; }

        public string optionC { get; set; }
        public string optionD { get; set; }
        public string optionE { get; set; }
        public string optionF { get; set; }
        public string optionG { get; set; }

        public string answer { get; set; }
        public string Type { get; set; }

        public long QuestionId { get; set; }
    }
}
