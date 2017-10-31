using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASPDotNetExample
{
    public partial class ApplicationLevelEvents : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Number of Application Running:" + Application["Application"]+"<br/>");
            Response.Write("Number of Session Running:" + Application["Session"]);
        }
    }
}