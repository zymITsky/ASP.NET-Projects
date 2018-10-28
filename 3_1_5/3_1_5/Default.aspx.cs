using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3_1_5
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ValidateCode1.CreateYzm();
            }
        }
        protected bool CheckCode() {
            if (ValidateCode1.CheckYzm(TextBox2.Text)){
                return true;
            }
            else {
                return false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (!CheckCode())
            {
                this.Label1.Visible = true;
                this.Label1.Text = "验证码错误";
            }
            else {
                this.Label1.Visible = true;
                this.Label1.Text = "验证通过！";
            }
        }
    }
}