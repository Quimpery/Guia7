using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia7.Models
{
    internal class RegistroVehiculo:IComparable
    {
        public string Patente { get; set; }
        public string Serie { get; set; }
        
        public Persona Propietario { get; set; }

        public RegistroVehiculo(string patente,Persona propietario,int serie)
        {
            this.Patente = patente;
            this.Serie = serie.ToString();
            this.Propietario=propietario;

            Match m=Regex.Match(patente.Trim(),@"^[A-Z]{3}\s*[0-9]{3}$",RegexOptions.IgnoreCase);
            if (m.Success == false)
            {
                throw new FormatException();
            }
        }
        
        public int CompareTo(object obj)
        {
            RegistroVehiculo otro = obj as RegistroVehiculo;
            if (otro != null) 
                return this.Patente.CompareTo(otro.Patente);
            return 1;
           
        }
        public override string ToString()
        {
            return "Patente: "+Patente+ "Propietaro: "+Propietario.Nombre+Propietario.DNI;
        }
        
    }
}
