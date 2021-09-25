using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Entidades;

namespace WebApp.Controllers
{
    public class PedidosController : Controller
    {
        static int i = 0;
        private readonly ILogger<PedidosController> _logger;
        private readonly DBTemporal _DB;

        public PedidosController(ILogger<PedidosController> logger, DBTemporal dB)
        {
            _logger = logger;
            _DB = dB;
        }

        public IActionResult Index(string obs, string cliente, string est)
        {
            if (obs != null)
            {
                Pedido MiPedido = new Pedido(obs, i++, cliente, est);

                _DB.Cadeteria.Pedidos.Add(MiPedido);

                return View(_DB.Cadeteria.Pedidos);
            }
            else
            {
                return View(_DB.Cadeteria.Pedidos);
            }
            
        }
        public IActionResult CrearPedido()
        {
            return View();
        }
    }
}
