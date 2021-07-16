using Administracion_DAL;
using Administracion_DAL.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Evaluacion
{
    public partial class AgregarPunto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                List<Punto> puntos = new PuntosDAL().GetAll();
                puntoDdl.DataSource = puntos;
                puntoDdl.DataTextField = "Nombre";
                puntoDdl.DataValueField = "Codigo";
                puntoDdl.DataBind();


            }
        }

        protected void ingresarBtn_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {

                string nombre = nombreTxt.Text.Trim();
                String codigo = puntoDdl.SelectedValue;


                Punto p = new Punto();
                p.NombreP = nombre;
               



                new PuntosDAL().Add(p);


                mensajeLbl.Text = "Punto Ingresado";
                limpiar();
            }
            else
            {

            }
        }

        private void limpiar()
        {
            nombreTxt.Text = "";
           

        }
        // filtro 1
        protected void codigoCV_ServerValidate(object source, ServerValidateEventArgs args)
        {
            String codigo = codigoTxt.Text.Trim();

            if (codigo == "2430000")
            {

                Console.WriteLine("usted escogio a Quilpue");
            }
            else if (codigo == "2340000")
            {

                Console.WriteLine("usted escogio a Valparaiso");

            } else if (codigo == "2520000")
            {

                Console.WriteLine("usted escogio a Vinia");

            }
            else if (codigo == "6500000")
            {

                Console.WriteLine("usted escogio a VillaAlemana");

            }

        }
    }
}