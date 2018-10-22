using System;

namespace Questions
{
    public class Question3
    {
        public const string Title = "Refactoring and Coding Errors (15 min)"; 

        public const string Instruction = "Fix the following code and create a Unit Test to illustrate that it works";

        public const string Hint = "Use the output from the function in Question 1 as the source to the function you must write; do not simply copy and edit the function in Question 1";
        
        public static void Execute(int purchasePrice, int interestRate, int loanTermInYears, int downPayment)
        {
            //used object initializer and used implicity  typed local variable (var)
            var calculator = new Calculator
            {
                PurchasePrice = double.Parse(purchasePrice.ToString()),
                InterestRate = double.Parse(interestRate.ToString()),
                LoanTermYears = loanTermInYears,
                DownPayment = double.Parse(downPayment.ToString())
            };

            DisplayLoanInformation(calculator);
        }

        private static void DisplayLoanInformation(Calculator calculator)
        {
            Console.WriteLine("Purchase Price: {0:C}", calculator.LoanAmount);
            Console.WriteLine("Down Payment: {0:C}", calculator.DownPayment);
            Console.WriteLine("Loan Amount: {0:C}", calculator.PurchasePrice);
            Console.WriteLine("Annual Interest Rate: {0}%", calculator.InterestRate);
            Console.WriteLine("Term: {0} years ({1} months)", calculator.LoanTermYears, calculator.LoanTermMonths);
            Console.WriteLine("Monthly Payment: {0:C}", calculator.CalculatePayment());
            Console.WriteLine();
        }

        /// <summary>
        /// Class to calculate loan payments, changed this because I needed to make the class unit testable.
        /// </summary>
        public class Calculator
        {
            //initialised this to 12 
            private const int monthsPerYear = 12;
             
            /// <summary>
            /// The total purchase price of the item being paid for.
            /// </summary>
            public double PurchasePrice { get; set; }

            /// <summary>
            /// The total down payment towards the item being purchased.
            /// </summary>
            public double DownPayment { get; set; }

            /// <summary>
            /// Gets the total loan amount. This is the purchase price less
            /// any down payment.
            /// </summary>
            public double LoanAmount
            {
                get { return (PurchasePrice - DownPayment); }
            }

            /// <summary>
            /// The annual interest rate to be charged on the loan
            /// </summary>
            public double InterestRate { get; set; }

            /// <summary>
            /// The term of the loan in months. This is the number of months
            /// that payments will be made.
            /// </summary>
            public double LoanTermMonths { get; set; }

            /// <summary>
            /// The term of the loan in years. This is the number of years
            /// that payments will be made.
            /// </summary>
            public double LoanTermYears
            {
                get { return LoanTermMonths / monthsPerYear; }
                set { LoanTermMonths = (value * monthsPerYear); }
            }

            /// <summary>
            /// Calculates the monthy payment amount based on current
            /// settings.
            /// </summary>
            /// <returns>Returns the monthly payment amount</returns>
            public double CalculatePayment()
            {
                double payment = 0;
                //changed this to check the absolute value of any double precision number
                const double tolerance = 0;
                if (Math.Abs(InterestRate) > tolerance)
                {
                    double rate = ((double)(monthsPerYear / InterestRate) / 100);
                    double factor = (rate + (rate / (Math.Pow(rate + 1, LoanTermMonths) - 1)));
                    payment = (LoanAmount * factor);
                }
                else payment = (LoanAmount / LoanTermMonths);

                return Math.Round(payment, 10);
            }
        }
    }
}
