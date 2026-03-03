using System;
using System.Collections.Generic;
using System.Text;

namespace Caso_Desarrollo_4
{
    public class Factura
    {
        // Declaración de atributos privados
        private int _numFactura;
        private DateTime _fechaFact;
        private double _montoFact;

        static private double acumulado;
        static private int n;

        //Metodo constructor con parametros 
        public Factura(int numFactura, DateTime fechaFact, double montoFact)
        {
            this._numFactura = numFactura;
            this._fechaFact = fechaFact;
            this._montoFact = montoFact;
            acumulado += montoFact;
            n++;
        }

        // Metodos GET's
        public int numFactura
        {
            get { return _numFactura; }
        }

        public DateTime fechaFact
        {
            get { return _fechaFact; }
        }

        public double montoFact
        {
            get { return _montoFact; }
        }
        public int totalFacturas()
        {
            return n;
        }
        public double calculaTotalSubtotal()
        {
            return acumulado;
        }
        public double calculaComision()
        {
            return 0.12 * calculaTotalSubtotal();
        }
        // Función lambda que muestra la fecha actual
        Func<string> muestraFecha = () => DateTime.Now.ToShortDateString();
    }
}



