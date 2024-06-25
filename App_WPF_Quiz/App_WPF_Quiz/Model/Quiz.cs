using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_WPF_Quiz.Model
{
    public class Quiz
    {
        public Question[] question { get; set; }

        public Quiz(Question[] question)
        {
            this.question = question;


        }





    }
}
