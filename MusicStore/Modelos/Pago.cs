using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Modelos
{
    public class Pago
    {

        #region Propiedades

        /// <summary>
        /// ID de la Compra
        /// </summary>
        public int Id
        {
            get;
            set;
        }

        /// <summary>
        /// Fecha de la Compra
        /// </summary>
        public DateTime FechaCompra
        {
            get;
            set;
        }

        /// <summary>
        /// Carrito de compras
        /// </summary>
        public List<Musica> Carrito
        {
            get;
            set;
        }

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor vacio
        /// </summary>
        public Pago() { }

        /// <summary>
        /// Constructor de la Clase Carrito
        /// </summary>
        /// <param name="id">ID del Pago</param>
        /// <param name="fechaCompra">Fecha de la compra</param>
        /// <param name="carrito">Carrito de compras</param>
        public Pago(int id, DateTime fechaCompra, List<Musica> carrito)
        {
            Id = id;
            FechaCompra = fechaCompra;
            Carrito = carrito;
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