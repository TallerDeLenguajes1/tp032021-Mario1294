using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Entidades
{
    public class Cadete
    {
        private string nombre;
        private int id;
        private string direccion;
        private string telf;
        public List<Pedido> Pedidos;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telf { get => telf; set => telf = value; }
       
        public Cadete(string _nombre, int _id, string _telf, string _direccion)
        {
            this.nombre = _nombre;
            this.id = _id;
            this.telf = _telf;
            this.direccion = _direccion;
        }
        public void CargarPedido(Pedido pedido)
        {
            Pedidos.Add(pedido);
        }
    }
}
