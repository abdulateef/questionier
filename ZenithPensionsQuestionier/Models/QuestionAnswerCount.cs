using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZenithPensionsQuestionier.Models
{
    public class QuestionAnswerCount
    {
        public QuestionAnswerCount()
        {
            ResultDateTime = DateTime.Now;
        }

        public long Id { get; set; }
        public  long QuestionId { get; set; }
        public string Text { get; set; }

        public string Type { get; set; }
       
        public string OptionA { get; set; }

        public int OptionACount { get; set; }

        public string OptionB { get; set; }

        public int OptionBCount { get; set; }

        public string OptionC { get; set; }

        public int OptionCCount { get; set; }

        public string OptionD { get; set; }

        public int OptionDCount { get; set; }

        public string OptionE { get; set; }

        public int OptionECount { get; set; }

        public string OptionF { get; set; }

        public int OptionFCount { get; set; }

        public string OptionG { get; set; }

        public int OptionGCount { get; set; }

        public string OptionH { get; set; }

        public int OptionHCount { get; set; }
        public string OptionI { get; set; }

        public int OptionICount { get; set; }

        public string OptionJ { get; set; }

        public int OptionJCount { get; set; }

        public DateTime ResultDateTime { get; set; }

        public string ResultDateTimeInString { get; set; }
    }



    public class QuestionAnswerCountVm
    {
       
        public long Id { get; set; }
        public long QuestionId { get; set; }
        public string Text { get; set; }

        public string Type { get; set; }

        public string OptionA { get; set; }

        public int OptionACount { get; set; }

        public string OptionACountperc { get; set; }

        public string OptionB { get; set; }

        public int OptionBCount { get; set; }

        public string OptionBCountperc { get; set; }

        public string OptionC { get; set; }

        public int OptionCCount { get; set; }

        public string OptionCCountperc { get; set; }

        public string OptionD { get; set; }

        public int OptionDCount { get; set; }

        public string OptionDCountperc { get; set; }

        public string OptionE { get; set; }

        public int OptionECount { get; set; }

        public string OptionECountperc { get; set; }

        public string OptionF { get; set; }

        public int OptionFCount { get; set; }

        public string OptionFCountperc { get; set; }

        public string OptionG { get; set; }

        public int OptionGCount { get; set; }

        public string OptionGCountperc { get; set; }

        public string OptionH { get; set; }

        public string OptionHCount { get; set; }

        public string OptionHCountperc { get; set; }
        public string OptionI { get; set; }

        public string OptionICount { get; set; }

        public string OptionJ { get; set; }

        public string OptionJCount { get; set; }

        public DateTime ResultDateTime { get; set; }

        public string ResultDateTimeInString { get; set; }
    }
}
