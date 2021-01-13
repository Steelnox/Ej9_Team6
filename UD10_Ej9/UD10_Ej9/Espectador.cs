using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Ej9
{
    public class Espectador
    {
        private int id;
        private string nombre;
        private int edad;
        private double dinero;
        private int fila;
        private int columna;
        private bool sentado;

        public Espectador()
        {
            this.id = 0;
            this.nombre = "";
            this.edad = 0;
            this.dinero = 0;
            this.fila = 0;
            this.columna = 0;
            this.sentado = false;

        }

        public Espectador(int id, string nombre, int edad, double dinero)
        {
            this.id = id;
            this.nombre = nombre;
            this.edad = edad;
            this.dinero = dinero;
            this.fila = 0;
            this.columna = 0;
            this.sentado = false;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public double Dinero { get => dinero; set => dinero = value; }
        public int Fila { get => fila; set => fila = value; }
        public int Columna { get => columna; set => columna = value; }
        public bool Sentado { get => sentado; set => sentado = value; }

        public override string ToString()
        {
            return id.ToString() + " : " + nombre.ToString() + " Edad: " + edad.ToString() + " Dinero: " + dinero.ToString();
        }

        public bool ComprobarCliente(int min_edad, double dinero_ent)
        {
            if(min_edad > edad)
            {
                return false;
            }

            if(dinero_ent > dinero)
            {
                return false;
            }

            return true;
        }
        
    }
}
