using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyWebSite.Pages
{
    public partial class Reports : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            User users = (User)Session["currentUser"];
        }
        

        private int CreateALog(int userID, string category, string description)
        {
            

            HousingEntities3 dbl = new HousingEntities3();
            int writeLogSuccess = 0;
            try
            {
                Log logs = new Log();
                logs.UserID = userID;
                logs.Category = category;
                logs.Cat_Description = description;
                dbl.Logs.Add(logs);
                writeLogSuccess = dbl.SaveChanges();
                if (writeLogSuccess == 0)
                {
                    //lblSuccess.Text = "Error creating logs.";
                }
            }
            catch (Exception ex)
            {

                lblSuccess.Text = "Error in database" + ex.InnerException;
            }
            return (writeLogSuccess);
        }
        protected void btnApartmentApplicantReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://172.28.134.4/Reports/report/Apartment%20Applications");
            //CreateALog(Convert.ToUInt16(), "Report accessed ", "User " + user.UserName.ToString() + " Accessed Apartment Applications Report");
        }

        protected void btnApartmentVacancies_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://172.28.134.4/Reports/report/Apartment%20Available");
            //CreateALog(Convert.ToUInt16(user.UserID), "Report accessed ", "User " + user.UserName.ToString() + " Accessed Apartment Vacancies Report");
        }

        protected void btnMaintenanceRequests_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://172.28.134.4/Reports/report/Maintenance%20Requests");
            //CreateALog(Convert.ToUInt16(user.UserID), "Report accessed ", "User " + user.UserName.ToString() + " Accessed Maintenance Request Report");
        }

        protected void btnRentalPayments_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://172.28.134.4/Reports/report/Rental%20Payments");
            //CreateALog(Convert.ToUInt16(user.UserID), "Report accessed ", "User " + user.UserName.ToString() + " Accessed Maintenance Request Report");
        }

        protected void btnResidentFees_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://172.28.134.4/Reports/report/Resident%20Fees");
            //CreateALog(Convert.ToUInt16(user.UserID), "Report accessed ", "User " + user.UserName.ToString() + " Accessed Resident Fees Report");
        }

        protected void btnLogReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://172.28.134.4/Reports/report/Resident%20Fees");
            //CreateALog(Convert.ToUInt16(user.UserID), "Report accessed ", "User " + user.UserName.ToString() + " Accessed Log Report");
        }
    }
}
