using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace MyWebSite.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        //entity framework name for the database
        StudentHousingEntities1 db = new StudentHousingEntities1();

        //table named Users that is in the database
        Users user = new Users();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            bool authenticated = false;
            var userName = tbxUsername.Text.Trim();
            var password = tbxPassword.Text.Trim();
            

            //loop through the Users table
            foreach (var userRecord in db.Users.Where(t => t.Username == userName && t.Password == password)
            {
                user = userRecord;

                authenticated = true;
            }
            if (authenticated)
            {
                ((MasterPage)this.Master).currentuser = this.user;
                //return where you are at back to the master page

                Response.RedirectToRoute('');
            }
        }
    }
}