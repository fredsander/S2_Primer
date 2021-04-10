using System;
using System.Collections.Generic;
using System.Linq;

namespace S2_MiPrimerProyecto
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombreCurso = "Desarrollo de Aplicaciones Web2021-1";
            int edad = 20;
            double monto = 350.50;
            string salario = "Mil dolares";

            var nuevaEdad = 25;

            string detalleEdad = String.Empty;


            List<Persona> listado = new List<Persona>();

            Persona per1 = new Persona();
            per1.dni = "123456";
            per1.nombreCompleto = "Jefferson Farfan";
            per1.telefono = 99558866;

            Persona per2 = new Persona("7778888889", "Paolo Guerrero", 955522333);

            listado.Add(per1);
            listado.Add(per2);
            listado.Add(new Persona("85566666", "Raul Ruidiaz", 23366665));

            detalleEdad = edad > 17 ? "Es mayor de edad" : "Es menor de edad";
            //if (edad>17)
            //{
            //    detalleEdad = "Es mayo de edad";
            //}
            //else
            //{
            //    detalleEdad = "Es menor de edad";
            //}

            //Para recorrer un listado

            foreach (var item in listado)
            {
                Console.WriteLine(item.dni + " " + item.nombreCompleto + " " + item.telefono);
            }

            //consulta a los objetos
            var busqueda = listado.Where(x => x.dni == "99558866").FirstOrDefault();

           

            Console.WriteLine("Hello World!");
        }
    }
}