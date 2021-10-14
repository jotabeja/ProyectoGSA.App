using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoGSA.App.Dominio;
using ProyectoGSA.App.Dominio.Entidades;
using ProyectoGSA.App.Persistencia.AppRepositorios;

namespace ProyectoGSA.App.Frontend
{
    public class ListEstudiantesModel : PageModel
    {
        private readonly IRepositorioEstudiante repositorioEstudiante;
        public IEnumerable<Estudiante> estudiantes{get;set;}
        public ListEstudiantesModel(IRepositorioEstudiante repositorioEstudiante)
        {
           /* estudiantes = new List<Estudiante>()
            {
                new Estudiante{id=1, nombres="Andrés", apellidos="Villamil"},
                new Estudiante{id=2, nombres="Diana", apellidos="Pachón"},
                new Estudiante{id=3, nombres="Martha", apellidos="Gómez"},
            };*/
            this.repositorioEstudiante = repositorioEstudiante;
        }
        /*public void OnGet(int estudianteId)*/
        public void OnGet()
        {
            estudiantes=repositorioEstudiante.GetAllEstudiantes();
        }
    }
}
