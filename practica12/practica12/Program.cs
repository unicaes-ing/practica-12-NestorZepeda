using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica12
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            try
            {
                do
                {
                    Console.WriteLine();
                    Console.WriteLine("ejercicio 1");
                    Console.WriteLine("Ejercicio 2");
                    Console.WriteLine("Ejercicio 3");
                    Console.WriteLine("Salir 4");
                    op = Convert.ToInt32(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            ingresar mas = new ingresar();
                            mas.datosmascota();
                            break;
                        case 2:
                            Class1 mostrar = new Class1();
                            mostrar.mostrar();
                            break;
                        case 3:
                            ejercicio3 ejer3 = new ejercicio3();
                            ejer3.ejer3();
                            break;
                        default:
                            break;
                    }
                } while (op != 3);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
           
        }
    }
}
