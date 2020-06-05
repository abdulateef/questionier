using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ZenithPensionsQuestionier.Data;
using ZenithPensionsQuestionier.Helpers;
using ZenithPensionsQuestionier.Models;

namespace ZenithPensionsQuestionier.Controllers
{

   
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _contex;
        private readonly ILogger<HomeController> _logger;
        private readonly ISpecialHelper _specialHelper;

        public HomeController(ISpecialHelper specialHelper, ILogger<HomeController> logger, ApplicationDbContext contex)
        {
            _logger = logger;
            _contex = contex;
            _specialHelper = specialHelper;
        }


        public  IActionResult ThankYouPage()
        {
            

            return View();
        }

        public async Task<IActionResult> Index()
        {
            var ques = await _contex.Questions.ToListAsync();
            return View(ques);
        }

        public async Task<IActionResult> GetTypeAResult()
        {
            var _ans = await _contex.QuestionAnswerCount
                .Where(x => x.Type == "A").ToListAsync();

            var list_result = new List<QuestionAnswerCountVm>();
            foreach (var ex in _ans)
            {
                var test = new QuestionAnswerCountVm();

                test.OptionA = ex.OptionA;
                test.OptionACount = ex.OptionACount;
                test.OptionACountperc = ((ex.OptionACount * 100) / 49).ToString() + "%";
                test.OptionB = ex.OptionB;
                test.OptionBCount = ex.OptionBCount;
                test.OptionBCountperc = ((ex.OptionBCount * 100) / 49).ToString() + "%";
                test.OptionC = ex.OptionC;
                test.OptionCCount = ex.OptionCCount;
                test.OptionCCountperc = ((ex.OptionCCount * 100) / 49).ToString() + "%";
                test.OptionD = ex.OptionD;
                test.OptionDCount = ex.OptionDCount;
                test.OptionDCountperc = ((ex.OptionDCount * 100) / 49).ToString() + "%";
                test.OptionE = ex.OptionE;
                test.OptionECount = ex.OptionECount;
                test.OptionECountperc = ((ex.OptionECount * 100) / 49).ToString() + "%";
                test.OptionF = ex.OptionF;
                test.OptionFCount = ex.OptionFCount;
                test.OptionFCountperc = ((ex.OptionFCount * 100) / 49).ToString() + "%";
                test.Type = ex.Type;
                test.Text = ex.Text;
                list_result.Add(test);
            }

            return View(list_result);
        }

        public async Task<IActionResult> GetTypeBResult()
        {
            var _ans = await _contex.QuestionAnswerCount
                .Where(x => x.Type == "B").ToListAsync();

            var list_result = new List<QuestionAnswerCountVm>();
            foreach (var ex in _ans)
            {
                var test = new QuestionAnswerCountVm();

                test.OptionA = ex.OptionA;
               
                test.Type = ex.Type;
                test.Text = ex.Text;
                list_result.Add(test);
            }

            return View(list_result);
        }


        public async Task<IActionResult> GetTypeCResult()
        {
            var _ans = await _contex.QuestionAnswerCount
                .Where(x => x.Type == "C").ToListAsync();

            var list_result = new List<QuestionAnswerCountVm>();
            foreach (var ex in _ans)
            {
                var test = new QuestionAnswerCountVm();

                test.OptionA = ex.OptionA;
                test.OptionACount = ex.OptionACount;
                test.OptionACountperc = ((ex.OptionACount * 100) / 49).ToString() + "%";
                test.OptionB = ex.OptionB;
                test.OptionBCount = ex.OptionBCount;
                test.OptionBCountperc = ((ex.OptionBCount * 100) / 49).ToString() + "%";
                test.OptionC = ex.OptionC;
                test.OptionCCount = ex.OptionCCount;
                test.OptionCCountperc = ((ex.OptionCCount * 100) / 49).ToString() + "%";
                test.OptionD = ex.OptionD;
                test.OptionDCount = ex.OptionDCount;
                test.OptionDCountperc = ((ex.OptionDCount * 100) / 49).ToString() + "%";
              
                test.Type = ex.Type;
                test.Text = ex.Text;
                list_result.Add(test);
            }

            return View(list_result);
        }


        public async Task<IActionResult> GetTypeDResult()
        {
            var _ans = await _contex.QuestionAnswerCount
                .Where(x => x.Type == "D").ToListAsync();

            var list_result = new List<QuestionAnswerCountVm>();
            foreach (var ex in _ans)
            {
                var test = new QuestionAnswerCountVm();

                test.OptionA = ex.OptionA;
                test.OptionACount = ex.OptionACount;
                test.OptionACountperc = ((ex.OptionACount * 100) / 49).ToString() + "%";
                test.OptionB = ex.OptionB;
                test.OptionBCount = ex.OptionBCount;
                test.OptionBCountperc = ((ex.OptionBCount * 100) / 49).ToString() + "%";
               

                test.Type = ex.Type;
                test.Text = ex.Text;
                list_result.Add(test);
            }

            return View(list_result);
        }



        public async Task<IActionResult> GetTypeEResult()
        {
            var _ans = await _contex.QuestionAnswerCount
                .Where(x => x.Type == "E").ToListAsync();

            var list_result = new List<QuestionAnswerCountVm>();
            foreach (var ex in _ans)
            {
                var test = new QuestionAnswerCountVm();

                test.OptionA = ex.OptionA;
                test.OptionACount = ex.OptionACount;
                test.OptionACountperc = ((ex.OptionACount * 100) / 49).ToString() + "%";
                test.OptionB = ex.OptionB;
                test.OptionBCount = ex.OptionBCount;
                test.OptionBCountperc = ((ex.OptionBCount * 100) / 49).ToString() + "%";
                test.OptionC = ex.OptionC;
                test.OptionCCount = ex.OptionCCount;
                test.OptionCCountperc = ((ex.OptionCCount * 100) / 49).ToString() + "%";
                test.OptionD = ex.OptionD;
                test.OptionDCount = ex.OptionDCount;
                test.OptionDCountperc = ((ex.OptionDCount * 100) / 49).ToString() + "%";
                test.OptionE = ex.OptionE;
                test.OptionECount = ex.OptionECount;
                test.OptionECountperc = ((ex.OptionECount * 100) / 49).ToString() + "%";
                test.OptionF = ex.OptionF;
                test.OptionFCount = ex.OptionFCount;
                test.OptionFCountperc = ((ex.OptionFCount * 100) / 49).ToString() + "%";
                test.OptionG = ex.OptionG;
                test.OptionGCount = ex.OptionGCount;
                test.OptionGCountperc = ((ex.OptionGCount * 100) / 49).ToString() + "%";
                test.Type = ex.Type;
                test.Text = ex.Text;
                list_result.Add(test);
            }

            return View(list_result);
        }


        [HttpPost]
        public async Task<IActionResult> Index(IFormCollection collection)
        {
            var collectedAnswers = new List<AnswersTable>();
            var collectedResult = collection.Take(collection.Count() - 1 );

            foreach (var item in collectedResult)
            {
                var ans = new AnswersTable();

                ans.Answer = item.Value;
                ans.QuestionId = Convert.ToInt32(item.Key);
                ans.DateSubmitted = DateTime.Now.ToShortDateString();

                collectedAnswers.Add(ans);

                await _specialHelper.QuestionTypeAccess(ans.QuestionId,ans.Answer);
                

            
            }

            await _contex.Answers.AddRangeAsync(collectedAnswers);
            await _contex.SaveChangesAsync();

            return RedirectToAction("ThankYouPage");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
