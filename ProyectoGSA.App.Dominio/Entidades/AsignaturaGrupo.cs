using System;
namespace ProyectoGSA.App.Dominio.Entidades
{
    public class AsignaturaGrupo
    {
        public int id {get; set;}
        public String descripcion {get; set;}
        public Asignatura asignatura {get; set;}
        public Docente docente {get; set;}
        public Grupo grupo {get; set;}
    }
}