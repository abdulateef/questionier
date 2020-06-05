using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ZenithPensionsQuestionier.Helpers
{
    public interface ISpecialHelper
    {
        Task QuestionTypeAccess(long questionId, string answer);
    }
}
