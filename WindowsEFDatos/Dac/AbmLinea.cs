using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEFDatos.Data;
using WindowsEFDatos.Modelos;

namespace WindowsEFDatos.Dac
{
    public static class AbmLinea
    {
       
        public static WindowsEFDatosContext context = new WindowsEFDatosContext();
     

        public static int Insert(LineaAerea LineaAerea)
        {
            context.LineaAereas.Add(LineaAerea);

            return context.SaveChanges();
        }

    }
}
