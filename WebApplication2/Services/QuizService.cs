using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public class QuizService : IQuizService
    {
        private readonly UdaanDemoDBContext _context;

        public QuizService(UdaanDemoDBContext context)
        {
            _context = context;
        }

        public bool CreateQuiz(Quiz quiz)
        {
            try
            {
                _context.Quizzes.Add(quiz);
                if(quiz.NumOfQuestions > _context.Questions.ToList<Question>().Count)
                {
                    //Quiz cannot be created since we don't have enough questions in datastore
                    return false;
                }
                _context.SaveChanges();
                //var latestQuizId = _context.Quizzes.Last<Quiz>().QuizId;
                for(int q=0; q<quiz.NumOfQuestions; q++)
                {
                    CreateQuizQuestionRecord(quiz.QuizId, _context.Questions.ToList<Question>().ElementAt(q).QuestionId);
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }



        private bool CreateQuizQuestionRecord(int quizId, int questionId)
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
            catch (Exception e)
            {
                string ex = e.Message;
                return false;
            }
        }



        public List<Quiz> GetQuizzes()
        {
            throw new NotImplementedException();
        }
    }
}
