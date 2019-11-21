using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace practica12
{
    class ingresar
    {
       
  
            [Serializable]
            public struct Mascota
            {
                public string nombre, especie, raza, sexo;
                public int edad;


            }
            public void datosmascota()
            {
                Mascota mas = new Mascota();
                FileStream fs;
                BinaryFormatter formatter = new BinaryFormatter();
                const string name = "mascotas.bin";
                try
                {
                    Console.WriteLine("Datos de la mascota");
                    Console.WriteLine();
                    Console.Write("Nombre: ");
                    mas.nombre = Console.ReadLine();
                    Console.Write("Especie: ");
                    mas.especie = Console.ReadLine();
                    Console.Write("Raza: ");
                    mas.raza = Console.ReadLine();
                    Console.Write("Sexo: ");
                    mas.sexo = Console.ReadLine();
                    Console.Write("Edad: ");
                    mas.edad = Convert.ToInt32(Console.ReadLine());
                    fs = new FileStream(name, FileMode.Create, FileAccess.Write);
                    formatter.Serialize(fs, mas);
                    fs.Close();
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Los datos de la mascota fueron almacenados correctamente");
                }
                catch (Exception e)
                {

                    Console.WriteLine(e.Message);
                }
                Console.ReadKey();
            }
        }
}
