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

        public IActionResult Index()
        {

                return View(_DB.Cadeteria.Pedidos);
            
        }
        public IActionResult CrearPedido(string obs, string est, string name, string phone, string address)
        {
            int id = _DB.Cadeteria.Pedidos.Count + 1;
            if (obs == null)
            {
                return View();
            }
            Pedido MiPedido = new Pedido(id, obs, phone, address, name, est);
            _DB.Cadeteria.Pedidos.Add(MiPedido);
            _DB.GuardarPedido(_DB.Cadeteria.Pedidos);
            
            return Redirect("Index");
        }

        public IActionResult ModifyPedido(string obs, string est, string name, string phone, string address, int id)
        {
            if (obs == null || est == null || name == null || phone == null || address == null) 
            {
                Pedido Ped = _DB.Cadeteria.Pedidos.Find(x => x.Num == id);
                if (Ped != null)
                    return View(Ped);
                else
                    return View("Index", _DB.Cadeteria.Pedidos);
            }
            Pedido NewPed = new Pedido(id, obs, phone, address, name, est);
            Pedido MPed = _DB.Cadeteria.Pedidos.Find(x => x.Num == id);
            _DB.Cadeteria.Pedidos.Remove(MPed);
            _DB.Cadeteria.Pedidos.Add(NewPed);
            _DB.Cadeteria.Pedidos.Sort((x, y) => x.Num.CompareTo(y.Num));
            _DB.GuardarPedido(_DB.Cadeteria.Pedidos);


            return View("Index", _DB.Cadeteria.Pedidos);
        }
    }
}
