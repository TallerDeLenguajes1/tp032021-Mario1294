using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Entidades
{
    public class Pedido
    {
        private int num;
        private string obs;
        private string cliente;
        private string estado;

        public int Num { get => num; set => num = value; }
        public string Obs { get => obs; set => obs = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Estado { get => estado; set => estado = value; }

        public Pedido(string _obs, int _num, string _cliente, string _estado)
        {
            this.num = _num;
            this.obs = _obs;
            this.cliente = _cliente;
            this.estado = _estado;
        }
    }
}
