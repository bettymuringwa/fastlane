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
    public partial class login : System.Web.UI.Page
    {
        //global variable to access DA
        DataAccess da = new DataAccess();
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnlogin_Click(object sender, EventArgs e)
        {
            
            //crosscheck
            try {     

                    //trigger validate data method when button is clicked
                                string message = ValidateData();
                                if (message != "")
                                {
                                    lblerror.Text = "";
                                    return; //end execution when validation fails
                                }

                  //sql query to find login details
                string sql = $@"select a.customerID, a.firstName, a.surname, a.gender, a.dateOfBirth, a.country, a.town, a.customerAddress, a.email, a.cellNumber, a.bankName, a.accountNumber, a.customerStatus, a.customerPassword, a.groupID 
                    from Customers a,
                    UserGroup b  
                    where a.groupID = b.groupID And
                          a.email ='{username.Value}' And
                            a.customerPassword = '{password.Value}'
                        order by a.customerID asc;";

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
                    //successful
                    string groupID = ds.Tables[0].Rows[0]["groupID"].ToString();
                    string firstname = ds.Tables[0].Rows[0]["firstName"].ToString();

                    //store current user to share with other pages
                    Session["username"] = username.Value;
                    Session["groupID"] = groupID;
                    Session["firstName"] = firstname;

                    var page = HttpContext.Current.Handler as System.Web.UI.Page;

                    ////redirect to home page
                    Response.Redirect("home.aspx");
                }
            }
            catch (Exception ex){
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
                message += (username.Value == "") ? "<br/> Please enter username": "";
                message += (password.Value == "") ? "<br/> Please enter password" : "";
                return message;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        ///end
    }
}