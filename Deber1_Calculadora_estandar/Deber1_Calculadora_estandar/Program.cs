using System;
using Operacion;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {//acciones a realizar
            
            Console.WriteLine("Que operación desea realizar");
            Console.WriteLine("Para sumar [+]");
            Console.WriteLine("Para restar [-]");
            Console.WriteLine("Para multiplicar [*]");
            Console.WriteLine("Para dividir [/]");
            Console.WriteLine("Para potencia [^]");
            Console.WriteLine("Para raiz [7]");
            Console.Write("Elije una operación: ");

            var opciones = Console.ReadLine();
            //suma
            if (opciones == "+")
            {
                Console.WriteLine("Ingresar el primer número");
                var numero1 = Console.ReadLine();

                Console.WriteLine("Ingresar el segundo número");
                var numero2 = Console.ReadLine();

                var calculadora = new Matematica();

                var resultado = calculadora.Sumar(int.Parse(numero1), int.Parse(numero2));

                Console.WriteLine("La suma de los dos numeros es:   " + resultado);
            }
            //resta
            if (opciones == "-") 
            {
                Console.WriteLine("Ingresar el primer número");
                var numero1 = Console.ReadLine();

                Console.WriteLine("Ingresar el segundo número");
                var numero2 = Console.ReadLine();

                var calculadora = new Matematica();

                var resultado = calculadora.Restar(int.Parse(numero1), int.Parse(numero2));

                Console.WriteLine("La resta de los dos numeros es:   " + resultado);
            }
            //multiplicacion
            if(opciones == "*")
            {
                Console.WriteLine("Ingresar el primer número");
                var numero1 = Console.ReadLine();

                Console.WriteLine("Ingresar el segundo número");
                var numero2 = Console.ReadLine();

                var calculadora = new Matematica();

                var resultado = calculadora.Multiplicar(int.Parse(numero1), int.Parse(numero2));

                Console.WriteLine("La multiplicación de los dos numeros es:   " + resultado);
            }
            //división
            if(opciones == "/")
            {
                Console.WriteLine("Ingresar el primer número");
                var numero1 = Console.ReadLine();

                Console.WriteLine("Ingresar el segundo número");
                var numero2 = Console.ReadLine();

                var calculadora = new Matematica();

                var resultado = calculadora.Dividir(int.Parse(numero1), int.Parse(numero2));

                Console.WriteLine("La división de los dos numeros es:   " + resultado);
            }
            if(opciones == "^")
            {
                Console.WriteLine("Ingresar el primer número");
                var numero1 = Console.ReadLine();
                
                var calculadora = new Matematica();

                var resultado = calculadora.Potencia(int.Parse(numero1));

                Console.WriteLine("La potencia es:   " + resultado);
            }
            //raiz
            if(opciones == "7")
            {
                Console.WriteLine("Ingresar el primer número");
                var numero1 = Console.ReadLine();

                var calculadora = new Matematica();

                var resultado = calculadora.Raiz(int.Parse(numero1));

                Console.WriteLine("La raiz es:   " + resultado);
            }
            Console.WriteLine("¿Deseas Continuar?");
          
            var respuesta = Console.ReadLine();
           
            Console.Clear();
        }
    }
}
