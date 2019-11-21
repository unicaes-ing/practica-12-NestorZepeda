using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace practica12
{
    class Class1
    {
        public void mostrar()
        {
            try
            {
                ingresar.Mascota mas;
                FileStream fs;
                BinaryFormatter formatter = new BinaryFormatter();
                const string name = "mascotas.bin";
                if (File.Exists(name))
                {
                    fs = new FileStream(name, FileMode.Open, FileAccess.Read);
                    mas = (ingresar.Mascota)formatter.Deserialize(fs);
                    fs.Close();
                    Console.WriteLine("Datos de la mascota");
                    Console.WriteLine("NOmbre: " + mas.nombre);
                    Console.WriteLine("Especie: " + mas.especie);
                    Console.WriteLine("Raza: " + mas.raza);
                    Console.WriteLine("Sexo: " + mas.sexo);
                    Console.WriteLine("Edad: " + mas.edad);
                    Console.WriteLine();
                    Console.WriteLine("Presione cualquier tecla para continuar");

                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }


            Console.ReadKey();
        }
    }

}
