using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion_DAL
{
    public partial class Punto
    {
        private String nombreP;
        
        private int abierto;

        public string NombreP
        {
            get
            {
                return nombreP;
            }

            set
            {
                nombreP = value;
            }
        }

        public int Abierto
        {
            get
            {
                return abierto;
            }

            set
            {
                abierto = value;
            }
        }
    }
}
