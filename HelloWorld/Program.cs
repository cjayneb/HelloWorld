﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string text1 = "cjay_neb";
            int number = 13;
            double number1 = 6.9;
            bool choice;

            var infinite = "pi";

            Console.WriteLine("Enter your height: ");
            string age = Console.ReadLine();
            int convertedNumber;
            choice = int.TryParse(age, out convertedNumber);
            Console.WriteLine(convertedNumber + "this is a change");
            Console.ReadLine();
            
        }
    }
}
