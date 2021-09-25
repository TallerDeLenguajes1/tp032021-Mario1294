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
        static int i = 0;
        
        private readonly ILogger<CadeteController> _logger;
        private readonly DBTemporal _DB;

        public CadeteController(ILogger<CadeteController> logger, DBTemporal dB)
        {
            _logger = logger;
            _DB = dB;
        }

        public IActionResult Index(string nombre, string telf, string direccion)
        {
            if (nombre != null)
            {
                
                Cadete MiCadete = new Cadete(nombre, i++, telf, direccion);

                _DB.Cadeteria.Cadetes.Add(MiCadete);
                return View(_DB.Cadeteria.Cadetes);
            }
            else
            {
                return View(_DB.Cadeteria.Cadetes);
            }
        }
            
        public IActionResult AltaCadete()
        {
            return View(_DB.Cadeteria.Cadetes);
        }

    }
}
