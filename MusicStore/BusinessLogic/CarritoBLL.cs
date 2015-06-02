using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VariablesTemp;
using Modelos;

namespace BusinessLogic
{
    public class CarritoBLL
    {
        #region Atributos

        //Carrito de compras
        private List<Musica> carrito;
        

        #endregion

        #region Constructores
        
        /// <summary>
        /// Constructor Vacio
        /// </summary>
        public CarritoBLL()
        {
            carrito = DummyRepo.carrito;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Agregar Nuevo Carrito
        /// </summary>
        /// <param name="musica">Música</param>
        /// <param name="cantidad">Cantidad</param>
        public void AgregarProducto(Musica musica)
        {
            carrito.Add(musica);
        }
        public void AgregarProducto(int musicaId)
        {            
            carrito.Add(DummyRepo.musica.Find(x => x.Id == musicaId));
        }

        /// <summary>
        /// Eliminar Producto del Carrito
        /// </summary>
        /// <param name="id">ID del Producto</param>
        /// <returns>bool</returns>
        public bool Eliminar(int id)
        {           
            Musica c = carrito.Find(x => x.Id == id);
            return carrito.Remove(c);
        }

        /// <summary>
        /// Retorna los Productos del Carrito
        /// </summary>
        /// <returns>List</returns>
        public List<Musica> getCarrito()
        {
            return carrito;
        } 

        #endregion 
    }
}