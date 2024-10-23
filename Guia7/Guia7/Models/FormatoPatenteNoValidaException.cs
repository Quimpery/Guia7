using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia7.Models
{
    internal class FormatoPatenteNoValidaException:ApplicationException
    {
        public FormatoPatenteNoValidaException() : base("Formato patente no valido") { }

        public FormatoPatenteNoValidaException(string message) : base(message) { }
        public FormatoPatenteNoValidaException(string message,Exception innerException):base(message, innerException) { }
    }
}
