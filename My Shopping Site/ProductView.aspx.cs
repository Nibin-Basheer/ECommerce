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
    public partial class ProductView : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                if (Request.QueryString["CatId"] != null)
                {
                    int CatId = Convert.ToInt32(Request.QueryString["CatId"]);
                    string s = "select * from ProductTbl where CatId=" + CatId + "";
                    DataSet ds = obj.Fn_exeAdapter(s);
                    DataList1.DataSource = ds;
                    DataList1.DataBind();
                }

            }

        }

        protected void ImageButton1_Command(object sender, CommandEventArgs e)
        {
            int ProdId = Convert.ToInt32(e.CommandArgument);
            Response.Redirect("ProductDetails.aspx?ProdId=" + ProdId);
        }
    }
}