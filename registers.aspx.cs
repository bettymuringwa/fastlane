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
    public partial class registers : System.Web.UI.Page
    {

        //int MinRegistrationAge = new DataAccess().MinRegistrationAge;

        //new//
        //SqlConnection conn = new SqlConnection("server = localhost\\SQLEXPRESS; database =FastLane_DB; integrated security=sspi;");
        //SqlCommand cmd;
        //SqlDataAdapter da = new SqlDataAdapter();
        //DataTable dt = new DataTable();

        DataAccess da = new DataAccess();

        protected void Page_Load(object sender, EventArgs e)
        {
            //method for user group dropdown
            //filldrop();

            dob.Value = DateTime.Now.ToString("yyyy-MM-dd");
            password.Attributes["type"] = "password"; //set attribute password after showing - circumvent clearing when password already 


        }


        //new//
        //private void filldrop()
        //{
        //    groupname.DataSource = getgroupdata();
        //    groupname.DataTextField = "groupName"; //column shown in drop down
        //    groupname.DataValueField = "groupID";
        //    groupname.DataBind();
        //}

        //public DataTable getgroupdata()
        //{
        //    //throw new NotImplementedException();
        //    cmd = new SqlCommand("getcustomergroup", conn);  //getcustomergroup is a stored procedure with query to bring usergroup name to dropdown

        //    cmd.CommandType = CommandType.StoredProcedure;
        //    da = new SqlDataAdapter(cmd);
        //    dt = new DataTable();
        //    da.Fill(dt);
        //    return dt;
        //}




        protected void btnregister_Click(object sender, EventArgs e)
        {
            try
            {

                //CreateChildControls and open connection
                SqlConnection conn = new SqlConnection("server=localhost\\SQLEXPRESS; database=FastLane_DB; integrated security=sspi;");
                conn.Open();

                //create command object
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;

                //assigning values through parameters   //best approach to avoid SQL injections
                cmd.CommandText = $@"INSERT INTO Customers (customerID, firstName, surname, gender, DateOfBirth, country, town, customerAddress, email, cellNumber, bankName, accountNumber, customerStatus, customerPassword, groupID) 
                                    Values (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14)";
                //add parameters and values
                cmd.Parameters.AddWithValue("@0", customerid.Value);
                cmd.Parameters.AddWithValue("@1", firstname.Value);
                cmd.Parameters.AddWithValue("@2", surname.Value);
                cmd.Parameters.AddWithValue("@3", gender.Value);
                cmd.Parameters.AddWithValue("@4", dob.Value);
                cmd.Parameters.AddWithValue("@5", country.Value);
                cmd.Parameters.AddWithValue("@6", town.Value);
                cmd.Parameters.AddWithValue("@7", customeraddress.Value);
                cmd.Parameters.AddWithValue("@8", email.Value);
                cmd.Parameters.AddWithValue("@9", cellno.Value);
                cmd.Parameters.AddWithValue("@10", bank.Value);
                cmd.Parameters.AddWithValue("@11", accountnum.Value);
                cmd.Parameters.AddWithValue("@12", customerstatus.Value);
                cmd.Parameters.AddWithValue("@13", password.Value);
                cmd.Parameters.AddWithValue("@14", groupname.Value);
                //execute insert sql
                int rows = cmd.ExecuteNonQuery();

                //check for success
                String msg = (rows > 0) ? " Registration Successful !!" : " Registration Failed !!";

                //assign message to label
                lblerror.InnerText = msg;




            }
            catch (Exception ex)
            {
                lblerror.InnerText = ex.Message;
            }
        }
       
        ///end
    }
}