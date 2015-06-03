using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Modelos;
using BusinessLogic;

namespace MusicStore.Controllers
{
    public class PagoController : Controller
    {
        // GET: Pago
        public ActionResult Index()
        {
            PagoBLL pago = new PagoBLL();

            return View(pago.getPagos());
        }
        public ActionResult Pago()
        {
            Random r = new Random();
            PagoBLL pago = new PagoBLL();
            CarritoBLL carrito = new CarritoBLL();

            pago.Agregar(r.Next(1000, 9999), DateTime.Today, carrito.getCarrito());
            carrito.EliminarTodo();
            return RedirectToAction("Index");
        }
    }
}