using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Guia7.Models
{
    internal class DniIncorrectoException:ApplicationException
    {
        public DniIncorrectoException():base("El dni ingresado es invalido") { }
        public DniIncorrectoException(string message):base(message) { }
        public DniIncorrectoException(string message, Exception innerException):base(message, innerException) { }
    }
}
