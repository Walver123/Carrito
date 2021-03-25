using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaClasePrograB.CLases
{
    class ClsAutoMotor
    {
        public String marca { get; }
        public int vel_max { get; }
        public string color { get; set; }
        private int velocidadActual = 0;
        public int Frenarpoco { get; }
        public bool encendido { get; set; } = false;
        public ClsAutoMotor(string marcaCarro, int MaxVel)
        {
            this.vel_max = MaxVel;
            this.marca = marcaCarro;
        }
        public string FrenarDeGolpe()
        {
            if (!encendido)
            {
                return "Primero deber encender el auto";
            }
            velocidadActual = 0;
            return "Carro frenado 0 Km/h";
        }
        public ClsAutoMotor(String marcaCaro, int MaxVel, string colorCarro)
        {
            this.vel_max = MaxVel;
            this.marca = marcaCaro;
            this.color = colorCarro;
        }
        public string encender()
        {
            string respuesta = "";

            if (encendido)
            {

                encendido = false;
                respuesta = "El carro está apagado";
            }
            else
            {

                encendido = true;
                respuesta = "Carro encendido";
            }
            velocidadActual = 0;
            return respuesta;
        }

        public string Acelerar()
        {
            if (!encendido)
            {
                return "Enciende el carro primero";
            }
            if (velocidadActual == vel_max)
            {
                velocidadActual = vel_max;
                return $"Para ya llegaste a velocidad maxima{vel_max} Km/h";
            }
            else
            {
                velocidadActual = velocidadActual + 10;
                return $"Vas a {velocidadActual} Km/h";
            }

        }
        public string frenarpocoApoco()
        {
            if (!encendido)
            {
                return "Enciende el carro primero";
            }
            if (velocidadActual == Frenarpoco)
            {
                velocidadActual = Frenarpoco;
                return $"Estas en {Frenarpoco} Km/h";
            }
            else
            {
                velocidadActual = velocidadActual - 10;
                return $"vas a {velocidadActual} km/h";

            }

        }


    }
}

