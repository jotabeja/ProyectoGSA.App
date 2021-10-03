using System;
using ProyectoGSA.App.Dominio.Entidades;


namespace ProyectoGSA.App.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancia de Objeto Persona
            Persona persona1 = new Persona();
            persona1.nombres = "Andres";
            persona1.apellidos = "Villamil";
            persona1.identificacion = "79963858";
            persona1.telefono = "3112833341";
            Console.WriteLine("Hello World!");
            Console.WriteLine("Nombre: {0} Apellido: {1} Identificación: {2} Telefono: {3}", 
            persona1.nombres, persona1.apellidos,persona1.identificacion, persona1.telefono);

            //Instancia de Objeto Estudiante
            Estudiante estudiante = new Estudiante();
            
            estudiante.nombres = "Andres";
            
            Console.WriteLine("Instacia Estudiante "
                + estudiante.nombres);




        }
    }
}
