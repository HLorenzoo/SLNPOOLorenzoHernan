using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibTransportes
{
    public class Camion : Vehiculo
    {

        public Camion() { }
        public Camion(string modelo, int ruedas, bool llevaTrailer, int cantAcoplados) : base(modelo, ruedas)
        {
            LlevaTrailer = llevaTrailer;
            CantAcoplados = cantAcoplados;
        }
        public bool LlevaTrailer { get; set; }
        public int CantAcoplados { get; set; }

        public Remolque Remolque { get; set; }

        public Remolque QuitarRemolque()
        {
            return Remolque = null;
        }
        public override string Acelera()
        {
            return base.Acelera() + "120 debido a que el camion es pesado";
        }
        public override string Frena()
        {
            return base.Frena() + "a larga distancia y con todas sus ruedas";
        }
        public override string Imprimir()
        {
            return base.Imprimir() + $"LlevaTrailer: {(LlevaTrailer? "si":"no")} - CantAcoplados: {CantAcoplados}";
        }
    }
}
