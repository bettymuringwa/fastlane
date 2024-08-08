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
    public partial class Purchase : System.Web.UI.Page
    {
        DataAccess da = new DataAccess();
        protected void Page_Load(object sender, EventArgs e)
        {
            dob.Value = DateTime.Now.ToString("yyyy-MM-dd");
        }

        protected void btnpurchase_Click(object sender, EventArgs e)
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
                cmd.CommandText = $@"INSERT INTO Purchases (transactionDate, transactionTime, customerID, product, quantity, price) 
                                    Values (@0, @1, @2, @3, @4, @5)";
                //add parameters and values
                cmd.Parameters.AddWithValue("@0", dob.Value);
                cmd.Parameters.AddWithValue("@1", time.Value);
                cmd.Parameters.AddWithValue("@2", customerid.Value);
                cmd.Parameters.AddWithValue("@3", product.Value);
                cmd.Parameters.AddWithValue("@4", quantity.Value);
                cmd.Parameters.AddWithValue("@5", price.Value);
                
                //execute insert sql
                int rows = cmd.ExecuteNonQuery();

                //check for success
                String msg = (rows > 0) ? " Purchase Successful !!" : " Purchase Failed !!";

                //assign message to label
                lblerror.InnerText = msg;




            }
            catch (Exception ex)
            {
                lblerror.InnerText = ex.Message;
            }

        }





        //end
    }
}