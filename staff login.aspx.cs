using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace abc20025_fastlane
{
    public partial class staff_login : System.Web.UI.Page
    {
        //global variable
        DataAccess da = new DataAccess();
         
        protected void Page_Load(object sender, EventArgs e)
        {
             
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            
               //crosscheck
            try
            {
                //validate data
                string message = ValidateData();
                if (message != "")
                {
                    lblerror.Text = "";

                    return;
                }

                //sql query to check staff login details
                string sql = $@"select a.staffID, a.firstName, a.surname, a.gender, a.dateOfBirth, a.country, a.town, a.staffAddress, a.email, a.cellNumber, a.positionID, a.staffStatus, a.staffPassword, a.groupID, a.profilePicture 
                from Staff a,
                    UserGroup b
                    where a.groupID = b.groupID And
                          a.email = '{username.Value}' And
                            a.staffPassword = '{password.Value}'
                        order by a.staffID asc; "; 
               

                //get data
                DataSet ds = da.GetData(sql);

                //login not successful?
                if (ds.Tables["data"].Rows.Count == 0)
                {
                    //fail
                    lblerror.Text = "invalid login credentials.";
                }
                else
                {
                    ////successful
                    string groupID = ds.Tables["data"].Rows[0]["groupID"].ToString();
                    string firstname = ds.Tables["data"].Rows[0]["firstName"].ToString();

                    //store current user to share with other pages
                    Session["username"] = username.Value;
                    Session["groupID"] = groupID;
                    Session["firstName"] = firstname;

                    var page = HttpContext.Current.Handler as System.Web.UI.Page;

                    //redirect to home page
                    Response.Redirect("home.aspx");
                }
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }
          
        }

        private string ValidateData()
        {
            
                string message = "";
                message += (username.Value == "") ? "<br/> Please enter username" : "";
                message += (password.Value == "") ? "<br/> Please enter password" : "";
                return message;
            
            
        }

        ///end
    }
}