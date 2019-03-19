﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            int max, min, promedio;
            Ejercicio_01(out max,out min,out promedio);
            Console.Write("EL NUMERO MAX ES {0},EL MIN ES {1} Y EL PROMEDIO ES {2}", max, min, promedio);
            Console.ReadKey();
        }
        static void Ejercicio_01(out int max,out int min,out int promedio)
        {
            int i;
            int ingreso, acum =0;
            bool success;
            max = 0;
            min = 0;
            for (i = 0; i < 5; i++)
            {
                if (i==0)
                {
                    Console.Write("\nINGRESE UN NUMERO : ");
                    while (success = int.TryParse(Console.ReadLine(), out ingreso)==false)
                    {
                        Console.Write("\nINTENTE NUEVAMENTE ");
                    }
                    max = ingreso;
                    min = ingreso;
                    acum += ingreso;
                }
                else
                {
                    Console.Write("\nINGRESE UN NUMERO : ");
                    while (success = int.TryParse(Console.ReadLine(), out ingreso) == false)
                    {
                        Console.Write("\nINTENTE NUEVAMENTE ");
                    }
                    if (max < ingreso)
                    {
                        max = ingreso;
                        acum += ingreso;
                    }
                    else if(min>ingreso)
                    {
                        min = ingreso;
                        acum += ingreso;
                    }
                    else
                    {
                        acum += ingreso;
                    }
                }
            }
            promedio = acum / 5;
        }
    }
}
