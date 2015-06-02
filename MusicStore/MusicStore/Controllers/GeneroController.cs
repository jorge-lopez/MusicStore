using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogic;
using Modelos;

namespace MusicStore.Controllers
{
    public class GeneroController : Controller
    {
        // GET: Autor
        public ActionResult Index()
        {
            MusicaBLL info = new MusicaBLL();
            return View(info.getCancionesPorGenero());
        }
    }
}