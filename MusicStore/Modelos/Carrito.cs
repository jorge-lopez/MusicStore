using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelos
{
    public class Carrito
    {

        #region Propiedades

        /// <summary>
        /// Música
        /// </summary>
        public Musica Musica
        {
            get;
            set;
        }

        /// <summary>
        /// Cantidad
        /// </summary>
        public int Cantidad
        {
            get;
            set;
        }

        #endregion

        #region Constructores
        
        /// <summary>
        /// Constructor vacio
        /// </summary>
        public Carrito() { }

        /// <summary>
        /// Constructor de la Clase Carrito
        /// </summary>
        /// <param name="canciones">Música</param>
        /// <param name="cantidad">Cantidad</param>
        public Carrito(Musica canciones, int cantidad)
        {
            Musica = canciones;
            Cantidad = cantidad;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// ToString de la Clase
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString();
        }

        #endregion
    }
}