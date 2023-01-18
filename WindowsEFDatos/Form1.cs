using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFDatos.Dac;
using WindowsEFDatos.Modelos;

namespace WindowsEFDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LineaAerea Linea = new LineaAerea() { Nombre = "Aerolineas Hernu . NET",FechaInicioActividades=DateTime.Now };
;           AbmLinea.Insert(Linea);
            MostrarAviones();

        }
        private void MostrarAviones()
        {
            dataGridView1.DataSource = AbmAvion.SelectAll();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Avion avion = new Avion() { Denominacion="Avion de Hernu",Capacidad=200,IdLineaAerea=1 };

            int res = AbmAvion.Insert(avion);


            if (res > 0)
            {
                MessageBox.Show("Se creo el avion correctamente!");
                MostrarAviones();
            }

        }
    }
}
