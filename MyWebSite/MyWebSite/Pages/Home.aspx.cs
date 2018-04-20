using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebSite.Pages
{
   
    public partial class Home : System.Web.UI.Page
    {
        User user = new User();
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowUserDetails();
        }

        private void ShowUserDetails()
        {
            user = ((MasterPage)this.Master).currentuser;
            lblDetails.Text = user.UserName.ToString();
        }
    }
}