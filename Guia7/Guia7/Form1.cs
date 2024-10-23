using Guia7.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Guia7
{
    public partial class Form1 : Form
    {
        DepartamentoVehicular dv=new DepartamentoVehicular();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                int DNI=Convert.ToInt32(tbDni.Text);
                string nombre=Convert.ToString(tbNombre.Text);
                string patente=Convert.ToString(tbPatente.Text);
                Persona dueño = new Persona(DNI, nombre);
                RegistroVehiculo ejemplo =  dv.RegistrarVehiculo(dueño,patente);

                tbDni.Clear();
                tbNombre.Clear();
                tbPatente.Clear();

            }
            catch(DniIncorrectoException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch(FormatoPatenteNoValidaException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            
          
        }

        private void btnRegistros_Click(object sender, EventArgs e)
        {
            FormVer vRegistros= new FormVer();

            dv.OrdenarRegistros();
            
            for(int n=0; n<dv.cantidadRegistros; n++)
            {
                vRegistros.tbRegistros.Text += dv.VerRegistro(n).ToString() + "\r\n";
            }

            vRegistros.ShowDialog();
            
        }
    }
}
