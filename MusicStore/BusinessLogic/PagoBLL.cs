using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Modelos;
using VariablesTemp;

namespace BusinessLogic
{
    public class PagoBLL
    {
       #region Atributos

        //Listado de Compras
        private List<Pago> pagos;

        #endregion

        #region Constructores
        
        /// <summary>
        /// Constructor Vacio
        /// </summary>
        public PagoBLL()
        {
            pagos = DummyRepo.pagos;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Agregar Pago
        /// </summary>
        /// <param name="id">ID del Pago</param>
        /// <param name="fechaCompra">Fecha de la Compra</param>
        /// <param name="carrito">Carrito</param>
        public void Agregar(int id, DateTime fechaCompra, List<Musica> carrito)
        {
            pagos.Add(new Pago(id, fechaCompra, carrito));
        }

        /// <summary>
        /// Retorna los Pagos realizados
        /// </summary>
        /// <returns>List</returns>
        public List<Pago> getPagos()
        {
            return pagos;
        } 

        #endregion 
    }
}