using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ProyectoGSA.App.Dominio.Entidades;

namespace ProyectoGSA.App.Persistencia.AppRepositorios
{

    public class RepositorioEstudianteMemoria : IRepositorioEstudiante
    {
       

        List<Estudiante> estudiantes;

        public RepositorioEstudianteMemoria()
        {
            estudiantes = new List<Estudiante>()
            {
                new Estudiante{id=1, nombres="Andrés", apellidos="Villamil", telefono="3112833341",direccion="Calle 79 106 22"},
                new Estudiante{id=2, nombres="Diana", apellidos="Pachón", telefono="3102833341",direccion="Calle 79 106 22"},
                new Estudiante{id=3, nombres="Martha", apellidos="Gómez", telefono="3202833341",direccion="Calle 79 106 22"},
            };

            
        }

       

        IEnumerable<Estudiante> IRepositorioEstudiante.GetAllEstudiantes()
        {
            return estudiantes;
        }

       
         
        public Estudiante GetEstudiantePorId(int estudianteId)
         {
             return estudiantes.SingleOrDefault(e => e.id==estudianteId);
         }

        public Estudiante UpdateEst(Estudiante estudianteActualizado)
        {
            var estudiante = estudiantes.SingleOrDefault(r => r.id==estudianteActualizado.id);
            if(estudiante != null)
            {
                estudiante.nombres = estudianteActualizado.nombres;
                estudiante.apellidos = estudianteActualizado.apellidos;
                estudiante.telefono = estudianteActualizado.telefono;
                estudiante.direccion = estudianteActualizado.direccion;
            }
            return estudiante;
        }
        public Estudiante Add(Estudiante nuevoEstudiante)
        {
            nuevoEstudiante.id=estudiantes.Max(r => r.id) +1;
            estudiantes.Add(nuevoEstudiante);
            return nuevoEstudiante;
        }


    }
}