using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Entidades;

namespace Cliente
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Cuenta[] cuentas = Controlador.ConsultarCuentasCSV();
            this.objGridView.DataSource = cuentas;
            this.objGridView.DataBind();
        }
    }
}
