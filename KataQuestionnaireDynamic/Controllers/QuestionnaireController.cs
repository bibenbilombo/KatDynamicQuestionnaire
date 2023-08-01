using KataQuestionnaireDynamic.Data;
using KataQuestionnaireDynamic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace KataQuestionnaireDynamic.Controllers
{
    public class QuestionnaireController : Controller
    {
        private readonly DataDbContext _dataDbContext;

        public QuestionnaireController(DataDbContext dataDbContext)
        {
            _dataDbContext = dataDbContext;
        }

        public IActionResult Index()
        {
            List<FormularModel> mesQuestionnaires = _dataDbContext.Questionnaires.ToList();
            return View(mesQuestionnaires);
        }

        //public IActionResult AfficherQuestions(int questionnaireId)
        //{
        //     FormularModel questionnaire = _dataDbContext.Questionnaires
        //    .Include(q => q.Questions)
        //    .FirstOrDefault(q => q.Id == questionnaireId);

        //    //List<QuestionModel> questions = (List<QuestionModel>)_dataDbContext.Questions.Where(q => q.Question.);
        //    return View(questionnaire.Questions);
        //}

        

        //public IActionResult AfficherQuestion(int questionnaireId)
        //{
        //    List<QuestionModel> questions = _dataDbContext.Questions.ToList();
        //    return View(questions);
        //}

        //[HttpPost]
        //public IActionResult Submit(List<string> answers)
        //{
        //    return View(answers);
        //}
    }
}
