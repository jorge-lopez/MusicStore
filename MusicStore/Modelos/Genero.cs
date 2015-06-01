using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelos
{
    public class Genero
    {

        #region Propiedades

        /// <summary>
        /// ID del Género
        /// </summary>
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// Nombre del Género
        /// </summary>
        public string Nombre
        {
            get;
            set;
        }

        /// <summary>
        /// Descripción del Género
        /// </summary>
        public string Descripcion
        {
            get;
            set;
        }

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor vacio
        /// </summary>
        public Genero() { }

        /// <summary>
        /// Constructor de la clase Género
        /// </summary>
        /// <param name="id">ID del Género</param>
        /// <param name="nombre">Nombre del Género</param>
        /// <param name="desripcion">Descripción del Género</param>
        public Genero(int id, string nombre, string desripcion)
        {
            Id = id;
            Nombre = nombre;
            Descripcion = desripcion;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// ToString de la Clase
        /// </summary>
        /// <returns>Nombre del Genero</returns>
        public override string ToString()
        {
            return Nombre;
        }

        #endregion
    }
}