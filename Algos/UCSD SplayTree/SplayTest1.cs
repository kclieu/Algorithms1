using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algos.UCSD_SplayTree
{
    class SplayTest1
    {
        public static void MainSplayTest1()
        {
            string dir = @"C:\Users\Ken\workspace\BasicDataStructures\AssignmentStarterFiles\Starters-PA4\Starters PA4\set_range_sum\tests\";
            string answerfile = dir + @"36.a";
            string myAnswerFile = dir +"36 MyAnswer";

            System.IO.StreamReader fileAnswer = new System.IO.StreamReader(answerfile);

            System.IO.StreamReader myfileAnswer = new System.IO.StreamReader(myAnswerFile);


            int currentQuestion = 0;
            int numberOfQuery = 0;
            int firstQuestionFailed = 0;

            string myAnswerline = myfileAnswer.ReadLine();
            string answerLine = fileAnswer.ReadLine();
            while(answerLine != null &&  myAnswerline  != null )
            {
                currentQuestion++;

                if (answerLine.Equals("Found") || answerLine.Equals("Not found"))
                {
                    numberOfQuery++;
                }

                if (answerLine != myAnswerline)
                {
                    break;
                }

                myAnswerline = myfileAnswer.ReadLine();
                answerLine = fileAnswer.ReadLine();
            }

            string questionFile = dir + @"36";
            System.IO.StreamReader questions = new System.IO.StreamReader(questionFile);
            int questionCount = 0;
            string question = string.Empty;
            while (questionCount != currentQuestion)
            {
                question = questions.ReadLine();

                if(question.StartsWith("s") || question.StartsWith("?"))
                {
                    questionCount++;
                }
               
            }



            Console.WriteLine("Current Question " + currentQuestion);
            Console.WriteLine("Number of Query " + numberOfQuery);

            Console.WriteLine("Question Failed " + question);
            Console.WriteLine("Solution Answer: " + answerLine);
            Console.WriteLine("My Answer: " + myAnswerline);
            //

            Console.Read();


        }
    }
}
