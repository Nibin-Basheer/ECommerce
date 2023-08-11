using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace My_Shopping_Site
{
    public partial class UserReg : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sel = "select max(RegId) from LoginTbl";
            string regid = obj.Fn_Scalar(sel);
            int regi_id = 0;
            if (regid == "")
            {
                regi_id = 1;
            }
            else
            {
                int newregid = Convert.ToInt32(regid);
                regi_id = newregid + 1;
            }
            string ins = "insert into UserRegTbl values('" + regi_id + "','" + TextBox1.Text + "'," + TextBox2.Text + ",'" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";
            int i = obj.Fn_NonQuery(ins);
            if (i != 0)
            {
                string inslog = "insert into LoginTbl values('" + regi_id + "','" + TextBox6.Text + "','" + TextBox7.Text + "','User','Active')";
                int j = obj.Fn_NonQuery(inslog);
            }
        }
    }
}