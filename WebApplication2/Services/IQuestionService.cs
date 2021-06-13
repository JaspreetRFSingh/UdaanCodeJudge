using System;
using System.Collections.Generic;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public interface IQuestionService
    {
        public List<Question> GetAllQuestions();
        public List<Question> GetQuestionByQuiz(int quizId);
        public bool AddQuestion(Question question);
    }
}
