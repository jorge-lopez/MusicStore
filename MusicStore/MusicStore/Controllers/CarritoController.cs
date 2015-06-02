using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Modelos;
using BusinessLogic;

namespace MusicStore.Controllers
{
    public class CarritoController : Controller
    {
        CarritoBLL carrito = new CarritoBLL();

        public ActionResult Index()
        {          
            return View(carrito.getCarrito());
        }

        public ActionResult AgregarCarrito(int Id)
        {    
            carrito.AgregarProducto(Id);            
            return RedirectToAction("Index");            
        }
        public ActionResult RemoverDeCarrito(int Id)
        {
            carrito.Eliminar(Id);
            return RedirectToAction("Index");
        }
       
    }
}