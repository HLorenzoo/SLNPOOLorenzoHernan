using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibTransportes;

namespace PresentaciónVehiculos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCamion_Click(object sender, EventArgs e)
        {
            Camion Camion = new Camion("Camion Doble Acoplado", 12, true, 3);
            MessageBox.Show($"SE CREO UN CAMION CORRECTAMENTE \n\t+{Camion.Modelo}\n\tCantidad de Ruedas :+{Camion.Ruedas}");
        }

        private void btnRemolque_Click(object sender, EventArgs e)
        {
            Remolque Remolque= new Remolque();
            MessageBox.Show($"SE CREO UN REMOLQUE");

        }
    }
}
