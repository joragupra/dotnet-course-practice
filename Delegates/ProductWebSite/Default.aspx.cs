using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProductWebSite
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.buttonShowValue.Click += ButtonShowValueOnClick;
            this.labelValue.Load += LabelLoad;
        }

        protected void LabelLoad(object sender, EventArgs e)
        {
            this.labelValue.Text = "Loading label...";
        }


        protected void ButtonShowValueOnClick(object sender, EventArgs e)
        {
            this.labelValue.Text += "++.";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            this.labelValue.Text = "Press button event";
        }
    }
}
