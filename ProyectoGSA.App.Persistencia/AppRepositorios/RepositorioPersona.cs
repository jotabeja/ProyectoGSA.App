using System.Collections;
using System.Collections.Generic;
using System.Linq;
using ProyectoGSA.App.Dominio.Entidades;

namespace ProyectoGSA.App.Persistencia.AppRepositorios
{

    public class RepositorioPersona : IRepositorioPersona
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
        public RepositorioPersona(AppContext appContext)
        {
            _appContext = appContext;
        }

        Persona IRepositorioPersona.AddPersona(Persona persona)
        {
            var personaAdicionada = _appContext.Personas.Add(persona);
            _appContext.SaveChanges();
            return personaAdicionada.Entity;

        }

        void IRepositorioPersona.DeletePersona(int idPersona)
        {
            var personaEncontrada = _appContext.Personas.FirstOrDefault(p => p.id == idPersona);
            if (personaEncontrada == null)
                return;
            _appContext.Personas.Remove(personaEncontrada);
            _appContext.SaveChanges();
        }

        IEnumerable<Persona> IRepositorioPersona.GetAllPersonas()
        {
            return _appContext.Personas;
        }

        Persona IRepositorioPersona.GetPersona(int idPersona)
        {
            return _appContext.Personas.FirstOrDefault(p => p.id == idPersona);
        }

       Persona IRepositorioPersona.UpdatePersona(Persona persona)
        {
            var personaEncontrada = _appContext.Personas.FirstOrDefault(p => p.id == persona.id);
            if (personaEncontrada != null)
            {
                personaEncontrada.nombres = persona.nombres;
                personaEncontrada.apellidos = persona.apellidos;
                personaEncontrada.identificacion = persona.identificacion;
                personaEncontrada.telefono = persona.telefono;
                personaEncontrada.mail = persona.mail;
                personaEncontrada.direccion = persona.direccion;
                
                

                _appContext.SaveChanges();


            }
            return personaEncontrada;
        }

    }
}
