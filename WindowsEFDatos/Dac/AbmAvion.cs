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

    }
}
