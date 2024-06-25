using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_WPF_Quiz.Model
{
    public class Question
    {
        public String question { get; set; }
        public Answers answer { get; set; }
        public Question(String question, Answers answer)
        {
            this.question = question;
            this.answer = answer;


        }
    }
}
