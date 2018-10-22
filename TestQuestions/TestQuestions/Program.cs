using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuestions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Question 1:");
            Questions.Question1.CreateChessBoard();

            Console.WriteLine("Question 2:");
            Questions.Question2.ReverseChessBoard();

            Console.WriteLine("Question 3:");
            Questions.Question3.Execute(0, 0, 0, 0);
            //just an extra check with different values
            Questions.Question3.Execute(6000, 27, 1, 600);

            Console.WriteLine("Question 4:");
            Questions.Question4.Login();
            Questions.Question4.Post();
            Questions.Question4.Get();
            Questions.Question4.Delete();
            Questions.Question4.List();

            Console.ReadLine();
        }
    }
}
