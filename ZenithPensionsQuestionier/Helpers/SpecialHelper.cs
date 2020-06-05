using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ZenithPensionsQuestionier.Data;
using ZenithPensionsQuestionier.Helpers;
using ZenithPensionsQuestionier.Models;

namespace ZenithPensionsQuestionier
{
    public class SpecialHelper: ISpecialHelper

    {
        private readonly ApplicationDbContext _contex;
        public SpecialHelper(ApplicationDbContext contex)
        {
            _contex = contex;
        }

        public async Task QuestionTypeAccess(long QuestionId, string Answer)
        {

            var getQ = _contex.Questions.FirstOrDefault(x => x.Id == QuestionId);



            var getQC = _contex.QuestionAnswerCount.FirstOrDefault(x => x.QuestionId == QuestionId);
            //get the question type
            switch (getQ.Type)
            {
                case "A":

                    #region
                    if (getQC == null)
                    {
                        var countAn = new QuestionAnswerCount();
                        countAn.QuestionId = getQ.Id;
                        countAn.Text = getQ.Text;
                        countAn.Type = getQ.Type;
                        countAn.OptionA = getQ.OptionA;
                        countAn.OptionB = getQ.OptionB;
                        countAn.OptionC = getQ.OptionC;
                        countAn.OptionD = getQ.OptionD;
                        countAn.OptionE = getQ.OptionE;
                        countAn.OptionF = getQ.OptionF;
                        countAn.OptionG = getQ.OptionG;
                        
                        countAn.ResultDateTimeInString = DateTime.Now.ToShortDateString();

                        if (getQ.OptionA.Trim() == Answer.Trim())
                        {
                            countAn.OptionACount = countAn.OptionACount + 1;
                        }

                        if (getQ.OptionB.Trim() == Answer.Trim())
                        {
                            countAn.OptionBCount = countAn.OptionBCount + 1;
                        }

                        if (getQ.OptionC.Trim() == Answer.Trim())
                        {
                            countAn.OptionCCount = countAn.OptionCCount + 1;
                        }


                        if (getQ.OptionD.Trim() == Answer.Trim())
                        {
                            countAn.OptionDCount = countAn.OptionDCount + 1;
                        }


                        if (getQ.OptionE.Trim() == Answer.Trim())
                        {
                            countAn.OptionECount = countAn.OptionECount + 1;
                        }


                        if (getQ.OptionF.Trim() == Answer.Trim())
                        {
                            countAn.OptionFCount = countAn.OptionFCount + 1;
                        }



                        await _contex.AddAsync(countAn);
                        await _contex.SaveChangesAsync();
                    }

                    if (getQC != null)
                    {


                        if (getQC.OptionA.Trim() == Answer.Trim())
                        {
                            getQC.OptionACount = getQC.OptionACount + 1;
                        }

                        if (getQ.OptionB.Trim() == Answer.Trim())
                        {
                            getQC.OptionBCount = getQC.OptionBCount + 1;
                        }

                        if (getQ.OptionC.Trim() == Answer.Trim())
                        {
                            getQC.OptionCCount = getQC.OptionCCount + 1;
                        }


                        if (getQ.OptionD.Trim() == Answer.Trim())
                        {
                            getQC.OptionDCount = getQC.OptionDCount + 1;
                        }


                        if (getQ.OptionE.Trim() == Answer.Trim())
                        {
                            getQC.OptionECount = getQC.OptionECount + 1;
                        }


                        if (getQ.OptionF.Trim() == Answer.Trim())
                        {
                            getQC.OptionFCount = getQC.OptionFCount + 1;
                        }


                        await _contex.SaveChangesAsync();
                    }
                    #endregion
                    break;
                case "B":

                    #region

                    var countBn = new QuestionAnswerCount();
                    countBn.QuestionId = getQ.Id;
                    countBn.Text = getQ.Text;
                    countBn.Type = getQ.Type;

                    countBn.ResultDateTimeInString = DateTime.Now.ToShortDateString();
                    countBn.OptionA = Answer;


                    await _contex.AddAsync(countBn);
                    await _contex.SaveChangesAsync();

                    #endregion
                    break;
                case "C":

                    #region
                    if (getQC == null)
                    {
                        var countCn = new QuestionAnswerCount();
                        countCn.QuestionId = getQ.Id;
                        countCn.Text = getQ.Text;
                        countCn.Type = getQ.Type;
                        countCn.OptionA = getQ.OptionA;
                        countCn.OptionB = getQ.OptionB;
                        countCn.OptionC = getQ.OptionC;
                        countCn.OptionD = getQ.OptionD;
                        countCn.OptionE = getQ.OptionE;
                        countCn.OptionF = getQ.OptionF;
                        countCn.OptionG = getQ.OptionG;
                       
                        countCn.ResultDateTimeInString = DateTime.Now.ToShortDateString();

                        if (getQ.OptionA.Trim() == Answer.Trim())
                        {
                            countCn.OptionACount = countCn.OptionACount + 1;
                        }

                        if (getQ.OptionB.Trim() == Answer.Trim())
                        {
                            countCn.OptionBCount = countCn.OptionBCount + 1;
                        }

                        if (getQ.OptionC.Trim() == Answer.Trim())
                        {
                            countCn.OptionCCount = countCn.OptionCCount + 1;
                        }


                        if (getQ.OptionD.Trim() == Answer.Trim())
                        {
                            countCn.OptionDCount = countCn.OptionDCount + 1;
                        }



                        await _contex.AddAsync(countCn);
                        await _contex.SaveChangesAsync();
                    }

                    if (getQC != null)
                    {


                        if (getQC.OptionA.Trim() == Answer.Trim())
                        {
                            getQC.OptionACount = getQC.OptionACount + 1;
                        }

                        if (getQ.OptionB.Trim() == Answer.Trim())
                        {
                            getQC.OptionBCount = getQC.OptionBCount + 1;
                        }

                        if (getQ.OptionC.Trim() == Answer.Trim())
                        {
                            getQC.OptionCCount = getQC.OptionCCount + 1;
                        }


                        if (getQ.OptionD.Trim() == Answer.Trim())
                        {
                            getQC.OptionDCount = getQC.OptionDCount + 1;
                        }





                        await _contex.SaveChangesAsync();
                    }
                    #endregion

                    break;
                case "D":

                    #region
                    if (getQC == null)
                    {
                        var countCn = new QuestionAnswerCount();
                        countCn.QuestionId = getQ.Id;
                        countCn.Text = getQ.Text;
                        countCn.Type = getQ.Type;
                        countCn.OptionA = getQ.OptionA;
                        countCn.OptionB = getQ.OptionB;
                        countCn.OptionC = getQ.OptionC;
                        countCn.OptionD = getQ.OptionD;
                        countCn.OptionE = getQ.OptionE;
                        countCn.OptionF = getQ.OptionF;
                        countCn.OptionG = getQ.OptionG;
                        countCn.OptionH = getQ.OptionH;
                        countCn.OptionI = getQ.OptionI;
                        countCn.ResultDateTimeInString = DateTime.Now.ToShortDateString();

                        if (getQ.OptionA.Trim() == Answer.Trim())
                        {
                            countCn.OptionACount = countCn.OptionACount + 1;
                        }

                        if (getQ.OptionB.Trim() == Answer.Trim())
                        {
                            countCn.OptionBCount = countCn.OptionBCount + 1;
                        }




                        await _contex.AddAsync(countCn);
                        await _contex.SaveChangesAsync();
                    }

                    if (getQC != null)
                    {


                        if (getQC.OptionA.Trim() == Answer.Trim())
                        {
                            getQC.OptionACount = getQC.OptionACount + 1;
                        }

                        if (getQ.OptionB.Trim() == Answer.Trim())
                        {
                            getQC.OptionBCount = getQC.OptionBCount + 1;
                        }







                        await _contex.SaveChangesAsync();
                    }
                    #endregion
                    break;
                case "E":
                    #region
                    if (getQC == null)
                    {
                        var countAn = new QuestionAnswerCount();
                        countAn.QuestionId = getQ.Id;
                        countAn.Text = getQ.Text;
                        countAn.Type = getQ.Type;
                        countAn.OptionA = getQ.OptionA;
                        countAn.OptionB = getQ.OptionB;
                        countAn.OptionC = getQ.OptionC;
                        countAn.OptionD = getQ.OptionD;
                        countAn.OptionE = getQ.OptionE;
                        countAn.OptionF = getQ.OptionF;
                        countAn.OptionG = getQ.OptionG;
                        countAn.OptionH = getQ.OptionH;
                        countAn.OptionI = getQ.OptionI ;
                        countAn.ResultDateTimeInString = DateTime.Now.ToShortDateString();

                        if (getQ.OptionA.Trim() == Answer.Trim())
                        {
                            countAn.OptionACount = countAn.OptionACount + 1;
                        }

                        if (getQ.OptionB.Trim() == Answer.Trim())
                        {
                            countAn.OptionBCount = countAn.OptionBCount + 1;
                        }

                        if (getQ.OptionC.Trim() == Answer.Trim())
                        {
                            countAn.OptionCCount = countAn.OptionCCount + 1;
                        }


                        if (getQ.OptionD.Trim() == Answer.Trim())
                        {
                            countAn.OptionDCount = countAn.OptionDCount + 1;
                        }


                        if (getQ.OptionE.Trim() == Answer.Trim())
                        {
                            countAn.OptionECount = countAn.OptionECount + 1;
                        }


                        if (getQ.OptionF.Trim() == Answer.Trim())
                        {
                            countAn.OptionFCount = countAn.OptionFCount + 1;
                        }

                        if (getQ.OptionG.Trim() == Answer.Trim())
                        {
                            countAn.OptionGCount = countAn.OptionGCount + 1;
                        }



                        await _contex.AddAsync(countAn);
                        await _contex.SaveChangesAsync();
                    }

                    if (getQC != null)
                    {


                        if (getQC.OptionA.Trim() == Answer.Trim())
                        {
                            getQC.OptionACount = getQC.OptionACount + 1;
                        }

                        if (getQ.OptionB.Trim() == Answer.Trim())
                        {
                            getQC.OptionBCount = getQC.OptionBCount + 1;
                        }

                        if (getQ.OptionC.Trim() == Answer.Trim())
                        {
                            getQC.OptionCCount = getQC.OptionCCount + 1;
                        }


                        if (getQ.OptionD.Trim() == Answer.Trim())
                        {
                            getQC.OptionDCount = getQC.OptionDCount + 1;
                        }


                        if (getQ.OptionE.Trim() == Answer.Trim())
                        {
                            getQC.OptionECount = getQC.OptionECount + 1;
                        }


                        if (getQ.OptionF.Trim() == Answer.Trim())
                        {
                            getQC.OptionFCount = getQC.OptionFCount + 1;
                        }


                        if (getQ.OptionG.Trim() == Answer.Trim())
                        {
                            getQC.OptionGCount = getQC.OptionGCount + 1;
                        }


                        await _contex.SaveChangesAsync();
                    }
                    #endregion
                    break;

                default:
                    break;
            }


        }
    }
}
