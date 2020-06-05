using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZenithPensionsQuestionier.Models
{
    public class AnswersTable
    {
        public AnswersTable()
        {
            RealDateTimeSubmitted = DateTime.Now;
        }

        public long Id { get; set; }

        public string Answer { get; set; }

        public long QuestionId { get; set; }

        public string DateSubmitted { get; set; }

        public DateTime RealDateTimeSubmitted { get; set; }
    }
}
