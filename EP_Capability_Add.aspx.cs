using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class EP_Capability_Add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!Page.IsPostBack)
        {
            Panel_CAP_table.Visible = false;
        }
    }

    protected void butSearch_Click(object sender, EventArgs e)
    {

    }
}