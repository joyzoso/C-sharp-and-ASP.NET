﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

    public class Calculator
    {
        static void Main(string[] args)
        {
            char firstChar = 'Q';
            bool keepRunning = true;

            do
            {
                Console.WriteLine();
                Console.Write("Would you like to Add, Subtract, Multiple, Divide, Quit: ");

                string input = Console.ReadLine();
                firstChar = input[0];

                //This is used in both the if statement and do-while loop
                keepRunning = !(firstChar == 'q' || firstChar == 'Q');

                double firstNumber = 0;
                double secondNumber = 0;

                if (keepRunning)
                {
                    Console.Write("First Number: ");
                    string firstNumberInput = Console.ReadLine();
                    firstNumber = double.Parse(firstNumberInput);

                    Console.Write("Second Number: ");
                    string secondNumberInput = Console.ReadLine();
                    secondNumber = double.Parse(secondNumberInput);
                }

                double result = 0;
                switch (firstChar)
                {
                    case 'a':
                    case 'A':
                        result = firstNumber + secondNumber;
                        break;
                    case 's':
                    case 'S':
                        result = firstNumber - secondNumber;
                        break;
                    case 'm':
                    case 'M':
                        result = firstNumber * secondNumber;
                        break;
                    case 'd':
                    case 'D':
                        result = firstNumber / secondNumber;
                        break;
                default:
                    result = -1;
                    break;
                }
            StringBuilder sb = new StringBuilder();
            sb.Append("Your result is ");
            sb.Append(result.ToString());
            Console.WriteLine(sb.ToString());

            } while (keepRunning);
        }
    }

