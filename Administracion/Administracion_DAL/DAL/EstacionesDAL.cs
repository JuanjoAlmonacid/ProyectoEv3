using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion_DAL.DAL
{
    public class EstacionesDAL
    {
        private static List<Estacion> estaciones = new List<Estacion>()
        {
            new Estacion()
            {
                Nombre="Quilpue",
                Codigo="2430000"
            },
            new Estacion()
            {
                Nombre="Valparaiso",
                Codigo="2340000"
            },
            new Estacion()
            {
                Nombre="Vinia",
                Codigo="2520000"
            },
            new Estacion()
            {
                Nombre="VillaAlemana",
                Codigo="6500000"
            },
        };

        public List<Estacion> GetAll()
        {
            return estaciones;
        }
    }
}
