using System;
namespace ProyectoGSA.App.Dominio.Entidades
{
    public class Asignatura
    {
        public int id {get; set;}
        public String nombre {get; set;}
        public String descripcion {get; set;}
        public Area area {get; set;}
        public Grado grado {get; set;}
    }
}