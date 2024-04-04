using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoManejoErrores
{
    public class CalculationException : Exception
    {
        private const string DefaultMessage = "An error occurred during calculation. " +
            "Ensure that the operator is supported " +
            "and that the values are within the valid ranges for the requested operation.";

        /// <summary>
        /// Comentario que aparece cuando estas encima del constructor
        /// </summary>
        public CalculationException() : base(DefaultMessage) { }

        public CalculationException(string message) : base(message) { }

        public CalculationException(Exception innerException) :
            base(DefaultMessage, innerException)
        { }

        public CalculationException(string message, Exception innerException) :
            base(message, innerException)
        { }
    }
}
