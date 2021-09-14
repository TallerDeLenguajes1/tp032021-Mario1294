using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Entidades
{
    public class Pedidos
    {
        private int num;
        private string obs;
        private string cliente;
        private string estado;

        public int Num { get => num; set => num = value; }
        public string Obs { get => obs; set => obs = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
