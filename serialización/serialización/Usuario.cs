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
    public class Usuario
    {
        private List<Person> persons = new List<Person>();
        public bool CrearPersona(string nombre, string apellido, string age)
        {
            Person person = new Person(nombre,apellido,age);
            for (int i = 0; i < persons.Count; i++)
            {
                if (person.Ver_Persona() == persons[i].Ver_Persona())
                {
                    Console.WriteLine("Este empleado ya existe");
                    return false;
                }
                else
                {
                    continue;
                }
            }
            persons.Add(person);
            Console.WriteLine("Persona ha sido creada");
            return true;
        }
        public void Ver_Personas()
        {
            Console.WriteLine("Personas:");
            for (int i = 0; i < persons.Count; i++)
            {
                Console.WriteLine(persons[i].Ver_Persona());
            }
        }

    
    }
}
