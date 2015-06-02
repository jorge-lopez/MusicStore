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
        public List<Musica> Musica
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
        public Carrito(List<Musica> cancion)
        {
            Musica = cancion;
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Agregar a Carrito
        /// </summary>
        /// <param name="cancion"></param>
        public void Agregar(Musica cancion)
        {
            Musica.Add(cancion);
        }

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