using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZenithPensionsQuestionier.Models
{
    public class Question:QuestionBase
    {
        public string Instruction { get; set; }
        public string OptionA { get; set; }

        public string OptionB { get; set; }

        public string OptionC { get; set; }

        public string OptionD { get; set; }

        public string OptionE { get; set; }

        public string OptionF { get; set; }

        public string OptionG { get; set; }

        public string OptionH { get; set; }

        public string OptionI { get; set; }

        public string OptionJ { get; set; }
    }
}
