using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Modelos;
using BusinessLogic;

namespace MusicStore.Controllers
{
    public class MusicaController : Controller
    {
        // GET: Musica
        public ActionResult Index()
        {
            MusicaBLL info = new MusicaBLL();
            return View(info.getCanciones());
        }
    }
}