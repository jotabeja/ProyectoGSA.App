using System;
namespace ProyectoGSA.App.Dominio.Entidades
{
    public class Periodo
    {
        public int id {get; set;}
        public String nombre {get; set;}
        public String codigo {get; set;}
        public String descripcion {get; set;}
        public date fecha_inicio {get; set;}
        public date fecha_fin {get; set;}
    }
}