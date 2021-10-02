using System;
namespace ProyectoGSA.App.Dominio.Entidades
{
    public class Competencias
    {
        public int id {get; set;}
        public String nombre {get; set;}
        public String descripcion {get; set;}
        public AsignaturaGrupo asignatura {get; set;}
    }
}