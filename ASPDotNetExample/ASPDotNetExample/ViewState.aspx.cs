using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPDotNetProject
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private int num = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                TextBoxNumber.Text = "0";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ViewState["Click"] != null)
            {
                num = (int)ViewState["Click"] + 1;
            }
            TextBoxNumber.Text = num.ToString();
            ViewState["Click"] = num;
        }
    }
}