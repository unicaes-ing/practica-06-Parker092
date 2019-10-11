using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_6
{
    class Program
    {
        // int num;
        static void Main(string[] args)
        {
            int op;

            Console.WriteLine("***SELECCIONE EJERCICIO***");
            Console.WriteLine("* 1 * Tablas.");
            Console.WriteLine("* 2 * Dibujo.");
            Console.WriteLine("* 3 * Potenciacion.");
            Console.WriteLine("* 4 * Conversion DEC-BIN.");
            Console.WriteLine("* 5 * Salir.");
            int.TryParse(Console.ReadLine(), out op);
            switch (op)
            {
                case 1:
                    int num, op2;
                    Console.WriteLine("Ingrese numero de tabla a generar: ");
                    int.TryParse(Console.ReadLine(), out num);
                    Console.WriteLine("* 1 * Tabla.");
                    Console.WriteLine("* 2 * Tabla y Color.");
                    int.TryParse(Console.ReadLine(), out op2);
                    if (op2 == 1)
                    {
                        Ejer1(num);
                    }
                    else
                    {
                        if (op2 == 2)
                        {
                            //ConsoleColor color;
                            Console.WriteLine("Seleccione un color: ");
                            Console.WriteLine("* 1 * Amarillo");
                            Console.WriteLine("* 2 * Rojo");
                            Console.WriteLine("* 3 * Azul");
                            int opColor = Convert.ToInt32(Console.ReadLine());
                            switch (opColor)
                            {
                                case 1:
                                    Ejer1(num, ConsoleColor.Yellow);
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine("* 1 * Dibujo");
                    Console.WriteLine("* 2 * Dibujo y Caracter");
                    Console.WriteLine("* 3 * Dibujo, Caracter y Coordenadas");
                    int.TryParse(Console.ReadLine(), out op2);
                    switch (op2)
                    {
                        case 1:
                            Console.WriteLine("introduce el alto del rectangulo");
                            int alto = int.Parse(Console.ReadLine());
                            Console.WriteLine("introduce el ancho del rectangulo");
                            int ancho = int.Parse(Console.ReadLine());
                            Ejer2(alto, ancho);
                            break;
                        case 2:
                            Console.WriteLine("Introduce el ALTO del rectangulo:");
                            alto = int.Parse(Console.ReadLine());
                            Console.WriteLine("Introduce el ANCHO del rectangulo:");
                            ancho = int.Parse(Console.ReadLine());
                            Console.WriteLine("Introdusca el caracter:");
                            char car = Convert.ToChar(Console.ReadLine());
                            Ejer2(alto, ancho, car);
                            break;
                        default:
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Ingrese Base: ");
                    double bas = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese Expoenente:: ");
                    int exp = Convert.ToInt32(Console.ReadLine());
                    potencia(bas, exp);
                    break;
                case 4:
                    int numero;
                    string result = null;
                    Console.WriteLine("Ingrese el numero");
                    int.TryParse(Console.ReadLine(), out numero);
                    result = Bin(numero);
                    Console.WriteLine("\nEl valor binario de " + numero + " es " + result);
                    Console.WriteLine("\nUsando formato de C#: " + Convert.ToString(numero, 2));
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
        //Ejercicio 1
        #region 
        public static void Ejer1(int num)
        {

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine("\t" + num + " x " + i + " = " + (num * i));
            }
            Console.WriteLine("Presione <ENTER> para continuar.");
            Console.ReadKey();
        }
        public static void Ejer1(int num, ConsoleColor color)
        {
            for (int i = 1; i < 11; i++)
            {
                Console.ForegroundColor = color;
                Console.WriteLine("\t" + num + " x " + i + " = " + (num * i));
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Presione <ENTER> para continuar.");
            Console.ReadKey();
        }
        #endregion
        //Ejercicio 2
        #region
        public static void Ejer2(int alto, int ancho)
        {
            for (int i = 1; i <= alto; i++) // For para el alto 
            {
                for (int j = 1; j <= ancho; j++) // For para el ancho
                {
                    Console.Write("* ");
                }
                Console.WriteLine(" ");
            }
        }
        public static void Ejer2(int alto, int ancho, char car)
        {
            for (int i = 1; i <= alto; i++) // For para el alto 
            {
                for (int j = 1; j <= ancho; j++) // For para el ancho
                {
                    Console.Write(car + " ");
                }
                Console.WriteLine(" ");
            }
        }
        #endregion
        //Ejercicio 3
        #region
        static double potencia(double bas, int exp)
        {
            double res = 0;
            if (exp == 0)
                res = 1.0;
            else if (exp > 0)
            {
                res = (bas * potencia(bas, exp - 1));
            }
            else if (exp < 0)
            {
                res = (1.0 / bas * potencia(bas, exp + 1));
            }
            return res;
        }

        #endregion
        //Ejercicio 4
        #region
        /*public static string getBinario(int numero)
        {
            string resto = "";
            string binario = "";

            while ((numero >= 2))
            {
                resto = resto + (numero % 2).ToString();
                numero = numero / 2;
            }
            resto = resto + numero.ToString();

            for (int i = resto.Length; i >= 1; i += -1)
            {
                binario = binario + resto.Substring(i - 1, 1);
            }

            return binario;
        }*/
        #endregion
        //recusivo
        #region
        public static String Bin(int numero)
        {
            String digito = Convert.ToString(numero % 2);
            if (numero >= 2)
            {
                string restoString = Bin(numero / 2);
                return restoString + digito;
            }
            return digito;
        }
        //dec to bin Console.WriteLine(Convert.ToString(numero, 2));
        //dec to octal (Console.WriteLine(Convert.ToString(Number, 8));
        // dec to hex Console.WriteLine(Convert.ToString(Number, 16));
        #endregion
    }
}
