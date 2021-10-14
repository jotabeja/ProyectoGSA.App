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
    public class EditEstudiantesModel : PageModel
    {
        private readonly IRepositorioEstudiante repositorioEstudiante;
        [BindProperty]
        public Estudiante Estudiante{get; set;}

       public EditEstudiantesModel(IRepositorioEstudiante repositorioEstudiante)
       {
           this.repositorioEstudiante = repositorioEstudiante;
       }

        
         
          public IActionResult OnGet(int? estudianteId)
        {
            if(estudianteId.HasValue)
            {
                Estudiante = repositorioEstudiante.GetEstudiantePorId(estudianteId.Value);
            }
            else
            {
                Estudiante = new Estudiante();
            }
            if(Estudiante==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
                return Page();
        }

        public IActionResult OnPost()
        {
            if(Estudiante.id > 0)
            {
                Estudiante = repositorioEstudiante.UpdateEst(Estudiante);
            }
            else
            {
                repositorioEstudiante.Add(Estudiante);
            }            
            return Page();
        }
    }
}

