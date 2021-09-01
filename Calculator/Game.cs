﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    class Game
    {
        //Player wants to continue
        bool calculating = true;

        float Addition(float firstNumber, float secondNumber)
        {
            return firstNumber + secondNumber;
        }

        float Subtration(float firstNumber, float secondNumber)
        {
            return firstNumber - secondNumber;
        }

        float Multipication(float firstNumber, float secondNumber)
        {
            return firstNumber * secondNumber;
        }

        float Divison(float firstNumber, float secondNumber)
        {
            return firstNumber / secondNumber;
        }

        /// <summary>
        /// Function to get number values
        /// </summary>
        /// <param name="currentNumberEntry">Enter the word value</param>
        /// <returns></returns>
        float NumberInput(string currentNumberEntry)
        {
            bool invalidInput = true;
            while (invalidInput == true)
            {
                Console.WriteLine("Please enter the " + currentNumberEntry + " number here.");
                Console.Write(">");
                string input = Console.ReadLine();
                if (Single.TryParse(input, out float result))
                {
                    invalidInput = false;
                    Console.Clear();
                    return result;

                }

                else
                {
                    Console.WriteLine("Please input a valid number.");
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
                if (operation == "1" || operation.ToLower() == "addition")
                {
                    result = Addition(firstNumber, secondNumber);
                    invalidInput = false;
                    Console.Clear();
                    return result;
                }

                else if (operation == "2" || operation.ToLower() == "subtraction")
                {
                    result = Subtration(firstNumber, secondNumber);
                    invalidInput = false;
                    Console.Clear();
                    return result;
                }

                else if (operation == "3" || operation.ToLower() == "mulptipication")
                {
                    result = Multipication(firstNumber, secondNumber);
                    invalidInput = false;
                    Console.Clear();
                    return result;
                }

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
                    Console.ReadKey();
                    Console.Clear();
                }
            }
         return result;
        }

        void Calculator()
        {
            float firstNumber = NumberInput("first");
            float secondNumber = NumberInput("second");
            float result = Operator(firstNumber, secondNumber);
            Console.WriteLine(result);
            Console.ReadKey();
            Console.Clear();
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
                    if (operation == "1" || operation.ToLower() == "continue")
                    {
                        firstNumber = result;
                        secondNumber = NumberInput("second");
                        result = Operator(firstNumber, secondNumber);
                        Console.WriteLine(result);
                        Console.ReadKey();
                        Console.Clear();
                        invalidInput = false;
                    }

                    else if (operation == "2" || operation.ToLower() == "clear")
                    {
                        firstNumber = NumberInput("first");
                        secondNumber = NumberInput("second");
                        result = Operator(firstNumber, secondNumber);
                        Console.WriteLine(result);
                        Console.ReadKey();
                        Console.Clear();
                        invalidInput = false;
                    }

                    else if (operation == "3" || operation.ToLower() == "exit")
                    {
                        invalidInput = false;
                        calculating = false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
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
