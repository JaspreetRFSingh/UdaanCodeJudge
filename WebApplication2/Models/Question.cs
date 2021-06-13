using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication2.Models
{
    public partial class Question
    {
        public Question()
        {
            QuizQuestions = new HashSet<QuizQuestion>();
        }

        public int QuestionId { get; set; }
        public string Question1 { get; set; }
        public string Answer { get; set; }

        public virtual ICollection<QuizQuestion> QuizQuestions { get; set; }
    }
}
