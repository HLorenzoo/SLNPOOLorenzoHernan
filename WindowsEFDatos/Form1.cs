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

            MostrarAviones();
            LineaAerea Linea = new LineaAerea() { Nombre = "Aerolineas Hernu . NET", FechaInicioActividades = DateTime.Now };
             AbmLinea.Insert(Linea);

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                int id = Convert.ToInt32(textBox1.Text);
                int res = AbmAvion.Eliminar(id);

                if (res > 0)
                {
                    MessageBox.Show("delete");
                    MostrarAviones();
                }

                if (res == 0) MessageBox.Show("No se pudo borra na perro");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Avion avion = new Avion()
            {
                IdAvion = Convert.ToInt32(textBox1.Text),
                Denominacion = textBox2.Text,
                Capacidad = Convert.ToInt32(textBox3.Text),
            };
          
            int res = AbmAvion.Editar(avion);
            if (res > 0)
            {
                MessageBox.Show("Avion editado");
                MostrarAviones();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(textBox1.Text);
            Avion avionAMostrar = AbmAvion.TraerUno(id);
            if (avionAMostrar != null) MessageBox.Show($"\n\t Avion Encontrado : \n\t Denominacion :{avionAMostrar.Denominacion}  \n\t Capacidad: {avionAMostrar.Capacidad}");
            if (avionAMostrar == null) MessageBox.Show("no hay nada");
        }
    }
}
