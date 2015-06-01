using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Modelos;
using BusinessLogic;
using VariablesTemp;

namespace MusicStore.Controllers
{
    public class MusicaController : Controller
    {
        // GET: Musica
        public ActionResult Index()
        {
            CrearTemp.Inicializar();

            return View(MusicaTemp.getMusica());
        }
    }
}