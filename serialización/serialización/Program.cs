using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace serialización
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Usuario usuario = new Usuario();

            
            IFormatter formatter = new BinaryFormatter();
            List<Person> persons = new List<Person>();
            Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);

            Console.WriteLine("Seleecione que opción desea realizar");
            Console.WriteLine("(1) crear persona");
            Console.WriteLine("(2) ver personas");
            Console.WriteLine("(3) cargar personas");
            Console.WriteLine("(4) Salir del programa");
            string input_usuario = Console.ReadLine();
            while (input_usuario == "1" || input_usuario == "2" || input_usuario == "3" || input_usuario == "4")
            {
                if (input_usuario == "1")
                {
                    Console.WriteLine("Indique el nombre de la persona");
                    string n_nombre;
                    n_nombre = Console.ReadLine();
                    Console.WriteLine("Indique el apellido nombre de la persona");
                    string n_apellido;
                    n_apellido = Console.ReadLine();
                    Console.WriteLine("Indique la edad de la persona");
                    string n_age;
                    n_age = Console.ReadLine();
                    usuario.CrearPersona(n_nombre, n_apellido, n_age);
                }
                else if (input_usuario == "2")
                {
                    usuario.Ver_Personas();

                }
                else if (input_usuario == "3")
                {
                    formatter.Serialize(stream, persons);
                    stream.Close();

                }
                else if (input_usuario == "4")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("El criterio ingresado no es válido");
                }
                Console.WriteLine("Seleecione que opción desea realizar");
                Console.WriteLine("(1) crear persona");
                Console.WriteLine("(2) ver personas");
                Console.WriteLine("(3) cargar personas");
                Console.WriteLine("(4) Salir del programa");
                input_usuario = Console.ReadLine();


            }
            Console.WriteLine("El criterio ingresado no es válido");
            Console.WriteLine("Seleecione que opción desea realizar");
            Console.WriteLine("(1) crear persona");
            Console.WriteLine("(2) ver personas");
            Console.WriteLine("(3) cargar personas");
            Console.WriteLine("(4) Salir del programa");
            input_usuario = Console.ReadLine();
        }
    }
}
