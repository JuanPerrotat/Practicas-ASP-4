using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;

namespace ejemplo_web_GV
{
    public partial class Formulario_web1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            AutoNegocio negocio = new AutoNegocio();
            dgvAutos.DataSource = negocio.Listar();
            dgvAutos.DataBind();
        }
    }
}