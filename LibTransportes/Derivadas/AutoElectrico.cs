using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public class AutoElectrico : Vehiculo
    {

        public AutoElectrico() { }
        public AutoElectrico(string modelo, int ruedas, decimal voltaje, int pasajeros) : base(modelo, ruedas)
        {
            Voltaje = voltaje;
            Pasajeros = pasajeros;
        }
        public decimal Voltaje { get; set; }
        public int Pasajeros { get; set; }

        public override string Acelera()
        {
            return base.Acelera() + "250 a pesar de ser un auto electrico";
        }
        public override string Frena()
        {
            return base.Frena() + " con sus frenos de disco jej";
        }
        public override string Imprimir()
        {
            return base.Imprimir() + $"Voltaje: {Voltaje} - Pasajeros: {Pasajeros}";
        }
    }
}
