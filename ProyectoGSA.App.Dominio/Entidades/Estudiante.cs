using System;
namespace ProyectoGSA.App.Dominio.Entidades
{
    public class Estudiante 
    {
        public Estudiante(int id,  string nombres, string nacimiento, Persona padre, Persona madre)
        {
            this.id = id;
            this.nombres = nombres;
            this.nacimiento = nacimiento;
            this.padre = padre;
            this.madre = madre;

        }
        public Estudiante()
        {

        }
        
        public int id { get; set; }
        public string nombres { set; get; }
        public string apellidos { set; get; }
        public string identificacion { set; get; }
        public string telefono { set; get; }
        public string mail { set; get; }
        public string direccion { set; get; }
        public string nacimiento { get; set; }
        public Persona padre { get; set; }
        public Persona madre { get; set; }
    }



}