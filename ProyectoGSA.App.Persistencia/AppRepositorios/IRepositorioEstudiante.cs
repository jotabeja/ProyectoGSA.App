using System.Collections.Generic;
using ProyectoGSA.App.Dominio.Entidades;

namespace ProyectoGSA.App.Persistencia.AppRepositorios
{
    public interface IRepositorioEstudiante
    {
          //Se define la firma de los metodos que retornan información de la BD
         //1. Obtener en una lista todos loss datos de la clase Estudiante
         IEnumerable<Estudiante> GetAllEstudiantes();
        //2. Retorna una persona para adicionar
        /* Estudiante AddEstudiante(Estudiante estudiante);*/
         //3. Acutalizar una persona UPDATE
         //Estudiante UpdateEstudiante(Estudiante estudiante);
         //4. Borrar una persona
         /*void DeleteEstudiante(int idEstudiante);
         //5. Obtener una persona por el ID
         Estudiante GetEstudiante(int idEstudiante);*/
         
        
         
        Estudiante GetEstudiantePorId(int estudianteId);

        Estudiante UpdateEst(Estudiante estudianteActualizado);

        Estudiante Add(Estudiante nuevoEstudiante);

         //Adicionar otros metodos con otros criterios
    }
}




        

