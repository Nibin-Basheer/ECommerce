using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace My_Shopping_Site
{
    public partial class AddCategory : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string path = "~/img/" + FileUpload1.FileName;
            FileUpload1.SaveAs(MapPath(path));

            string s = "insert into CatagoryTbl values('" + TextBox1.Text + "','" + TextBox2.Text + "', '" + path + "','Available')";
            int i = obj.Fn_NonQuery(s);
            if(i!=0)
            {
                Label5.Visible = true;
                Label5.Text = "Inserted";
            }

        }
    }
}