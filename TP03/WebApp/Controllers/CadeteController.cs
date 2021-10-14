using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Entidades;

namespace WebApp.Controllers
{
    public class CadeteController : Controller
    {

        private readonly ILogger<CadeteController> _logger;
        private readonly DBTemporal _DB;

        public CadeteController(ILogger<CadeteController> logger, DBTemporal dB)
        {
            _logger = logger;
            _DB = dB;
        }

        public IActionResult Index()
        {
            return View(_DB.Cadeteria.Cadetes);
        }
            
        public IActionResult AltaCadete(string nombre, string telf, string direccion)
        {
            int id = _DB.Cadeteria.Cadetes.Count + 1;
            if (nombre == null || telf == null || direccion == null)
            {
                return View();
            }

            Cadete MiCadete = new Cadete(nombre, id++, telf, direccion);
            _DB.Cadeteria.Cadetes.Add(MiCadete);
            _DB.GuardarCadete(_DB.Cadeteria.Cadetes);
            return View("Index", _DB.Cadeteria.Cadetes);
        }

        public IActionResult ModifyCadete(string nombre, string telf, string direccion, int id)
        {
            if (nombre == null || telf == null || direccion == null)
            {
                Cadete Cad = _DB.Cadeteria.Cadetes.Find(x => x.Id == id);

                if (Cad != null)
                    return View(Cad);
                else
                    return View("Index", _DB.Cadeteria.Cadetes);
            }

            Cadete NewCad = new(nombre, id, telf, direccion);
            Cadete MCad = _DB.Cadeteria.Cadetes.Find(x => x.Id == id);
            _DB.Cadeteria.Cadetes.Remove(MCad);
            _DB.Cadeteria.Cadetes.Add(NewCad);
            _DB.Cadeteria.Cadetes.Sort((x, y) => x.Id.CompareTo(y.Id));
            _DB.GuardarCadete(_DB.Cadeteria.Cadetes);
           
            return View("Index", _DB.Cadeteria.Cadetes);
        }

        public IActionResult DeleteCadete(int id, string confirmation)
        {    
            Cadete Cad = _DB.Cadeteria.Cadetes.Find(x => x.Id == id);
            if (Cad == null )
            {
                return View("Index", _DB.Cadeteria.Cadetes);
            }
            if (confirmation != "yes")
            {
                _DB.Cadeteria.Cadetes.Remove(Cad);
                return View("Index", _DB.Cadeteria.Cadetes);
            }
            return View("Index", _DB.Cadeteria.Cadetes);
            
        }
    }
}
