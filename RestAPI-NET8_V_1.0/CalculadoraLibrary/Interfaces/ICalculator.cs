using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraLibrary.Interfaces
{
    public interface ICalculator
    {
        public decimal Addition(decimal firstNumber, decimal secondNumber);
        public decimal Subtraction(decimal firstNumber, decimal secondNumber);
        public decimal Multiplication(decimal firstNumber, decimal secondNumber);
        public decimal Division(decimal firstNumber, decimal secondNumber);
        public decimal Percentage(decimal porcentagem, decimal value);
        public decimal SquareRoot(decimal firstNumber);
    }
}