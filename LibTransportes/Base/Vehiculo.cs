using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public abstract class Vehiculo
    {
        public Vehiculo() { }
        public Vehiculo(string modelo, int ruedas)
        {
            Modelo = modelo;
            Ruedas = ruedas;
        }

        public string Modelo { get; set; }
        public int Ruedas { get; set; }

        #region Metodos virtuales 
        public virtual string Acelera()
        {
            return "Acelerando a km/h...";
        }

        public virtual string Frena()
        {
            return "Frenando con frenos de :...";
        }
        public virtual string Imprimir()
        {
            return $"Propiedades:  Modelo: {Modelo} - Ruedas: {Ruedas} -";
        }
        #endregion

    }
}
