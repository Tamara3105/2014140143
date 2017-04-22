using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Evaluacion
    {
        List<CentroAtencion> sucursal;
        List<Cliente> _cliente;
        List<TipoPago> _tipoPago;
        List<TipoTrabajador> _tipoTrabajador;
        List<Trabajador> _trabajador;
        List<TipoEvaluacion> _tipoEvaluacion;

        

        public Evaluacion()
        {
         
            sucursal = new List<CentroAtencion>();
            _cliente = new List<Cliente>();
            _tipoPago = new List<TipoPago>();
            _tipoTrabajador = new List<TipoTrabajador>();
            _trabajador = new List<Trabajador>();
            _tipoEvaluacion = new List<TipoEvaluacion>();
            
           
        }
        public void AgregarCliente(string nomb, string ape, string dni, string sue)
        {
            try
            {
                _cliente.Add(new Cliente(nomb, ape, dni, sue));
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
        }

        public void AgregarTipoPago(string tipo)
        {
            try
            {
                _tipoPago.Add(new TipoPago(tipo));
            }
            catch (Exception e)
            {
                Console.Write(e);
            }
        }

        public void AgregarTipoTrabajador(string tipoTrabajador)
        {
            try
            {
                _tipoTrabajador.Add(new TipoTrabajador(tipoTrabajador));
            }
            catch (Exception e)
            {
                Console.Write(e);
            }

        }
        public void AgregarTrabajador(string nom, string tipo)
        {
            try
            {
                _trabajador.Add(new Trabajador(nom, tipo));
            }
            catch (Exception e)
            {
                Console.Write(e);
            }

        }
        
              
    }

}

    

