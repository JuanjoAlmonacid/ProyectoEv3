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
    public partial class VerPuntos : System.Web.UI.Page
    {
        PuntosDAL puntosDAL = new PuntosDAL();

        private void CargarTabla(List<Punto> puntos)
        {
            puntosGrid.DataSource = puntos;
            puntosGrid.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarTabla(puntosDAL.GetAll());
            }
        }

        //eliminar

        protected void ountosGrid_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
            if (e.CommandName == "eliminar punto")
            {
               
                String codigoAEliminar = e.CommandArgument.ToString();

              
                puntosDAL.Remove(codigoAEliminar);

              
                CargarTabla(puntosDAL.GetAll());

            }


        }

        protected void nivelDdl_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Threading.Thread.Sleep(3000);
            int codigoSel = Convert.ToInt32(puntoDdl.SelectedValue);
            
            List<Punto> filtrada = puntosDAL.GetAll(codigoSel);
            CargarTabla(filtrada);
        }

        protected void todosChx_CheckedChanged(object sender, EventArgs e)
        {
            puntoDdl.Enabled = !todosChx.Checked;

            if (todosChx.Checked)
            {
                CargarTabla(puntosDAL.GetAll());
            }
        }
    }
}