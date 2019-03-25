using System;
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
            //    Ejercicio_01(out max,out min,out promedio);
            //    Console.Write("EL NUMERO MAX ES {0},EL MIN ES {1} Y EL PROMEDIO ES {2}", max, min, promedio);
            //    Ejercicio_02();
            // Ejercicio_03();
           // Ejercicio_04();
            // Ejercicio_05();
           // Ejercicio_06();
            Ejercicio_07();
            Console.ReadKey();
        }
        static void Ejercicio_01(out int max, out int min, out int promedio)
        {
            int i;
            int ingreso, acum = 0;
            bool success;
            max = 0;
            min = 0;
            for (i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    Console.Write("\nINGRESE UN NUMERO : ");
                    while (success = int.TryParse(Console.ReadLine(), out ingreso) == false)
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
                    else if (min > ingreso)
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
        static void Ejercicio_02()
        {
            int ingreso;
            bool success;
            Console.WriteLine("\nINGRESE UN NUMERO: ");
            while (success = int.TryParse(Console.ReadLine(), out ingreso) == false)
            {
                Console.WriteLine("\nERROR. ¡Reingresar número! : ");
            }
            Console.WriteLine("\nEl CUADRADO DE SU NUMERO ES : {0} Y EL CUBO ES : {1}", Math.Pow(ingreso, 2), Math.Pow(ingreso, 3));
        }
        static void Ejercicio_03()
        {
            int ingreso, i;
            int resto;
            bool success;
            Console.WriteLine("\nINGRESE UN NUMERO: ");
            while (success = int.TryParse(Console.ReadLine(), out ingreso) == false || ingreso < 0)
            {
                Console.WriteLine("\nERROR. ¡Reingresar número! : ");
            }
            i = ingreso;
            Console.WriteLine("\nLOS NUMEROS PRIMOS DE SU NUMERO SON:\n");
            for (; i > 0; i--)
            {
                resto = ingreso % i;
                if (resto == 0)
                {
                    Console.WriteLine(" {0} -", i);
                }

            }

        }
        static void Ejercicio_04()
        {
            int i, acumulador;
            int j;
            int success = 0;
            Console.WriteLine("\nNUMEROS PERFECTOS: ");
            for (i = 1; success < 4; i++)
            {
                acumulador = 0;
                for (j = i - 1; j > 0; j--)
                {
                    if (i % j == 0)
                    {
                        acumulador += j;
                    }
                }
                if (acumulador == i)
                {
                    success++;
                    Console.WriteLine("- {0} -", i);
                }
            }

        }
        static void Ejercicio_05()
        {
            int ingreso, i, acumuladorMenor, acumuladorMayor, j, x;
            bool success;
            Console.WriteLine("\nINGRESE UN NUMERO: ");
            while (success = int.TryParse(Console.ReadLine(), out ingreso) == false || ingreso < 0)
            {
                Console.WriteLine("\nERROR. ¡Reingresar número! : ");
            }
            Console.WriteLine("\nLOS CENTROS NUMERICOS SON: ");
            for (i = ingreso; i > 1; i--)
            {
                acumuladorMenor = 0;
                acumuladorMayor = 0;
                for (j = i - 1; j > 0; j--)
                {
                    acumuladorMenor += j;
                }
                for (x = i + 1; acumuladorMayor < acumuladorMenor; x++)
                {
                    acumuladorMayor += x;
                }
                if (acumuladorMenor == acumuladorMayor)
                {
                    Console.WriteLine("\n- {0} -", i);
                }
            }
        }
        static void Ejercicio_06()
        {
            int FechaInicio, FechaFinal;
            bool success;
            Console.WriteLine("\nINGRESE FECHA DE INICIO: ");
            while (success = int.TryParse(Console.ReadLine(), out FechaInicio) == false || FechaInicio <= 0)
            {
                Console.WriteLine("\nERROR. ¡Reingresar número! : ");
            }
            Console.WriteLine("\nINGRESE FECHA FINAL: ");
            while (success = int.TryParse(Console.ReadLine(), out FechaFinal) == false || FechaFinal < FechaInicio)
            {
                Console.WriteLine("\nERROR. ¡Reingresar número! (debe ser mayor a la fecha de inicio ");
            }
            Console.WriteLine("\nAÑOS BISIESTOS EN EL MEDIO : \n");
            while (FechaInicio < FechaFinal)
            {
                if ((FechaInicio % 100 == 0 && FechaInicio % 400 == 0) || FechaInicio % 4 == 0)
                {
                    Console.WriteLine("- {0} -", FechaInicio);
                }
                FechaInicio++;
            }
        }
        static void Ejercicio_07()
        {
            DateTime localTime = DateTime.Now;
            DateTime fechaNacimiento;
            int mes, dia =0, año ,diasVividos;
            int conAñosBis=0;
            bool success;
            Console.WriteLine("\nINGRESE SU FECHA DE INICIMIENTO: ");
            Console.WriteLine("\nINGRESE EL MES: ");
            while (success = int.TryParse(Console.ReadLine(), out mes) == false || (mes < 1 || mes > 12))
            {
                Console.WriteLine("\nERROR. ¡Reingresa un número valido! : ");
            }
            switch (mes)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("\nINGRESE EL DIA: ");
                    while ((success = int.TryParse(Console.ReadLine(), out dia) == false) || (dia < 1 || dia > 31))
                    {
                        Console.WriteLine("\nERROR. ¡Reingresa un dia valido! : ");
                    }
                    break;
                case 2:
                    Console.WriteLine("\nINGRESE EL DIA: ");
                    while (success = int.TryParse(Console.ReadLine(), out dia) == false || (dia < 1 || dia > 28))
                    {
                        Console.WriteLine("\nERROR. ¡Reingresa un dia valido! : ");
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("\nINGRESE EL DIA: ");
                    while (success = int.TryParse(Console.ReadLine(), out dia) == false || (dia < 1 || dia > 30))
                    {
                        Console.WriteLine("\nERROR. ¡Reingresa un dia valido! : ");
                    }
                    break;
            }

            Console.WriteLine("\nINGRESE EL AÑO: ");
            while (success = int.TryParse(Console.ReadLine(), out año) == false || (año < 1 || año > 2019))
            {
                Console.WriteLine("\nERROR. ¡Reingresa un número valido! : ");
            }
            diasVividos = (2019 - año) * 365;
            diasVividos += dia; 
            while (año < 2019)
            {
                if ((año % 100 == 0 && año % 400 == 0) || año % 4 == 0)
                {
                    conAñosBis++;
                }
                año++;
            }
            switch (mes)
            {
                case 2:
                    diasVividos += 31;
                    break;
                case 3:
                    diasVividos += 59;
                    break;
                case 4:
                    diasVividos += 90;
                    break;
                case 5:
                    diasVividos += 120;
                    break;
                case 6:
                    diasVividos += 151;
                    break;
                case 7:
                    diasVividos += 182;
                    break;
                case 8:
                    diasVividos += 212;
                    break;
                case 9:
                    diasVividos += 243;
                    break;
                case 10:
                    diasVividos += 273;
                    break;
                case 11:
                    diasVividos += 304;
                    break;
                case 12:
                    diasVividos += 334;
                    break;
            }   
            Console.WriteLine("USTED VIVIO {0} DIAS ",diasVividos);

        }

    }
}