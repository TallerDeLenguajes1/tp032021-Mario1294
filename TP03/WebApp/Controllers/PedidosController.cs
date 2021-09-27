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

        public IActionResult Index(string obs, string est, string name, string phone, string address)
        {
            
            if (obs != null)
            {
                Pedido MiPedido = new Pedido
                {
                    Num = i++,
                    Obs = obs,
                    Cliente = new Cliente
                    {
                        Nombre = name,
                        Direccion =address,
                        Telf = phone,
                    },
                    Estado = est,

                };

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
