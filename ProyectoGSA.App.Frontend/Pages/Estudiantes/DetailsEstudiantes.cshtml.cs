using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoGSA.App.Dominio;
using ProyectoGSA.App.Dominio.Entidades;
using ProyectoGSA.App.Persistencia.AppRepositorios;

namespace ProyectoGSA.App.Frontend.Pages
{
    public class DetailsEstudiantesModel : PageModel
    {
       private readonly IRepositorioEstudiante repositorioEstudiante;

       public Estudiante Estudiante{get; set;}

       public DetailsEstudiantesModel(IRepositorioEstudiante repositorioEstudiante)
       {
           this.repositorioEstudiante = repositorioEstudiante;
       }
        public IActionResult OnGet(int estudianteId)
        {
            Estudiante = repositorioEstudiante.GetEstudiantePorId(estudianteId);
            if(Estudiante==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }
    }
}
