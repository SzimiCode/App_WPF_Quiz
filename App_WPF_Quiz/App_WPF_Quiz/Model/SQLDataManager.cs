using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Xml.Serialization;
using System.Data.Common;
using System.Windows.Controls.Primitives;
using System.Data.SQLite;
using System.Reflection.PortableExecutable;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Rozwiązywacz.Model;

namespace App_WPF_Quiz.Model
{
    public class SQLDataManager
    {
        List<Quiz> quizzes;
        int currentQuizIndex;

        public SQLDataManager()
        {
            quizzes = new List<Quiz>();
            currentQuizIndex = 0;

        }

        public void addQuiz(Quiz quiz)
        {
            quizzes.Add(quiz);
        }

        public Quiz getCurrentQuiz()
        {
            return quizzes[currentQuizIndex];
        }

        public void nextQuiz()
        {
            currentQuizIndex++;
            if (currentQuizIndex >= quizzes.Count)
            {
                currentQuizIndex = 0;
            }
        }

        public void previousQuiz()
        {
            currentQuizIndex--;
            if (currentQuizIndex < 0)
            {
                currentQuizIndex = quizzes.Count - 1;
            }
        }
        public void reset()
        {
            currentQuizIndex = 0;
        }






        private string connectionString = "Server=localhost;Database=QUIZY;User Id=root;Password=szymek03"; // Replace with your actual connection string

        public List<Quiz> GetQuizQuestions()
        {
            var questions = new List<Question>();

            using (var connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT question, answers, correct_answers FROM quizzes";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var questionText = reader.GetString("question");
                            var answersArray = JsonConvert.DeserializeObject<string[]>(reader.GetString("answers"));
                            var correctAnswersArray = JsonConvert.DeserializeObject<int[]>(reader.GetString("correct_answers"));

                            var answers = new Answers(answersArray, correctAnswersArray);
                            var question = new Question(questionText, answers);
                            questions.Add(question);
                        }
                    }
                }
            }

            var quiz = new Quiz(questions.ToArray());
            return new List<Quiz> { quiz };
        }


    }
}
}
