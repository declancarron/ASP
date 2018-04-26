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
        //User user = new User();
        protected void Page_Load(object sender, EventArgs e)
        {
            //ShowUserDetails();
            User user = (User)Session["currentUser"];

            //details for the login message
            string firstName = user.FirstName;
            string lastName = user.LastName;
            string userName = user.UserName;
            string welcomeMessage = "Welcome " + firstName + " " + lastName + ". Please select an option";

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("~/Pages/Login.aspx");
        }

        // private void ShowUserDetails()
        // {
        //   user = ((MasterPage)this.Master).currentuser;
        // lblDetails.Text = user.UserName.ToString();
        //}
    }
}