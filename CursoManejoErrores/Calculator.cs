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
            /*if (operation is null)
            {
                throw new ArgumentNullException(nameof(operation));
            }*/

            string nonNullOperation =
                operation ?? throw new ArgumentNullException(nameof(operation));

            // el ?? hace lo que hay a la derecha si lo de la izquierda es null

            if (operation == "/")
            {
                return Divide(number1, number2);
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(operation),
                    "The mathematical operator is not supported.");
            }
        }

        private int Divide(int number, int divisor) => number / divisor;
    }
}