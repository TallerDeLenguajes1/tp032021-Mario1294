using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Entidades
{
    public class Cliente
    {
        private int id;
        private string nombre;
        private string direccion;
        private string telf;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telf { get => telf; set => telf = value; }

        public Cliente()
        {

        }
    }
}
