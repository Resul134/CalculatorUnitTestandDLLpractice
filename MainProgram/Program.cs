using System;
using System.Collections;
using MathTool;


namespace MainProgram
{
    public class Program
    {

        static string[] operations = { "+", "-", "*", "/", "^", "%" };

        static void Main(string[] args)
        {
            // Using a dll referrence Mathtool made by Mads Eiby, reference name calc
            Calculator calc = new Calculator();       
            double result = 0;
            double firstNumber = SetNumber("Type you first number : ");
            double secondNumber = SetNumber("Type you second number: ");

            string stringOperation =
                SetOperation(
                    "Enter the operation + (addition), - (soustraction), * (multiplication), / (division) : ");

            switch (stringOperation)
            {
                case "+":
                case "addition":
                    result = calc.Add(firstNumber , secondNumber);
                    break;
                case "-":
                case "soustraction":
                    result = calc.Substract(firstNumber, secondNumber);
                    break;
                case "*":
                case "multiplication":
                    result = calc.Multipli(firstNumber , secondNumber);
                    break;
                case "/":
                case "division":
                    result = calc.Division(firstNumber , secondNumber);
                    break;
                
            }
           

            Console.WriteLine("Result of {0} {1} {2} = {3}", firstNumber, stringOperation, secondNumber, result);
            Console.ReadKey();
        }








        private static bool IsValidOperation(string input)
        {
            return ((IList) operations).Contains(input);
        }


        private static string SetOperation(string outputText)
        {
            Console.Write(outputText);
            string tempInput = Console.ReadLine();
            while (!IsValidOperation(tempInput))
            {
                Console.WriteLine("Incorrect input !");
                Console.Write(outputText);
                tempInput = Console.ReadLine();
            }
            return tempInput;
        }

        private static double SetNumber(string outputText)
        {
            double parse;
            Console.Write(outputText);
            string tempInput = Console.ReadLine();
            while (!double.TryParse(tempInput, out parse))
            {
                Console.WriteLine("Incorrect input !");
                Console.Write(outputText);
                tempInput = Console.ReadLine();
            }
            return double.Parse(tempInput);
        }



    }
}