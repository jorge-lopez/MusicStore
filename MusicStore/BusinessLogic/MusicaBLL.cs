using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Modelos;
using VariablesTemp;

namespace BusinessLogic
{
    public class MusicaBLL
    {
        #region Atributos

        //Listado de Música
        private List<Musica> canciones;

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor Vacio
        /// </summary>
        public MusicaBLL()
        {
            canciones = DummyRepo.musica;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Agregar nueva Música
        /// </summary>
        /// <param name="id">ID</param>
        /// <param name="nombre">Nombre</param>
        /// <param name="autor">Autor</param>
        /// <param name="genero">Género</param>
        /// <param name="precio">Precio</param>
        public void Agregar(int id, string nombre, Autor autor, Genero genero, double precio)
        {
            canciones.Add(new Musica(id, nombre, autor, genero, precio));
        }

        /// <summary>
        /// Editar Musica
        /// </summary>
        /// <param name="id">ID a Editar</param>
        /// <param name="nombre">Nombre Nuevo</param>
        /// <param name="autor">Autor Nuevo</param>
        /// <param name="genero">Género Nuevo</param>
        /// <param name="precio">Precio Nuevo</param>
        public void Editar(int id, string nombre, Autor autor, Genero genero, double precio)
        {
            Musica m = canciones.Where(d => d.Id == id).FirstOrDefault();
            if (m != null)
            {
                m.Nombre = nombre;
                m.Autor = autor;
                m.Genero = genero;
                m.Precio = precio;
            }

        }

        /// <summary>
        /// Eliminar Música
        /// </summary>
        /// <param name="id">ID de la Música</param>
        /// <returns>bool</returns>
        public bool Eliminar(int id)
        {
            Musica m = canciones.Find(x => x.Id == id);
            return canciones.Remove(m);
        }

        /// <summary>
        /// Buscar por Nombre de la Música
        /// </summary>
        /// <param name="nombre">Nombre de la Música</param>
        /// <returns>Música</returns>
        public Musica Buscar(string nombre)
        {
            return canciones.Find(x => x.Nombre == nombre);
        }

        /// <summary>
        /// Retorna las canciones
        /// </summary>
        /// <returns>List</returns>
        public List<Musica> getCanciones()
        {
            return canciones.OrderBy(x => x.Nombre).ToList();
        }
        public List<Musica> getCancionesPorAutor()
        {
            return canciones.OrderBy(x => x.Autor.Nombre).ToList();
        }
        public List<Musica> getCancionesPorGenero()
        {
            return canciones.OrderBy(x => x.Genero.Nombre).ToList();
        }


        #endregion 
    }
}