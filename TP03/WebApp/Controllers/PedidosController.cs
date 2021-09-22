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
        private readonly List<Pedido> pedidos;

        public PedidosController(ILogger<PedidosController> logger, List<Pedido> Pedidos)
        {
            _logger = logger;
            pedidos = Pedidos;
        }

        public IActionResult Index(string obs, string cliente, string est)
        {
            if (obs != null)
            {
                Pedido MiPedido = new Pedido(obs, i++, cliente, est);

                pedidos.Add(MiPedido);

                return View(pedidos);
            }
            else
            {
                return View(pedidos);
            }
            
        }
        public IActionResult CrearPedido()
        {
            return View();
        }
    }
}
