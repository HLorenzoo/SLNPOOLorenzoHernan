using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Data;
using WindowsEFDatos.Modelos;

namespace WindowsEFDatos.Dac
{
    public static class AbmAvion
    {
       
        public static WindowsEFDatosContext context = new WindowsEFDatosContext();
        public static List<Avion> SelectAll()
        {
            return context.Aviones.ToList();
        }

        public static int Insert(Avion Avion)
        {
            context.Aviones.Add(Avion);

            return context.SaveChanges();
        }
        public static Avion TraerUno(int id)
        {
            return context.Aviones.Find(id);

        }
        public static int Eliminar(int id)
        {
            Avion avionOrigen = context.Aviones.Find(id);
            if (avionOrigen != null)
            {
                context.Aviones.Remove(avionOrigen);
                return context.SaveChanges();
            }
            return 0;
        }
        public static int Editar(Avion avion)
        {
            Avion categoriaOrigen = context.Aviones.Find(avion.IdAvion);
            categoriaOrigen.Denominacion = avion.Denominacion;
            categoriaOrigen.Capacidad = avion.Capacidad;
            return context.SaveChanges();
        }


    }
}
