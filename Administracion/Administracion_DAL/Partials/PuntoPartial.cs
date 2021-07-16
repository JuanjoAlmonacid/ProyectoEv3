using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Administracion_DAL
{
    public partial class Punto
    {
        public String AbiertoTxt
        {
            get
            {
                String texto = "";
                switch (Abierto)
                {
                    case 1:
                        texto = "Si";
                        break;
                    case 2:
                        texto = "No";
                        break;
                    
                }

                return texto;
            }
        }

    }
}
