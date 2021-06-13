using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public class QuizQuestionService : IQuizQuestionService
    {
        
        private readonly UdaanDemoDBContext _context;

        public QuizQuestionService(UdaanDemoDBContext context)
        {
            _context = context;
        }
        public bool CreateQuizQuestionRecord(int quizId, int questionId)
        {
            try
            {
                var quizQuestion = new QuizQuestion
                {
                    QuestionId = questionId,
                    QuizId = quizId
                };
                _context.QuizQuestions.Add(quizQuestion);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
