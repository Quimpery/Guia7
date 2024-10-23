using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia7.Models
{
    internal class DepartamentoVehicular
    {
        public int cantidadRegistros { get { return registros.Count; } set{ } }
        private int serie;

        public List<RegistroVehiculo> registros=new List<RegistroVehiculo>();
        public RegistroVehiculo RegistrarVehiculo(Persona propietario,string patente)
        {
            RegistroVehiculo nuevo = new RegistroVehiculo(patente, propietario, serie);
            registros.Add(nuevo);
            return nuevo;

        }
        public void OrdenarRegistros()
        {
            registros.Sort();
        }

        public RegistroVehiculo VerRegistro(int idx)
        {
            if (idx >= 0 && idx < cantidadRegistros)
            {
                return registros[idx];
            }
            return null;
        }
    }
}
