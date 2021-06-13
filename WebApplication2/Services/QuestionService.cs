using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public class QuestionService : IQuestionService
    {
        
        private readonly UdaanDemoDBContext _context;

        public QuestionService(UdaanDemoDBContext context)
        {
            _context = context;
        }

        public bool AddQuestion(Question question)
        {
            try
            {
                _context.Questions.Add(question);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<Question> GetAllQuestions()
        {
            return _context.Questions.ToList<Question>();
        }

        public List<Question> GetQuestionByQuiz(int quizId)
        {
            throw new NotImplementedException();
        }
        

    }
}
