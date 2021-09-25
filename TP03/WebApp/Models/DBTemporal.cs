using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Entidades;

namespace WebApp.Entidades
{
    public class DBTemporal
    {
        public Cadeteria Cadeteria { get; set;}

        public DBTemporal()
        {
            Cadeteria = new Cadeteria();
        }
            
    }
}
