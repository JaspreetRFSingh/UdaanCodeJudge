using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Services
{
    public interface IQuizQuestionService
    {
        public bool CreateQuizQuestionRecord(int quizId, int questionId);
    }
}
