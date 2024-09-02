using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculadoraLibrary.Interfaces;

namespace CalculadoraLibrary.APILogic
{
    public class Calculator : ICalculator
    {

        public decimal Addition(decimal firstNumber, decimal secondNumber)
        {
            var add = firstNumber + secondNumber;
            return add;
        }

        public decimal Subtraction(decimal firstNumber, decimal secondNumber)
        {
            var subtraction = firstNumber - secondNumber;
            return subtraction;
        }

        public decimal Division(decimal firstNumber, decimal secondNumber)
        {
            var divisor = secondNumber;
            if (divisor != 0)
            {
                var div = firstNumber / divisor;
                return div;
            }
            else
            {
                return 0;
            }
        }

        public decimal Multiplication(decimal firstNumber, decimal secondNumber)
        {
            var multi = firstNumber - secondNumber;
            return multi;
        }

        public decimal Percentage(decimal percentage, decimal value)
        {
            decimal result = (percentage / 100) * value;
            return result;
        }

        public decimal SquareRoot(decimal firstNumber)
        {
            decimal result = (decimal)Math.Sqrt((double)firstNumber);
            return result;
        }

    }
}