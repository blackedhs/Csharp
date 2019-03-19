using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static string miPalabra;
        static int varA;
        static int varB;
        static int result;
        static void Main(string[] args)
        {
            mySwich();
        }

        static void mySwich()
            {   
                do
            {
                Console.Write("\n1-SUMAR\n2-RESTAR\n3-MULTIPLICAR\n4-DIVIDIR\n5-SALIR\nINGRESE LA OPCION DESEADA:");
                miPalabra = Console.ReadLine();
                switch (miPalabra)
                {
                    case "1":
                        Console.Write("\ningrese el primer valor :");
                        miPalabra = Console.ReadLine();
                        int.TryParse(miPalabra, out varA);
                        Console.Write("\ningrese el segundo valor :");
                        miPalabra = Console.ReadLine();
                        int.TryParse(miPalabra, out varB);
                        result = varA + varB;
                        Console.Write("\nLA SUMA ES : {0}" ,result);
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.Write("\ningrese el primer valor :");
                        miPalabra = Console.ReadLine();
                        int.TryParse(miPalabra, out varA);
                        Console.Write("\ningrese el segundo valor :");
                        miPalabra = Console.ReadLine();
                        int.TryParse(miPalabra, out varB);
                        result = varA - varB;
                        Console.Write("\nLA RESTA ES :" + result);
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.Write("\ningrese el primer valor :");
                        miPalabra = Console.ReadLine();
                        int.TryParse(miPalabra, out varA);
                        Console.Write("\ningrese el segundo valor :");
                        miPalabra = Console.ReadLine();
                        int.TryParse(miPalabra, out varB);
                        result = varA / varB;
                        Console.Write("\nLA DIVIDIR ES :" + result);
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.Write("\ningrese el primer valor :");
                        miPalabra = Console.ReadLine();
                        int.TryParse(miPalabra, out varA);
                        Console.Write("\ningrese el segundo valor :");
                        miPalabra = Console.ReadLine();
                        int.TryParse(miPalabra, out varB);
                        result = varA * varB;
                        Console.Write("\nLA MULTIPLICACION ES :" + result);
                        Console.ReadKey();
                        break;

                }
            } while (!(miPalabra == "5"));
            }

    }
}
