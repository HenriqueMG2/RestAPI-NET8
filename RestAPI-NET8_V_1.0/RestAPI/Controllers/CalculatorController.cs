using Microsoft.AspNetCore.Mvc;
using CalculadoraLibrary.APILogic;
using RestAPI.Util;

namespace RestAPI.Controllers
{
    [Route("[controller]")]
    public class CalculatorController(ILogger<CalculatorController> logger) : Controller
    {
        private readonly ILogger<CalculatorController> _logger = logger;


        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Addition(string firstNumber, string secondNumber)
        {
            try
            {
                if (IsN'    umeric(firstNumber) && IsNumeric(secondNumber))
                {
                    Calculator calc = new();
                    decimal result = calc.Addition(ConvertToDecimal(firstNumber), ConvertToDecimal(secondNumber));
                    return Ok(result.ToString());
                }
                return BadRequest("Invalid Input");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }

        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult Subtraction(string firstNumber, string secondNumber)
        {
            try
            {
                if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
                {
                    Calculator calc = new();
                    decimal result = calc.Subtraction(ConvertToDecimal(firstNumber), ConvertToDecimal(secondNumber));
                    return Ok(result.ToString());
                }
                return BadRequest("Invalid Input");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }

        [HttpGet("multi/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplication(string firstNumber, string secondNumber)
        {
            try
            {
                if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
                {
                    Calculator calc = new();
                    decimal result = calc.Multiplication(ConvertToDecimal(firstNumber), ConvertToDecimal(secondNumber));
                    return Ok(result.ToString());
                }
                return BadRequest("Invalid Input");
            }
            catch (Exception ex)
            {
                return BadRequest($"Error: {ex.Message}");
            }
        }

        [HttpGet("div/{firstNumber}/{secondNumber}")]
        public IActionResult Divisao(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                if (ConvertToDecimal(secondNumber) != 0)
                {
                    Calculator calc = new();
                    var result = calc.Division(ConvertToDecimal(firstNumber), ConvertToDecimal(secondNumber));
                    return Ok(result.ToString());
                }
                else
                {
                    return BadRequest("Impossivel dividir por zero");
                }
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("square/{firstNumber}")]
        public IActionResult SquareRoot(string firstNumber)
        {
            if (IsNumeric(firstNumber))
            {
                var value = ConvertToDecimal(firstNumber);

                if (value >= 0)
                {
                    Calculator calc = new();
                    var result = calc.SquareRoot(value);
                    return Ok(result.ToString());
                }
                else
                {
                    return BadRequest("Input must be a non-negative number");
                }
            }
            return BadRequest("Invalid Input");
        }

        [HttpGet("percentage/{firstNumber}/{secondNumber}")]
        public IActionResult Percentage(string firstNumber, string secondNumber)
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber))
            {
                Calculator calc = new();
                var result = calc.Percentage(ConvertToDecimal(firstNumber), ConvertToDecimal(secondNumber));
                return Ok(result.ToString());

            }
            return BadRequest("Invalid Input");
        }
    }
}

