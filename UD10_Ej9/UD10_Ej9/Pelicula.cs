using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Ej9
{
    public class Pelicula
    {
        private string titulo;
        private int duracion;
        private int edad_min;
        private string director;

        public Pelicula()
        {
            this.titulo = "";
            this.duracion = 0;
            this.edad_min = 0;
            this.director = "";
        }
        public Pelicula(string titulo, int duracion, int edad_min, string director)
        {
            this.titulo = titulo;
            this.duracion = duracion;
            this.edad_min = edad_min;
            this.director = director;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int Duracion { get => duracion; set => duracion = value; }
        public int Edad_min { get => edad_min; set => edad_min = value; }
        public string Director { get => director; set => director = value; }


        public override string ToString()
        {
            return "Titulo: "+titulo.ToString() + " Duracion: " + duracion.ToString() + " Edad minima: " + edad_min.ToString() + " Director: " + director.ToString();
        }

    }
}
