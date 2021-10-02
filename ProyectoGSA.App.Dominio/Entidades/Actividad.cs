using System;
namespace ProyectoGSA.App.Dominio.Entidades
{
    public class Actividad
    {
        public int id {get; set;}
        public String nombre {get; set;}
        public String descripcion {get; set;}
        public boolean asitencia {get; set;}
        public date fecha_inicio {get; set;}
        public date fecha_fin {get; set;}
        public Competencia competencia {get; set;}
        public Periodo periodo {get; set;}
    }
}