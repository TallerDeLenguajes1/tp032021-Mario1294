using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Entidades
{
    public class Cadeteria
    {
        private string nombre;
        private List<string> cadete;

        public string Nombre { get => nombre; set => nombre = value; }
        public List<string> Cadete { get => cadete; set => cadete = value; }
    }
}
