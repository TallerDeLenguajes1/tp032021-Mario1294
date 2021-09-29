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
        private Cliente cliente;
        private string estado;
        private Cadete cadete;

        public int Num { get => num; set => num = value; }
        public string Obs { get => obs; set => obs = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public string Estado { get => estado; set => estado = value; }
        public Cadete Cadete { get => cadete; set => cadete = value; }

        public Pedido()
        {

        }
    }
}
