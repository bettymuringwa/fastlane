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
    public partial class testlog : System.Web.UI.Page
    {
        DataAccess da = new DataAccess();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            //crosscheck
            try
            {

                //trigger validate data method when button is clicked
                string message = ValidateData();
                if (message != "")
                {
                    lblerror.Text = "";
                    return; //end execution when validation fails
                }

                //sql query to find login details
                string sql = $@"select * from Customers where email = '{username.Value}' and customerPassword = '{password.Value}' ";

                //get data through da
                DataSet ds = da.GetData(sql);

                //login not successful?
                if (ds.Tables["data"].Rows.Count == 0)
                {
                    //fail
                    lblerror.Text = "invalid login credentials.";
                }
                else
                {
                    //determine user group
                    string usergroup = (ds.Tables["data"].Rows[0]["groupid"].ToString().ToUpper() == "CM") ? "Customer" : ""  ;
                    
                    string firstname = ds.Tables["data"].Rows[0]["firstname"].ToString();
                    string surname = ds.Tables["data"].Rows[0]["surname"].ToString();
                    string title = (ds.Tables["data"].Rows[0]["gender"].ToString().ToUpper() == "Female") ? "Ms. " : "Mr. ";
                    string fullname = $"{title} {firstname} {surname} - [{usergroup.ToUpper()}]";
                    //then login valid so log them in 

                    //store current user and group in session  object
                    var page = HttpContext.Current.Handler as System.Web.UI.Page;

                    page.Session.Add("email", username.Value);//
                    page.Session.Add("usergroup", usergroup);//
                    page.Session.Add("fullname", fullname);//

                    Response.Redirect("home.aspx");
                }
                
            }
            catch (Exception ex)
            {
                lblerror.Text = ex.Message;
            }

        }

        protected void btnregister_Click(object sender, EventArgs e)
        {
            Response.Redirect("registers.aspx");
        }


        //validation of login details
        private string ValidateData()
        {
            try
            {
                string message = "";
                message += (username.Value == "") ? "<br/> Please enter username" : "";
                message += (password.Value == "") ? "<br/> Please enter password" : "";
                return message;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        
    }



        //end
    }
}