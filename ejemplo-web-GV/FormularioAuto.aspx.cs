using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;

namespace ejemplo_web_GV
{
    public partial class FormularioAuto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlColores.Items.Add("Negro");
                ddlColores.Items.Add("Rojo");
                ddlColores.Items.Add("Blanco");
                ddlColores.Items.Add("Azul");
            }

            if (Request.QueryString["id"] != null)
            {
                int id = int.Parse(Request.QueryString["id"].ToString());
                List<Auto> temporal = (List<Auto>)Session["listaAutos"];
                Auto seleccionado = temporal.Find(x => x.Id == id);
                txtModelo.Text = seleccionado.Modelo;
                txtID.Text = seleccionado.Id.ToString();
                txtID.ReadOnly = true;
                txtDescripcion.Text = seleccionado.Descripcion;
                ddlColores.SelectedValue = seleccionado.Color;
                txtFecha.Text = seleccionado.Fecha.ToString("yyyy-MM-dd");
                chkUsado.Checked = seleccionado.Usado;
                if (seleccionado.Importado)
                    rbtnImportado.Checked = true;
                else
                    rbtnNacional.Checked = true;

                btnAceptar.Enabled = false;
            }
            else
            {
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Auto a= new Auto();
            a.Id = int.Parse(txtID.Text);
            a.Modelo = txtModelo.Text;
            a.Descripcion = txtDescripcion.Text;    
            a.Color = ddlColores.SelectedValue;
            a.Fecha = DateTime.Parse(txtFecha.Text);
            a.Usado = chkUsado.Checked;
            a.Importado = rbtnImportado.Checked;

            if (rbtnImportado.Checked)
                a.Importado = true;
            else if (rbtnNacional.Checked)
                a.Importado = false;

            //((List<Auto>)Session["listaAutos"]).Add(a);

            List<Auto> temporal = (List<Auto>)Session["listaAutos"];
            temporal.Add(a);

            Response.Redirect("Default.aspx");

        }

        protected void rbtnImportado_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}