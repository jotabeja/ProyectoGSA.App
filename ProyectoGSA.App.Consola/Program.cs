using System.Net.Mail;
using System;
using ProyectoGSA.App.Dominio.Entidades;
using ProyectoGSA.App.Persistencia.AppRepositorios;
using System.Collections.Generic;



namespace ProyectoGSA.App.Consola
{

        class Program
    {
        //Crear una referencia a la Interfaz del Repositorio Persona
        public static IRepositorioEstudiante _repositorioEstudiante = new RepositorioEstudiante(new Persistencia.AppContext());

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! EF");
            //Para que inserte en la BD se incluye en el Main
            //AddEstudiante();
            //Busca un estudainte por ID
            BuscarEstudiante(2);
        }
        //Crear metodos de acceso a la aplicacion
        //Este metodo inserta un registro en la BD
        private static void AddEstudiante()
        {
            var estudiante = new Estudiante{
                nombres = "Diana",
                apellidos = "Pachon",
                identificacion = "5245621",
                telefono = "3115282",
                mail = "diana@gmail.com",
                direccion = "Calle 100 No. 76 - 30",
                nacimiento = "1986-08-11"

            };
            _repositorioEstudiante.AddEstudiante(estudiante);

        }
            //Este método busca un Estudiante por el ID
            private static void BuscarEstudiante(int idEstudiante)
            {
                var estudiante = _repositorioEstudiante.GetEstudiante(idEstudiante);
                Console.WriteLine(estudiante.nombres + " " + estudiante.apellidos);

            }

    }
}
