using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia7.Models
{
    internal class Persona
    {
        int dni;
        public int DNI
        {
            get { return dni; }
            set
            {
                if (value <= 1000000)
                {
                    throw new DniIncorrectoException();

                }
            }
        }
        public string Nombre { get; set; }

        public Persona(int dni, string nombre)
        {
           DNI= dni;
           Nombre= nombre;
        }
    }
}
