using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _3_1_1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Button1.Value = "Click Me Now!";
            Label1.Text = "<h1>hello world</h1>";
            Image myImage = new Image();
            myImage.AlternateText = "Image Text";
            myImage.ImageUrl = "img1.jpg";
            myImage.ImageAlign = ImageAlign.Left;
            Page.Controls.Add(myImage);

        }
    }
}