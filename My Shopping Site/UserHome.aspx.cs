using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace My_Shopping_Site
{
    public partial class UserHome : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string sel = "select * from CatagoryTbl";
                DataSet ds = obj.Fn_exeAdapter(sel);
                DataList1.DataSource = ds;
                DataList1.DataBind();
            }
        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            int CatId = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("ProductView.aspx?CatId=" + CatId);
            
          

         
        }

    }
}