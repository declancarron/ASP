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
        HousingEntities3 db = new HousingEntities3();

        //table named Users that is in the database
         User user = new User();
        int writeLogSuccess = 0;
        protected void Page_Load(object sender, EventArgs e) => Session.Clear();

        private int CreateALog(int userID, string category, string description)
        {
            int writeLogSuccess = 0;
            try
            {
                Log logs = new Log();
                logs.UserID = userID;
                logs.Category = category;
                logs.Cat_Description = description;
                db.Logs.Add(logs);
                writeLogSuccess = db.SaveChanges();
                if (writeLogSuccess == 0)
                {
                    lblSuccess.Text = "Error creating logs.";
                }
            }
            catch (Exception ex)
            {

                lblSuccess.Text = "Error in database" + ex.InnerException;
            }
            return (writeLogSuccess);
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
                
                //break;
            }

            try
            {
                // write to log issue, when  log save is inside loop, writing log outside of loop
                writeLogSuccess = CreateALog(Convert.ToUInt16(user.UserID), "Login ", "User " + user.UserName.ToString() + " authenticated successfully");

                if (authenticated && writeLogSuccess == 1)
                {

                    //((MasterPage)this.Master).currentuser = this.user;
                    //return where you are at back to the master page
                    HttpContext.Current.Session["currentUser"] = user;

                    //redirect authenticated user to home page
                    Response.Redirect("~/pages/Home.aspx");
                }
                else
                {
                    lblSuccess.Text = "Problem loggin in. Please re-enter user details.";
                    CreateALog(Convert.ToUInt16(user.UserID), "Login ", "User " + user.UserName.ToString() + " authenticated failure");
                }

            }
            catch (Exception ex)
            {

                lblSuccess.Text = "Problem loggin in. Please re-enter user details.";
            }

            
        }
    }
}