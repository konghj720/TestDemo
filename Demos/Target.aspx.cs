using System;

namespace Demos
{
    public partial class DemosTarget : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = Request.QueryString.ToString();
            /*123312312312312313*/
        }
    }
}