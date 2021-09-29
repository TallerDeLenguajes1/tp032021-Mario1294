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
        
        private readonly ILogger<PedidosController> _logger;
        private readonly DBTemporal _DB;

        public PedidosController(ILogger<PedidosController> logger, DBTemporal dB)
        {
            _logger = logger;
            _DB = dB;
        }

        public IActionResult Index(string obs, string est, string name, string phone, string address)
        {
            int id = _DB.Cadeteria.Pedidos.Count;
            if (obs != null)
            {
                Pedido MiPedido = new Pedido
                {
                    Num = id++,
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

                return View(_DB.Cadeteria);
            }
            else
            {
                return View(_DB.Cadeteria);
            }
            
        }
        public IActionResult CrearPedido()
        {
            return View(_DB.Cadeteria);
        }

        public IActionResult AsignarCadete(int IdCadete, int IdPedido)
        {
            Cadete cadete = _DB.Cadeteria.Cadetes.Where(a => a.Id == IdCadete).First();
            Pedido pedido = _DB.Cadeteria.Pedidos.Where(a => a.Num == IdPedido).First();
            cadete.Pedidos.Add(pedido);
            return Redirect("Index");
        }
    }
}
