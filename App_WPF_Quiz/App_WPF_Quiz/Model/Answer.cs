using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_WPF_Quiz.Model
{
    public class Answers
    {
        public String[] answers { get; set; }
        public int[] correctAnswer { get; set; }
        public Answers(String[] answers, int[] correctAnswer)
        {

            this.answers = answers;
            this.correctAnswer = correctAnswer;

        }
    }
}
