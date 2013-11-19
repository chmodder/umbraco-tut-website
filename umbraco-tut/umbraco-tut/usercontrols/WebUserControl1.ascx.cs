using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace umbraco_tut.usercontrols
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Literal1.Text = "Du er nu kommet ind på siden og har ikke aktiveret noget endnu";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Literal1.Text = "du har skrevet i tekstboksen:" + TextBox1.Text;
        }
    }
}