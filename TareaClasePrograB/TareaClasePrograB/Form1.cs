using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TareaClasePrograB.CLases;

namespace TareaClasePrograB
{
    
    public partial class Form1 : Form
    {
        ClsAutoMotor carrito;
        private string ruta = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btncargar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                ruta = openFileDialog1.FileName;
                lblruta.Text = ruta;
            }
        }

        private void btnreproducir_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer.URL = ruta;
            axWindowsMediaPlayer.Ctlcontrols.play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            carrito = new ClsAutoMotor("Honda", 230, "Blanco");


            MessageBox.Show($"El carro {carrito.marca} llega a {carrito.vel_max} Km/h");

            buttonAcelerar.Visible = true;
            buttonFrenarDeGolpe.Visible = true;
            buttonEncender.Visible = true;
            buttonFrenarPoco.Visible = true;
            button1.Visible = false;
        }

        private void buttonBMW_Click(object sender, EventArgs e)
        {
            carrito = new ClsAutoMotor("BMW", 350, "Rojo");
            MessageBox.Show($"El caro {carrito.marca} llega a {carrito.vel_max} Km/h");
            buttonAcelerar.Visible = true;
            buttonFrenarDeGolpe.Visible = true;
            buttonEncender.Visible = true;
            buttonFrenarPoco.Visible = true;
            buttonBMW.Visible = false;
        }

        private void buttonEncender_Click(object sender, EventArgs e)
        {
            labelEstado.Text = $"el carro {carrito.marca} : {carrito.encender()}";
        }

        private void buttonAcelerar_Click(object sender, EventArgs e)
        {
            if (carrito == null)
            {
                MessageBox.Show("Primero debes crear el carro");
            }
            else

            {
                labelEstadoVelocidad.Text = carrito.Acelerar();
            }
        }

        private void buttonFrenarPoco_Click(object sender, EventArgs e)
        {
            labelEstadoVelocidad.Text = carrito.frenarpocoApoco();
        }

        private void buttonFrenarDeGolpe_Click(object sender, EventArgs e)
        {
            labelEstadoVelocidad.Text = carrito.FrenarDeGolpe();
        }
    }

    
}

