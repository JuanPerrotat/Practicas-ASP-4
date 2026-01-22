using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ejemplo_web_GV
{
    public partial class FormularioAuto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlColores.Items.Add("Negro");
            ddlColores.Items.Add("Rojo");
            ddlColores.Items.Add("Blanco");
            ddlColores.Items.Add("Azul");

        }
    }
}