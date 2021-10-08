using System.Collections.Generic;
using ProyectoGSA.App.Dominio.Entidades;

namespace ProyectoGSA.App.Persistencia.AppRepositorios
{
    public interface IRepositorioPersona
    {
         //Se define la firma de los metodos que retornan información de la BD
         //1. Obtener en una lista todos loss datos de la clase Persona
         IEnumerable<Persona> GetAllPersonas();
        //2. Retorna una persona para adicionar
         Persona AddPersona(Persona persona);
         //3. Acutalizar una persona UPDATE
         Persona UpdatePersona(Persona persona);
         //4. Borrar una persona
         void DeletePersona(int idPersona);
         //5. Obtener una persona por el ID
         Persona GetPersona(int idPersona);
         
         //Adicionar otros metodos con otros criterios

    }
}