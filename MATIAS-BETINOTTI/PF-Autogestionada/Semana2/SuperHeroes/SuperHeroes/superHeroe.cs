using System;
using System.Collections.Generic;
using System.Text;

namespace Semana2
{
    internal class SuperHeroe
    {
        private string nombre;
        private int fuerza;
        private int resistencia;
        private int superpoderes;

        public SuperHeroe(string nombre, int fuerza, int resistencia, int superpoderes)
        {
            this.Nombre = nombre;
            this.Fuerza = fuerza;
            this.Resistencia = resistencia;
            this.Superpoderes = superpoderes;
        }

        public string Nombre
        {
            get { return nombre; }
            private set { nombre = value; }
        }

        public int Fuerza
        {
            get { return fuerza; }
            private set { fuerza = validarNumero(value); }
        }

        public int Resistencia
        {
            get { return resistencia; }
            private set { resistencia = validarNumero(value); }
        }

        public int Superpoderes
        {
            get { return superpoderes; }
            private set { superpoderes = validarNumero(value); }
        }
        private int validarNumero(int value)
        {
            if (value < 0)
                return 0;
            else if (value > 100)
                return 100;
            return value;
        }

        public string competir(SuperHeroe contrincante)
        {
            int puntosHeroe = 0;
            int puntosContrincante = 0;

            if (this.Fuerza > contrincante.Fuerza)
                puntosHeroe++;
            else if (this.Fuerza < contrincante.Fuerza)
                puntosContrincante++;

            if (this.Resistencia > contrincante.Resistencia)
                puntosHeroe++;
            else if (this.Resistencia < contrincante.Resistencia)
                puntosContrincante++;

            if (this.Superpoderes > contrincante.Superpoderes)
                puntosHeroe++;
            else if (this.Superpoderes < contrincante.Superpoderes)
                puntosContrincante++;

            if (puntosContrincante >= 2)
                return "DERROTA";
            else if (puntosHeroe >= 2)
                return "TRIUNFO";
            return "EMPATE";
        }

    }
}
