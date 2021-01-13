using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Ej9
{
    class Cine
    {
        private Pelicula pelicula;
        private int precioSala;
        public string [,] salaArray = new string [10,10];

        public Pelicula Pelicula { get => pelicula; set => pelicula = value; }
        public int PrecioSala { get => precioSala; set => precioSala = value; }

        public Cine(Pelicula pelicula, int precioSala)
        {
            this.pelicula = pelicula;
            this.precioSala = precioSala;
        }

        public void mostrarSala()
        {
            char letra=' ';

            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <=9; j++)
                {
                    switch (j)
                    {
                        case 0:
                            letra = 'A';
                            break;
                        case 1:
                            letra = 'B';
                            break;
                        case 2:
                            letra = 'C';
                            break;
                        case 3:
                            letra = 'D';
                            break;
                        case 4:
                            letra = 'E';
                            break;
                        case 5:
                            letra = 'F';
                            break;
                        case 6:
                            letra = 'G';
                            break;
                        case 7:
                            letra = 'H';
                            break;
                        case 8:
                            letra = 'I';
                            break;
                        case 9:
                            letra = 'J';
                            break;

                        default:
                            letra = '0';
                            break;
                    }
                    if (salaArray[i,j]==null)
                    {
                        Console.Write(Convert.ToString(i+1)+letra + " ");
                    }
                    else
                    {
                        Console.Write("X ");
                    }
                }
                Console.WriteLine();
            }
        }

        public override string ToString()
        {           
            return "Pelicula: " + pelicula.ToString() + "\n Precio de la Sala: " + precioSala.ToString();
        }
    }
}
