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
    public partial class ProductDetails : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int ProdId = Convert.ToInt32(Request.QueryString["ProdId"]);
                string sel = "select ProdName,ProdDescription,ProdImage,ProdPrice from ProductTbl where ProdId=" + ProdId + "";
                SqlDataReader dr = obj.Fn_Reader(sel);
                while(dr.Read())
                {
                    Label1.Text = dr["ProdName"].ToString();
                    Label2.Text = dr["ProdDescription"].ToString();
                    Label3.Text = dr["ProdPrice"].ToString();
                    Image1.ImageUrl = dr["ProdImage"].ToString();
                }
               
            }

                    

        }
    }
}