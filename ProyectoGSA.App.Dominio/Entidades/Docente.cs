using System;
namespace ProyectoGSA.App.Dominio.Entidades
{
    public class Docente
    {
        public int id {get; set;}
        public String nombres {set; get;}
        public String apellidos {set; get;}
        public String identificacion {set; get;}
        public String telefono {set; get;}
        public String mail {set; get;}
        public String direccion {set; get;}
        public String profesion {get; set;}
        public Double salario {get; set;}
    }
}