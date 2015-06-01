using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelos
{
    public class Autor
    {

        #region Propiedades

        /// <summary>
        /// ID del Autor
        /// </summary>
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// Nombre del Autor
        /// </summary>
        public string Nombre
        {
            get;
            set;
        }

        /// <summary>
        /// Apellido Paterno del Autor
        /// </summary>
        public string ApPaterno
        {
            get;
            set;
        }

        /// <summary>
        /// Apellido Materno del Autor
        /// </summary>
        public string ApMaterno
        {
            get;
            set;
        }

        /// <summary>
        /// Nombre completo del Autor
        /// </summary>
        public string NombreCompleto
        {
            get { return Nombre + " " + ApPaterno + " " + ApMaterno; }
        }

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor vacio
        /// </summary>
        public Autor() { }

        /// <summary>
        /// Contructor de la clase Autor
        /// </summary>
        /// <param name="id">ID del Autor</param>
        /// <param name="nombre">Nombre del Autor</param>
        /// <param name="apPaterno">Apellido Paterno del Autor</param>
        /// <param name="apMaterno">Apellido Materno del Autor</param>
        public Autor(int id, string nombre, string apPaterno, string apMaterno)
        {
            Id = id;
            Nombre = nombre;
            ApPaterno = apPaterno;
            ApMaterno = apMaterno;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// ToString de la Clase
        /// </summary>
        /// <returns>Nombre del Autor</returns>
        public override string ToString()
        {
            return Nombre;
        }

        #endregion
    }
}