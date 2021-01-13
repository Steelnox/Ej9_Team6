using System;
using System.Collections.Generic;
using System.Text;

namespace UD10_Ej9
{
    class Menu
    {
        public void PintarMenu()
        {
            Console.WriteLine("********** BIENVENIDO AL CINE TEAM 6 **********");
            Console.WriteLine("Inserta el precio de las entradas: ");
            string precio = Console.ReadLine();
            Console.WriteLine("Inserta título de la película:");
            string peli = Console.ReadLine();
            Console.WriteLine("Minutos de duración: ");
            string duracion = Console.ReadLine();
            Console.WriteLine("Edad mínima de acceso: ");
            string edad_minima = Console.ReadLine();
            Console.WriteLine("Director de la película: ");
            string director = Console.ReadLine();

            Pelicula P1 = new Pelicula(peli, Convert.ToInt32(duracion), Convert.ToInt32(edad_minima), director);
            Cine C1 = new Cine(P1, Convert.ToInt32(precio));

            Random aleatorio_asientos = new Random();
            Espectador[] ListaEspectadores = new Espectador[10]; //array listado de 10 espectadores

            string[] nombres = { "Luis", "Pedro", "Manuel", "Francisco", "Juan", "Andrés", "Santi", "Carlos", "Jorge", "Diego", "Mario", "Alex", "Antonio", "Lucía", "Ana", "Andrea", "Cristina", "María", "Lara", "Bea", "Cris", "Paula", "Pilar", "Rocio", "Esther", "Raquel", "Daniela" };
            string[] apellidos = { "García", "Marín", "Gómez", "Castaño", "del Valle", "Longas", "Carrasco", "Cano", "Martínez", "Sanchez", "Martín", "Álvarez", "Mateo", "Ramos", "Carvajal", "Fernández" };
            string nombre_espectador = "";

            //relleno el array con espectadores inventados
            for (int i = 0; i <= ListaEspectadores.Length - 1; i++)
            {
                Random aleatorio = new Random();
                nombre_espectador = nombres[aleatorio.Next(0, nombres.Length - 1)] + " " + apellidos[aleatorio.Next(0, apellidos.Length - 1)];
                ListaEspectadores[i] = new Espectador((i + 1), nombre_espectador, aleatorio.Next(5, 80), aleatorio.Next(0, 20));
            }

            Console.WriteLine();
            Console.WriteLine("------LISTADO POSIBLES ESPECTADORES:"); //muestro los espectadores creados

            for (int i = 0; i <= ListaEspectadores.Length - 1; i++)
            {
                Console.WriteLine(ListaEspectadores[i].ToString());
            }
            //repaso los espectadores para sentarlos
            for (int i = 0; i <= ListaEspectadores.Length - 1; i++)
            {
                //compruebo que cumple las 2 condiciones           
                if (ListaEspectadores[i].ComprobarCliente(Convert.ToInt32(edad_minima),Convert.ToDouble(precio)) ==true)
                {
                    ListaEspectadores[i].Dinero -= Convert.ToDouble(precio);
                    bool sentado = false;

                    //repito el proceso hasta que se siente
                    while (sentado == false)
                    {
                        //busco el asiento de manera aleatoria
                        int fila = aleatorio_asientos.Next(0, 8);
                        int columna = aleatorio_asientos.Next(0, 9);

                        if (C1.salaArray[fila, columna] == null)//compruebo que el asiento esté vacio
                        {
                            C1.salaArray[fila, columna] = Convert.ToString(ListaEspectadores[i].Id);
                            ListaEspectadores[i].Fila = fila;
                            ListaEspectadores[i].Columna = columna;
                            sentado = true;
                            ListaEspectadores[i].Sentado = true;
                        }
                    }

                }

            }
            //pinto como queda la sala
            Console.WriteLine();
            Console.WriteLine("---------------- DISTRIBUCIÓN DE LA SALA:");
            C1.mostrarSala();

            Console.WriteLine();
            Console.WriteLine("----------Repaso a los espectadores:");

            char letra = ' ';

            // hago repaso a los espectadores, diciendo si se sienta o no, su asiento y el dinero que le queda
            for (int i = 0; i <= ListaEspectadores.Length - 1; i++)
            {
                Console.Write(ListaEspectadores[i].ToString());
                if (ListaEspectadores[i].Sentado==false)
                {
                    Console.WriteLine(". El espectador NO ha entrado al cine");
                }
                else
                {
                    switch (ListaEspectadores[i].Columna)
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
                        default:
                            letra = '0';
                            break;
                    }
                    Console.WriteLine(". El espectador SI ha entrado al cine. Asiento: {0}{1}", ListaEspectadores[i].Fila + 1, letra);

                }

            }
        }
    }
}