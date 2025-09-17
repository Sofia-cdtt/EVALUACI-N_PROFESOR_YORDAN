using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_EvaluaciónT1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejercicio1();
            Console.ReadKey();
        }

        static void Ejercicio1()
        {
            //Inicio
            //Declaramos variables
            double Precio_Final= 0, precio_producto, Descuento = 0;
            int codigo;
            bool codigoValido = true;

            //Desarrollo, Ingreso de datos y asignación de variables
            Console.WriteLine("Buen día. Ingrese el precio del producto elegido: ");
            precio_producto = double.Parse(Console.ReadLine());

            Console.WriteLine("Elige un código: ");
            Console.WriteLine("===================");
            Console.WriteLine("[1] - Estudiante");
            Console.WriteLine("[2] - Empleado");
            Console.WriteLine("[3] - Cliente frecuente");
            Console.WriteLine("===================");
            codigo = int.Parse(Console.ReadLine());

            //Selección del descuento
            switch (codigo)
            {
                case 1: //no se pone '' porque es un número
                    Descuento = precio_producto * 0.10;
                    break;

                case 2:
                    Descuento = precio_producto * 0.15;
                    break;

                case 3:
                    Descuento = precio_producto * 0.20;
                    break;

                default:
                    Console.WriteLine("El código ingresado es inválido, no se aplicara descuento. ");
                    codigoValido = false;
                    break;
            }

            //Si el código ingresado es válido, calculamos el precio final

            if (codigoValido) 
            {
                Precio_Final = precio_producto - Descuento;
            }
            
            //Utilizo operador lógico si aplica el descuento adicional

            if (precio_producto > 500 && codigoValido)
            {
                Precio_Final = Precio_Final - (Precio_Final * 0.05);
            }

            //Final
            Console.WriteLine("El precio final del producto es: S/. {0:F2}", Precio_Final);
        }

        static void Ejercicio2()
        {
            //Inicio
            //Declaramos variables
            int nota;
            double raizCuadrada, potenciaCubo;

            //Desarrollo. Ingreso de datos y asignación de variables
            Console.WriteLine("Buen día. Ingrese su nota de (0 - 20): ");
            nota = int.Parse(Console.ReadLine());

            if (nota < 0 || nota > 20)
            {
                Console.WriteLine("Error: La nota ingresada debe estar entre 0 - 20.");
            }

            else
            {
                //Clasificación según la nota
                switch (nota)
                {
                    case int n when (nota >= 0 && nota <= 10): //when permite utilizar condiciones lógicas dentro de un case
                        Console.WriteLine("Su calificación es Desaprobado. ");
                        break;

                    case int n when (nota >= 11 && nota <= 13): //el int n, guarda el valor en una variable temporal
                        Console.WriteLine("Su calificación es Regular. ");
                        break;

                    case int n when (nota >= 14 && nota <= 17):
                        Console.WriteLine("Su calificación es Buena. ");
                        break;

                    case int n when (nota >= 18 && nota <= 20):
                        Console.WriteLine("Su calificación es Excelente. ");
                        break;

                    default:
                        Console.WriteLine("Error inesperado en la clasificación. "); //En este caso podría omitirlo ya que no se utilizaría, pero por buenas prácticas lo dejo.
                        break;

                }

                //Condiciones con operadores lógicos
                if (nota >= 14 && nota % 2 == 0)
                {
                    Console.WriteLine("Buen desempeño con nota par.");
                }

                if (nota % 2 != 0 || nota < 11)
                {
                    Console.WriteLine("Necesita reforzar.");
                }

                //Calculamos la raíz cuadrada y la potencia de la nota al cubo
                raizCuadrada = Math.Sqrt(nota);
                potenciaCubo = Math.Pow(nota,3);

                //Final
                Console.WriteLine("La raíz cuadrada es: {0:F1}", raizCuadrada); //El {0:F1} es utilizado para poner un decimal (F1) y la cantidad (0)
                Console.WriteLine("La potencia al cubo es: {0}", potenciaCubo);
            }
        }
    }
}
