using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Modelos;

namespace BusinessLogic

{
    public class GeneroBLL
    {
        #region Atributos

        //Listado de Generos
        private List<Genero> generos;

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor Vacio
        /// </summary>
        public GeneroBLL()
        {
            generos = new List<Genero>();
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Agregar Nuevo Género
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="nombre">Nombre</param>
        /// <param name="descripcion">Descripción</param>
        public void Agregar(int id, string nombre, string descripcion)
        {
            generos.Add(new Genero(id, nombre, descripcion));
        }

        /// <summary>
        /// Editar Género
        /// </summary>
        /// <param name="id">ID a editar</param>
        /// <param name="nombre">Nombre Nuevo</param>
        /// <param name="descripcion">Descripción nueva</param>
        public void Editar(int id, string nombre, string descripcion)
        {
            Genero g = generos.Where(d => d.Id == id).FirstOrDefault();
            if (g != null) 
            { 
                g.Nombre = nombre;
                g.Descripcion = descripcion;
            }

        }

        /// <summary>
        /// Eliminar Género
        /// </summary>
        /// <param name="id">ID del Género</param>
        /// <returns>bool</returns>
        public bool Eliminar(int id)
        {
            Genero g = generos.Find(x => x.Id == id);
            return generos.Remove(g);
        }

        /// <summary>
        /// Retorna los generos
        /// </summary>
        /// <returns>List</returns>
        public List<Genero> getGeneros()
        {
            return generos;
        } 
             
        /// <summary>
        /// Buscar por Nombre de Género
        /// </summary>
        /// <param name="nombre">Nombre del Género</param>
        /// <returns>Género</returns>
        public Genero Buscar(string nombre)
        {
            return generos.Find(x => x.Nombre == nombre);
        }

        #endregion 
    }
}