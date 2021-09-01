using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Game
    {
        //Player wants to continue
        bool calculating = true;

        //Addition Function
        float Addition(float firstNumber, float secondNumber)
        {
            return firstNumber + secondNumber;
        }

        //Subtration Function
        float Subtration(float firstNumber, float secondNumber)
        {
            return firstNumber - secondNumber;
        }

        //Multiplication Function
        float Multipication(float firstNumber, float secondNumber)
        {
            return firstNumber * secondNumber;
        }

        //Division
        float Divison(float firstNumber, float secondNumber)
        {
            return firstNumber / secondNumber;
        }

        /// <summary>
        /// Function to get number values
        /// </summary>
        /// <param name="currentNumberEntry">Enter the number as a word</param>
        /// <returns></returns>
        float NumberInput(string currentNumberEntry)
        {
            bool invalidInput = true;
            while (invalidInput == true)
            {
                Console.WriteLine("Please enter the " + currentNumberEntry + " number here.");
                Console.Write(">");
                string input = Console.ReadLine();

                //Checking if entry was a valid number
                if (Single.TryParse(input, out float result))
                {
                    invalidInput = false;
                    Console.Clear();
                    return result;

                }

                else
                {
                    Console.WriteLine("Please input a valid number.");
                    Console.ReadKey(true);
                    Console.Clear();
                }
            }

        return 0;
        }

        //Choosing the Operator
        float Operator(float firstNumber, float secondNumber)
        {
            float result = 0.0f;
            bool invalidInput = true;
            while (invalidInput == true)
            {
                Console.WriteLine("Enter Operation");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtration");
                Console.WriteLine("3. Multipication");
                Console.WriteLine("4. Division");
                Console.Write(">");
                string operation = Console.ReadLine();

                //If Addition was chosen
                if (operation == "1" || operation.ToLower() == "addition")
                {
                    result = Addition(firstNumber, secondNumber);
                    invalidInput = false;
                    Console.Clear();
                    return result;
                }

                //If Subtration was Chosen
                else if (operation == "2" || operation.ToLower() == "subtraction")
                {
                    result = Subtration(firstNumber, secondNumber);
                    invalidInput = false;
                    Console.Clear();
                    return result;
                }

                //If Multiplication was Chosen
                else if (operation == "3" || operation.ToLower() == "multipication")
                {
                    result = Multipication(firstNumber, secondNumber);
                    invalidInput = false;
                    Console.Clear();
                    return result;
                }

                //If Division was Chosen
                else if (operation == "4" || operation.ToLower() == "divison")
                {
                    result = Divison(firstNumber, secondNumber);
                    invalidInput = false;
                    Console.Clear();
                    return result;
                }

                else
                {
                    Console.WriteLine("Please Input a Valid Paramater.");
                    Console.ReadKey(true);
                    Console.Clear();
                }
            }
         return result;
        }

        //Condeses the Calculation into a single function
        void Calculator()
        {
            //Does first calculation
            float firstNumber = NumberInput("first");
            float secondNumber = NumberInput("second");
            float result = Operator(firstNumber, secondNumber);
            Console.WriteLine(result);
            Console.ReadKey(true);
            Console.Clear();

            //Checks if User wants to Contiue, Clear, or Exit
            while (calculating == true)
            {
            bool invalidInput = true;
                while (invalidInput == true)
                {
                    //Continue with Result
                    Console.WriteLine("1. Continue");
                    //Clear and enter new Numbers
                    Console.WriteLine("2. Clear");
                    //Exit
                    Console.WriteLine("3. Exit");
                    Console.Write(">");
                    string operation = Console.ReadLine();
                    Console.Clear();

                    //If user wants to use previous value
                    if (operation == "1" || operation.ToLower() == "continue")
                    {
                        firstNumber = result;
                        secondNumber = NumberInput("second");
                        result = Operator(firstNumber, secondNumber);
                        Console.WriteLine(result);
                        Console.ReadKey(true);
                        Console.Clear();
                        invalidInput = false;
                    }

                    //User uses new values
                    else if (operation == "2" || operation.ToLower() == "clear")
                    {
                        firstNumber = NumberInput("first");
                        secondNumber = NumberInput("second");
                        result = Operator(firstNumber, secondNumber);
                        Console.WriteLine(result);
                        Console.ReadKey(true);
                        Console.Clear();
                        invalidInput = false;
                    }

                    //User Leaves
                    else if (operation == "3" || operation.ToLower() == "exit")
                    {
                        invalidInput = false;
                        calculating = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");\
                        Console.ReadKey(true);
                        Console.Clear();
                    }

                   
                }

            }
        }
        
        public void Run()
        {
            Calculator();
        }
    }
}
