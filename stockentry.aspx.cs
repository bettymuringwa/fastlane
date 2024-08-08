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
    public partial class stockentry : System.Web.UI.Page
    {
        DataAccess da = new DataAccess();

        ////new//
        //SqlConnection conn = new SqlConnection("server = localhost\\SQLEXPRESS; database =FastLane_DB; integrated security=sspi;");
        //SqlCommand cmd;
        //SqlDataAdapter da = new SqlDataAdapter();
        //DataTable dt = new DataTable();
        protected void Page_Load(object sender, EventArgs e)
        {
            ////method for user group dropdown
            //filldrop();
            //try
            //{
            //    String sql = "select * from StockCategory"; //"select * from information_schema.columns;";
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
                 dpurchase.Value = DateTime.Now.ToString("yyyy-MM-dd");
            
           
           
        }

        //private void filldrop()
        //{
        //    categoryid.DataSource = getgroupdata();
        //    categoryid.DataTextField = "categoryName"; //column shown in drop down
        //    categoryid.DataValueField = "categoryID";
        //    categoryid.DataBind();
        //}

        //public DataTable getgroupdata()
        //{
        //    //throw new NotImplementedException();
        //    cmd = new SqlCommand("getcategoryid", conn);  //getgroup is a stored procedure with query to bring group name to dropdown

        //    cmd.CommandType = CommandType.StoredProcedure;
        //    da = new SqlDataAdapter(cmd);
        //    dt = new DataTable();
        //    da.Fill(dt);
        //    return dt;
        //}

        protected void btnsave_Click(object sender, EventArgs e)
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
                cmd.CommandText = $@"INSERT INTO StockEntry (productCode, productName, size, categoryID, quantity, reorderLevel, purchasePrice, percentageMarkup, sellingPrice, datePurchased, productStatus, staffID)
                                    Values (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11)";
                //add parameters and values
                cmd.Parameters.AddWithValue("@0", pcode.Value);
                cmd.Parameters.AddWithValue("@1", pname.Value);
                cmd.Parameters.AddWithValue("@2", size.Value);
                cmd.Parameters.AddWithValue("@3", categoryid.Value);
                cmd.Parameters.AddWithValue("@4", quantity.Value);
                cmd.Parameters.AddWithValue("@5", rlevel.Value);
                cmd.Parameters.AddWithValue("@6", pprice.Value);
                cmd.Parameters.AddWithValue("@7", pmarkup.Value);
                cmd.Parameters.AddWithValue("@8", sprice.Value);
                cmd.Parameters.AddWithValue("@9", dpurchase.Value);
                cmd.Parameters.AddWithValue("@10", pstatus.Value);
                cmd.Parameters.AddWithValue("@11", staffid.Value);

                //execute insert sql
                int rows = cmd.ExecuteNonQuery();

                //check for success
                String msg = (rows > 0) ? " Stock Entry Successful !!" : " Stock Entry Failed !!";

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
                cmd.CommandText = $@"UPDATE StockEntry SET productCode=@0, productName=@1, size=@2, categoryID=@3, quantity=@4, reorderLevel=@5, purchasePrice=@6, percentageMarkup=@7, sellingPrice=@8, datePurchased=@9, productStatus=@10 staffID=@11 WHERE productcode=@12;";

                //add parameters and values
                cmd.Parameters.AddWithValue("@0", pcode.Value);
                cmd.Parameters.AddWithValue("@1", pname.Value);
                cmd.Parameters.AddWithValue("@2", size.Value);
                cmd.Parameters.AddWithValue("@3", categoryid.Value);
                cmd.Parameters.AddWithValue("@4", quantity.Value);
                cmd.Parameters.AddWithValue("@5", rlevel.Value);
                cmd.Parameters.AddWithValue("@6", pprice.Value);
                cmd.Parameters.AddWithValue("@7", pmarkup.Value);
                cmd.Parameters.AddWithValue("@8", sprice.Value);
                cmd.Parameters.AddWithValue("@9", dpurchase.Value);
                cmd.Parameters.AddWithValue("@10", pstatus.Value);
                cmd.Parameters.AddWithValue("@11", staffid.Value);
                cmd.Parameters.AddWithValue("@12", pcode.Value);


                //execute insert sql
                int rows = cmd.ExecuteNonQuery();

                //check for success
                String msg = (rows > 0) ? "Stock details updated successfully !!" : "Stock details updating failed !!";

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

        //protected void btndelete_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        //CreateChildControls and open connection
        //        SqlConnection conn = new SqlConnection("server=localhost\\SQLEXPRESS; database=FastLane_DB; integrated security=sspi;");
        //        conn.Open();

        //        //create command object
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = conn;

        //        //assigning values variable concatenation
        //        cmd.CommandText = @"DELETE FROM StockCategory WHERE categoryID='" + categoryid.Value + "';";

        //        //execute insert sql
        //        int rows = cmd.ExecuteNonQuery();

        //        //check for success
        //        String msg = (rows > 0) ? "Stock details updated successfully !!" : "Stock details updating failed !!";

        //        //assign message to label
        //        lblerror.InnerText = msg;

        //        //REFRESH GRID BY INVOKING THE PAGELOAD
        //        Page_Load(null, null);

        //    }
        //    catch (Exception ex)
        //    {
        //        lblerror.InnerText = ex.Message;
        //    }
        //}

        //protected void btnsearch_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        //CreateChildControls and open connection
        //        SqlConnection conn = new SqlConnection("server=localhost\\SQLEXPRESS; database=FastLane_DB; integrated security=sspi;");
        //        conn.Open();

        //        //create command object
        //        SqlCommand cmd = new SqlCommand();
        //        cmd.Connection = conn;

        //        //assigning values variable concatenation
        //        cmd.CommandText = @"SELECT * FROM StockCategory WHERE categoryID LIKE '%" + categoryid.Value + "%';";


        //        //execute select sql
        //        DataSet ds = new DataSet();
        //        SqlDataAdapter da = new SqlDataAdapter(cmd);
        //        da.Fill(ds, "data");

        //        //load search results into gridview
        //        grid.DataSource = ds.Tables[0];
        //        grid.DataBind(); //helps to make sure the data is visible in the grid control

        //        //check for success
        //        String msg = (ds.Tables["data"].Rows.Count > 0) ? "" : "Your search did not yield any results, refine your search and try again !!";

        //        //assign message to label
        //        lblerror.InnerText = msg;

        //    }
        //    catch (Exception ex)
        //    {
        //        lblerror.InnerText = ex.Message;
        //    }
        //}



        //end
    }
}