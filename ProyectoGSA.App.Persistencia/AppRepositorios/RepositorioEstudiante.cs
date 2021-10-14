using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ProyectoGSA.App.Dominio.Entidades;

namespace ProyectoGSA.App.Persistencia.AppRepositorios
{

    public class RepositorioEstudiante : IRepositorioEstudiante
    {
        /// <summary>
        /// Referencia al contexto de Paciente
        /// </summary>
        private readonly AppContext _appContext;
        /// <summary>
        /// Metodo Constructor Utiiza 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        /// </summary>
        /// <param name="appContext"></param>//
        public RepositorioEstudiante(AppContext appContext)
        {
            _appContext = appContext;
        }

        /*
        Estudiante IRepositorioEstudiante.AddEstudiante(Estudiante estudiante)
        {
            var estudianteAdicionado = _appContext.Estudiantes.Add(estudiante);
            _appContext.SaveChanges();
            return estudianteAdicionado.Entity;

        }

        void IRepositorioEstudiante.DeleteEstudiante(int idEstudiante)
        {
            var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(p => p.id == idEstudiante);
            if (estudianteEncontrado == null)
                return;
            _appContext.Estudiantes.Remove(estudianteEncontrado);
            _appContext.SaveChanges();
        }*/

        IEnumerable<Estudiante> IRepositorioEstudiante.GetAllEstudiantes()
        {
            return _appContext.Estudiantes;
        }

/*        Estudiante IRepositorioEstudiante.GetEstudiante(int idEstudiante)
        {
            return _appContext.Estudiantes.FirstOrDefault(p => p.id == idEstudiante);
        }

       Estudiante IRepositorioEstudiante.UpdateEstudiante(Estudiante estudiante)
        {
            var estudianteEncontrado = _appContext.Estudiantes.FirstOrDefault(p => p.id == estudiante.id);
            if (estudianteEncontrado != null)
            {
                estudianteEncontrado.nombres = estudiante.nombres;
                estudianteEncontrado.apellidos = estudiante.apellidos;
                estudianteEncontrado.identificacion = estudiante.identificacion;
                estudianteEncontrado.telefono = estudiante.telefono;
                estudianteEncontrado.mail = estudiante.mail;
                estudianteEncontrado.direccion = estudiante.direccion;
                
                

                _appContext.SaveChanges();


            }
            return estudianteEncontrado;
        }*/

        List<Estudiante> estudiantes;

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
