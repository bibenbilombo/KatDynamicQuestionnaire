using KataQuestionnaireDynamic.Data;
using KataQuestionnaireDynamic.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;

namespace KataQuestionnaireDynamic.Controllers
{
    public class QuestionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        private readonly DataDbContext _dataDbContext;

        public QuestionController(DataDbContext dataDbContext)
        {
            _dataDbContext = dataDbContext;
        }

        public IActionResult AfficherQuestions(int questionnaireId)
        {
            FormularModel questionnaire = _dataDbContext.Questionnaires
                .Include(q => q.Questions)
                .ThenInclude(q => q.Options)
                .FirstOrDefault(q => q.Id == questionnaireId);

            if (questionnaire == null)
            {
                return NotFound();
            }

            return View(questionnaire.Questions);
        }
    }
}
