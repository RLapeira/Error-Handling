using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoManejoErrores
{
    public class Calculator
    {
        public int Calculate(int number1, int number2, string operation)
        {
            string nonNullOperation =
                operation ?? throw new ArgumentNullException(nameof(operation));

            if (nonNullOperation == "/")
            {
                try
                {
                    return Divide(number1, number2);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("...logging...");
                    // Log.Error(ex);
                    // throw;
                    throw new CalculationException(ex);
                }
            }
            else
            {
                throw new CalculationOperationNotSupportedException(operation);
            }
        }

        private int Divide(int number, int divisor) => number / divisor;
    }
}