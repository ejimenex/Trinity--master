using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace spirit.Helper
{
   public class Venta
    {
        private int _lado;
        private int _manguera;
        private string _combustible;
        private double _volumen;
        private double _monto;
        private string _fecha = "N/A";
        private string _hora;
        
        public int lado
        {
            get { return this._lado; }
            set { this._lado = value; }
        }

        public int manguera
        {
            get { return this._manguera;}
            set {this._manguera = value;}
        }

        public string combustible
        {
            get { return this._combustible; }
            set { this._combustible = value; }
        }

        public double volume
        {
            get { return this._volumen; }
            set { this._volumen = value; }
        }

        public double monto
        {
            get { return this._monto; }
            set { this._monto = value; }
        }

        public string fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }
        public string hora
        {
            get { return this._hora; }
            set { this._hora = value; }
        }

        public override string ToString()
        {
            return "Fecha = " + fecha;
        }
    }
}
