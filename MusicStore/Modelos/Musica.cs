using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelos
{
    public class Musica
    {

        #region Propiedades

        /// <summary>
        /// ID de la Música
        /// </summary>
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// Nombre de la Música
        /// </summary>
        public string Nombre
        {
            get;
            set;
        }

        /// <summary>
        /// Autor de la Música
        /// </summary>
        public Autor Autor
        {
            get; 
            set;
        }

        /// <summary>
        /// Género de la Música
        /// </summary>
        public Genero Genero
        {
            get;
            set;
        }

        /// <summary>
        /// Precio de la Música
        /// </summary>
        public double Precio
        {
            get;
            set;
        }

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor vacio
        /// </summary>
        public Musica() { }

        /// <summary>
        /// Contructor de la Clase Música
        /// </summary>
        /// <param name="id">ID de la Música</param>
        /// <param name="nombre">Nombre de la Música</param>
        /// <param name="autor">Autor de la Música</param>
        /// <param name="genero">Género de la Música</param>
        /// <param name="precio">Precio de la Música</param>
        public Musica(int id, string nombre, Autor autor, Genero genero, double precio)
        {
            Id = id;
            Nombre = nombre;
            Autor = autor;
            Genero = genero;
            Precio = precio;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// ToString de la Clase
        /// </summary>
        /// <returns>Nombre de la Música</returns>
        public override string ToString()
        {
            return Nombre;
        }

        #endregion
    }
}