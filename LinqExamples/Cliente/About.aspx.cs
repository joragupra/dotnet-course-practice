using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Linq;
using AccesoDatos;

namespace Cliente
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CargarClientesLondres(object sender, EventArgs e)
        {
            //buscar regiones en la base de datos
            DataContext db = new DataContext(@"C:\NORTHWND.MDF");
            Table<Customer> Customers = db.GetTable<Customer>();
            var query1 = from cust in Customers
                         where cust.City == "London"
                         select cust;
            this.objGridView.DataSource = query1;
            this.objGridView.DataBind();
        }
    }
}
