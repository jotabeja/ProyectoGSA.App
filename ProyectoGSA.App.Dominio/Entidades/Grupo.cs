using System;
namespace ProyectoGSA.App.Dominio.Entidades
{
    public class Grupo
    {
        public int id {get; set;}
        public String nombre {get; set;}
        public String descripcion {get; set;}
        public Docente director {get; set;}
    }
}
