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
    public partial class AddProduct : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string sel = "select * from CatagoryTbl";
                DataSet ds = obj.Fn_exeAdapter(sel);
                DropDownList1.DataSource = ds;
                DropDownList1.DataTextField = "CatName";
                DropDownList1.DataValueField = "CatId";
                DropDownList1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = "~/img/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(path));

            string ins = "insert into ProductTbl values(" + DropDownList1.SelectedItem.Value + ",'" + TextBox1.Text + "','" + TextBox2.Text + "','" + path + "'," + TextBox3.Text + "," + TextBox4.Text + ",'Available')";
            int i = obj.Fn_NonQuery(ins);
            if(i!=0)
            {
                Label5.Text = "Inserted.....!";
            }
        }
    }
}