﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace My_Shopping_Site
{
    public partial class Login1 : System.Web.UI.Page
    {
        ConnectionClass obj = new ConnectionClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str = "select count(RegId) from LoginTbl where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
            string cid = obj.Fn_Scalar(str);
            int cid1 = Convert.ToInt32(cid);
            if(cid1==1)
            {
                string str1 = "select RegId from LoginTbl where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
                string regid = obj.Fn_Scalar(str1);
                Session["userid"] = regid;

                string str2= "select LogType from LoginTbl where Username='" + TextBox1.Text + "' and Password='" + TextBox2.Text + "'";
                string logtype = obj.Fn_Scalar(str2);
                if(logtype=="Admin")
                {
                    Response.Redirect("AdminHome.aspx");
                }
               else
                {
                    Response.Redirect("UserHome.aspx");
                }
            }

        }
    }
}