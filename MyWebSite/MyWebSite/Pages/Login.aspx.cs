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
        HousingEntities1 db = new HousingEntities1();

        //table named Users that is in the database
         
        User user = new User();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void CreateALog(int userID, string category, string description)
        {
            try
            {
                Log logs = new Log();
                logs.UserID = userID;
                logs.Category = category;
                logs.Cat_Description = description;
                db.Logs.Add(logs);
                int success = db.SaveChanges();
                if (success == 0)
                {
                    lblSuccess.Text = "Error creating logs.";
                }
            }
            catch (Exception ex)
            {

                lblSuccess.Text = "Error in database" + ex.InnerException;
            }
           
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            bool authenticated = false;
            var userName = tbxUsername.Text.Trim();
            var password = tbxPassword.Text.Trim();
            

            //loop through the Users table
            foreach (var userRecord in db.Users.Where(t => t.UserName == userName && t.Password == password))
            {
                user = userRecord;

                authenticated = true;
                CreateALog(Convert.ToUInt16(user.UserID), "Login", "User" + user.UserName.ToString() + "authenticated successfully");
                break;
            }
            if (authenticated)
            {
                ((MasterPage)this.Master).currentuser = this.user;
                //return where you are at back to the master page

                Response.Redirect("~/pages/Home.aspx");
            }
            else
            {
                lblSuccess.Text = "Problem loggin in. Please re-enter user details.";
                CreateALog(Convert.ToUInt16(user.UserID), "Login", "User" + user.UserName.ToString() + "authenticated failure");
            }
            //lblMessage.Text ="User details enter are "+ username + " " +Password;
        }
    }
}