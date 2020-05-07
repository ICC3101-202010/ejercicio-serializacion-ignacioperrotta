using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace serialización
{
    public class Person
    {
        private string nombre;
        private string apellido;
        private string age;
        public Person(string nombre, string apellido, string age)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Age = age;
        }
        public string Age
        {

            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = value;
            }
        }
        private List<Person> persons = new List<Person>();
        public string Ver_Persona()
        {
            return " Age: " + this.Age + ",  Nombre: " + this.Nombre + ",  Apellido: " + this.Apellido;
        }


       



    }
}