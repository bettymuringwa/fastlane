using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Configuration;

namespace abc20025_fastlane
{
    public partial class managecustomers : System.Web.UI.Page
    {
        DataAccess da = new DataAccess();
        protected void Page_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    String sql = "select * from UserGroup"; //"select * from information_schema.columns;";
            //    SqlConnection conn = new SqlConnection("server=localhost\\SQLEXPRESS; database=FastLane_DB; integrated security=sspi;");
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    cmd.CommandType = CommandType.Text;

            //    SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    DataSet ds = new DataSet();
            //    da.Fill(ds, "data");

            //    //load data into grid
            //    grid.DataSource = ds.Tables["data"];
            //    grid.DataBind(); //important to bind data

            //}
            //catch (Exception ex)
            //{
            //    lblerror.InnerText = ex.Message;
            //}

            dob.Value = DateTime.Now.ToString("yyyy-MM-dd");
            password.Attributes["type"] = "password"; //set attribute password after showing - circumvent clearing when password already 

        }


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
                cmd.Parameters.AddWithValue("@10", bankname.Value);
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

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {

                //CreateChildControls and open connection
                SqlConnection conn = new SqlConnection("server=localhost\\SQLEXPRESS; database=FastLane_DB; integrated security=sspi;");
                conn.Open();

                //create command object
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;


                //assigning values through parameters
                cmd.CommandText = $@"UPDATE Customers SET customerID=@0, firstName=@1, surname=@2, gender=@3, DateOfBirth=@4, country=@5, town=@6, customerAddress=@7, email=@8, cellNumber=@9, bankName=@10, accountNumber=@11, customerStatus=@12, customerPassword=@13, groupID=@14;";
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
                cmd.Parameters.AddWithValue("@10", bankname.Value);
                cmd.Parameters.AddWithValue("@11", accountnum.Value);
                cmd.Parameters.AddWithValue("@12", customerstatus.Value);
                cmd.Parameters.AddWithValue("@13", password.Value);
                cmd.Parameters.AddWithValue("@14", groupname.Value);


                //execute insert sql
                int rows = cmd.ExecuteNonQuery();

                //check for success
                String msg = (rows > 0) ? "Customer details updated successfully !!" : "Customer details updating failed !!";

                //assign message to label
                lblerror.InnerText = msg;

                //REFRESH GRID BY INVOKING THE PAGELOAD
                Page_Load(null, null);

            }
            catch (Exception ex)
            {
                lblerror.InnerText = ex.Message;
            }
        }

       




        //end
    }
}