using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Modelos;

namespace BusinessLogic
{
    public class CarritoBLL
    {
        #region Atributos

        //Carrito de compras
        private List<Carrito> carrito;

        #endregion

        #region Constructores
        
        /// <summary>
        /// Constructor Vacio
        /// </summary>
        public CarritoBLL()
        {
            carrito = new List<Carrito>();
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Agregar Nuevo Carrito
        /// </summary>
        /// <param name="musica">Música</param>
        /// <param name="cantidad">Cantidad</param>
        public void AgregarProducto(Musica musica, int cantidad)
        {
            carrito.Add(new Carrito(musica, cantidad));
        }

        /// <summary>
        /// Eliminar Producto del Carrito
        /// </summary>
        /// <param name="id">ID del Producto</param>
        /// <returns>bool</returns>
        public bool Eliminar(int id)
        {
            Carrito c = carrito.Find(x => x.Musica.Id == id);
            return carrito.Remove(c);
        }

        /// <summary>
        /// Retorna los Productos del Carrito
        /// </summary>
        /// <returns>List</returns>
        public List<Carrito> getCarrito()
        {
            return carrito;
        } 

        #endregion 
    }
}