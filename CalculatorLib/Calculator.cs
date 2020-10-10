﻿using System;
using System.Collections.Generic;

namespace CalculatorLib
{
    public class Calculator
    {
        public void Main()
        {
            double FirstVariable = 0;
            double SecondVariable = 0;
            string Option = "sEcReT_cOdE_fOr_An_ErRoR";
            List<string> NotForbiddenOptions = new List<string>() { "a", "s", "m", "d"};
            bool IsOptionOK = false;

            Console.WriteLine("Type a number, and then press Enter");
            FirstVariable = ReadVariable();

            Console.WriteLine("Type another number, and then press Enter");
            SecondVariable = ReadVariable();

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");
            Option = ReadOption();

            CheckOption(Option);

            foreach (string datstring in NotForbiddenOptions)
            {
                if(datstring == Option)
                {
                    IsOptionOK = true;
                }
            }

            if (IsOptionOK == false)
            {
                Console.WriteLine("The option of your chose isn`t available, press any key to close the app");
                Console.ReadKey();
                return;
            }

            Console.Write($"Your result: {FirstVariable} processed with {SecondVariable} = ");

            switch (Option)
            {
                case "a":
                    Console.WriteLine(AddVariables(FirstVariable, SecondVariable));
                    break;
                case "s":
                    Console.WriteLine(SubtractVariables(FirstVariable, SecondVariable));
                    break;
                case "m":
                    Console.WriteLine(MultiplyVariables(FirstVariable, SecondVariable));
                    break;
                case "d":
                    Console.WriteLine(DivideVariables(FirstVariable, SecondVariable));
                    break;
            }

            Console.Write("Press any key to close the Calculator console app...");
            Console.ReadKey();
        }

        public void CheckOption(string CurrentOption)
        {
            if (CurrentOption == "sEcReT_cOdE_fOr_An_ErRoR")
            {
                Console.WriteLine("WHAT THE HELL?!");
                Console.WriteLine(CurrentOption);
                Console.WriteLine("\tpress any key to restart this application");
                Console.ReadKey();
                return;
            }
        }

        public string ReadOption()
        {
            return Console.ReadLine();
        }

        public double ReadVariable()
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        public double AddVariables(double variable1, double variable2)
        {
            return variable1 + variable2;
        }
        public double SubtractVariables(double variable1, double variable2)
        {
            return variable1 - variable2;
        }
        public double DivideVariables(double variable1, double variable2)
        {
            return variable1 / variable2;
        }
        public double MultiplyVariables(double variable1, double variable2)
        {
            return variable1 * variable2;
        }
    }
}
