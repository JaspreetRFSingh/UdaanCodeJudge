using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

#nullable disable

namespace WebApplication2.Models
{
    public partial class Quiz
    {
        public Quiz()
        {
            QuizQuestions = new HashSet<QuizQuestion>();
        }

        public int QuizId { get; set; }
        public string DifficultyLevel { get; set; }
        public int NumOfQuestions { get; set; }

        [JsonIgnore]
        public virtual ICollection<QuizQuestion> QuizQuestions { get; set; }
    }
}
