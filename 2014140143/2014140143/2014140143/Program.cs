using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2014140143
{
    class Program
    {
        static void Main(string[] args)
        {
            var evaluacion = new Evaluacion();
          
            evaluacion.AgregarCliente("Jordan Espiritu Martinez", "45632189", "2000");
            evaluacion.AgregarCliente("Jeyson Saavedra Chumpitaz", "45000189", "3000");
            evaluacion.AgregarCliente("Judhisa Artica Figueroa", "62563219", "2800");
            evaluacion.AgregarCliente("Neyba Prado Revilla", "78563209", "3500");
            evaluacion.AgregarCliente("Marcela Miranda Flores", "55775189", "1500");
            evaluacion.AgregarTipoPago("Efectivo");
            evaluacion.AgregarContrato("12 meses");
            evaluacion.AgregarContrato("18 meses");
            evaluacion.AgregarTipoTrabajador("Asesor");
           








            Console.WriteLine("Holi");
        }
    }
}
