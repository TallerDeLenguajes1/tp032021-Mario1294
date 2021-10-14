using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Entidades
{
    public class Pedido
    {
        private int id;
        private string obs;
        private Cliente cliente;
        private string estado;
        private Cadete cadete;

        public int Num { get => id; set => id = value; }
        public string Obs { get => obs; set => obs = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public string Estado { get => estado; set => estado = value; }
        public Cadete Cadete { get => cadete; set => cadete = value; }

        public Pedido(int _id, string _obs, string _telfCliente, string _direccionCliente, string _nombreCliente, string _estado)
        {
            this.id = _id;
            this.obs = _obs;
            this.estado = _estado;
            this.cliente = new Cliente(_nombreCliente, _direccionCliente, _telfCliente);
        }
    }
}
