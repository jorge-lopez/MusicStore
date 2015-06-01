using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MusicStore.Models;

namespace MusicStore.BLL
{
    public class AutorBLL
    {
        #region Atributos

        //Listado de Autores
        private List<Autor> autores;

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor Vacio
        /// </summary>
        public AutorBLL()
        {
            autores = new List<Autor>();
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Agregar nuevo Autor
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="nombre">Nombre</param>
        /// <param name="apPaterno">Apellido Paterno</param>
        /// <param name="apMaterno">Apellido Materno</param>
        public void Agregar(int id, string nombre, string apPaterno, string apMaterno)
        {
            autores.Add(new Autor(id, nombre, apPaterno, apMaterno));
        }

        /// <summary>
        /// Editar Autor
        /// </summary>
        /// <param name="id">ID a Editar</param>
        /// <param name="nombre">Nombre Nuevo</param>
        /// <param name="apPaterno">Apellido Paterno Nuevo</param>
        /// <param name="apMaterno">Apellido Materno Nuevo</param>
        public void Editar(int id, string nombre, string apPaterno, string apMaterno)
        {
            Autor a = autores.Where(d => d.Id == id).FirstOrDefault();
            if (a != null)
            {
                a.Nombre = nombre;
                a.ApPaterno = apPaterno;
                a.ApMaterno = apMaterno;
            }

        }

        /// <summary>
        /// Eliminar Autor
        /// </summary>
        /// <param name="id">ID del Autor</param>
        /// <returns>bool</returns>
        public bool Eliminar(int id)
        {
            Autor a = autores.Find(x => x.Id == id);
            return autores.Remove(a);
        }

        /// <summary>
        /// Buscar por Nombre de Autor
        /// </summary>
        /// <param name="nombre">Nombre del Autor</param>
        /// <returns>Autor</returns>
        public Autor Buscar(string nombre)
        {
            return autores.Find(x => x.Nombre == nombre);
        }

        /// <summary>
        /// Retorna los autores
        /// </summary>
        /// <returns>List</returns>
        public List<Autor> getAutores()
        {
            return autores;
        }


        #endregion 

    }
}