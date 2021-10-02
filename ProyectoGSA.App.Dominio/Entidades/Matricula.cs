using System;
namespace ProyectoGSA.App.Dominio.Entidades
{
    public class Matricula
    {
        public int id {get; set;}
        public date fecha {get; set;}
        public String creador {get; set;}
        public Estudiante estudiante {get; set;}
        public Grupo grupo {get; set;}
        public Grado grado {get; set;}
    }
    }
}