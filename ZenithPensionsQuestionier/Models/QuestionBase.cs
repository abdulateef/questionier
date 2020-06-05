using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZenithPensionsQuestionier.Models
{
    public class QuestionBase
    {
        public long Id { get; set; }

        public string Text { get; set; }

        public string Type { get; set; }
    }
}
