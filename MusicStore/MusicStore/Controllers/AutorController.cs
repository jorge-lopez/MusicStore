using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogic;
using VariablesTemp;
using Modelos;

namespace MusicStore.Controllers
{
    public class AutorController : Controller
    {
        // GET: Autor
        public ActionResult Index()
        {
            AutorTemp.Inicializar();            
            return View(AutorTemp.getAutores());
        }
    }
}