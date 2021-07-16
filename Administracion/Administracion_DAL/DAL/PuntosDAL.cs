using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion_DAL.DAL
{
    public class PuntosDAL
    {

        private static List<Punto> puntos = new List<Punto>();

        public void Add(Punto p)
        {
            puntos.Add(p);
        }

        public List<Punto> GetAll()
        {
            return puntos;
        }

        public void Remove(String nombreP)
        {
            Punto punto = puntos.Find(p => p.NombreP == nombreP);
            puntos.Remove(punto);
        }

        public List<Punto> GetAll(int abierto)
        {
            return puntos.FindAll(p => p.Abierto == abierto);
        }
    }

}

