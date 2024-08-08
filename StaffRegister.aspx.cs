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
    public partial class StaffRegister : System.Web.UI.Page
    {
        ////new//
        //SqlConnection conn = new SqlConnection("server = localhost\\SQLEXPRESS; database =FastLane_DB; integrated security=sspi;");
        //SqlCommand cmd;
        //SqlDataAdapter da = new SqlDataAdapter();
        //DataTable dt = new DataTable();

        DataAccess da = new DataAccess();

        protected void Page_Load(object sender, EventArgs e)
        {
            ////method for user group dropdown
            //filldrop();
            //filldrop2();

            //try
            //{
            //    String sql = "select * from UserGroup"; //"select * from information_schema.columns;";
            //    SqlConnection conn = new SqlConnection("server=localhost\\SQLEXPRESS; database=FastLane_DB; integrated security=sspi;");
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    cmd.CommandType = CommandType.Text;

            //    //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //    //DataSet ds = new DataSet();
            //    //da.Fill(ds, "data");

            //    ////load data into grid
            //    //grid.DataSource = ds.Tables["data"];
            //    //grid.DataBind(); //important to bind data

            //}
            //catch (Exception ex)
            //{
            //    lblerror.InnerText = ex.Message;
            //}

            dob.Value = DateTime.Now.ToString("yyyy-MM-dd");
            password.Attributes["type"] = "password"; //set attribute password after showing - circumvent clearing when password already 

        }

        //new
        //private void filldrop2()    //method to put in dropdown
        //{
        //    positionname.DataSource = getgroupdata2();
        //    positionname.DataTextField = "positionName"; //column shown in drop down
        //    positionname.DataValueField = "positionID";
        //    positionname.DataBind();
        //}

        //public DataTable getgroupdata2()
        //{
        //    //throw new NotImplementedException();
        //    cmd = new SqlCommand("getpositiongroup", conn);  //getstaffgroup is a stored procedure with query to bring usergroup name to dropdown

        //    cmd.CommandType = CommandType.StoredProcedure;
        //    da = new SqlDataAdapter(cmd);
        //    dt = new DataTable();
        //    da.Fill(dt);
        //    return dt;
        //}

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
        //    cmd = new SqlCommand("getstaffgroup", conn);  //getstaffgroup is a stored procedure with query to bring usergroup name to dropdown

        //    cmd.CommandType = CommandType.StoredProcedure;
        //    da = new SqlDataAdapter(cmd);
        //    dt = new DataTable();
        //    da.Fill(dt);
        //    return dt;
        //}

        protected void btnregister_Click(object sender, EventArgs e)
        {
            if(FileUpload1.PostedFile != null)
            {
                string strpath = Path.GetExtension(FileUpload1.PostedFile.FileName);
                if (strpath != ".jpg" && strpath != ".jpeg" && strpath != ".gif" && strpath != ".png") //check if image is correct format
                {
                    lblupload.InnerText = "Only .jpg, .jpeg, .gif and .png files are allowed!";
                }
                else
                {
                    lblupload.InnerText = "Picture uploaded!";
                }

                string fileimg = Path.GetFileName(FileUpload1.PostedFile.FileName);
                FileUpload1.SaveAs(Server.MapPath("~/UserImages/") + fileimg);   //path of image to upload


                try
                {

                    //CreateChildControls and open connection
                    SqlConnection conn = new SqlConnection("server=localhost\\SQLEXPRESS; database=FastLane_DB; integrated security=sspi;");
                    conn.Open();

                    //create command object
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = conn;

                    //assigning values through parameters   //best approach to avoid SQL injections
                    cmd.CommandText = $@"INSERT INTO Staff ( staffID, firstName, surname, gender, DateOfBirth, country, town, staffAddress, email, cellNumber, positionID, staffStatus, staffPassword, groupID, profilePicture) 
                                    Values (@0, @1, @2, @3, @4, @5, @6, @7, @8, @9, @10, @11, @12, @13, @14)";
                    //add parameters and values
                    cmd.Parameters.AddWithValue("@0", staffid.Value);
                    cmd.Parameters.AddWithValue("@1", firstname.Value);
                    cmd.Parameters.AddWithValue("@2", surname.Value);
                    cmd.Parameters.AddWithValue("@3", gender.Value);
                    cmd.Parameters.AddWithValue("@4", dob.Value);
                    cmd.Parameters.AddWithValue("@5", country.Value);
                    cmd.Parameters.AddWithValue("@6", town.Value);
                    cmd.Parameters.AddWithValue("@7", staffaddress.Value);
                    cmd.Parameters.AddWithValue("@8", email.Value);
                    cmd.Parameters.AddWithValue("@9", cellno.Value);
                    cmd.Parameters.AddWithValue("@10", positionname.Value);
                    cmd.Parameters.AddWithValue("@11", staffstatus.Value);
                    cmd.Parameters.AddWithValue("@12", password.Value);
                    cmd.Parameters.AddWithValue("@13", groupname.Value);
                    cmd.Parameters.AddWithValue("@14", "~/UserImages/" + fileimg);   //get value from picture file
                    //execute insert sql
                    int rows = cmd.ExecuteNonQuery();

                    //check for success
                    String msg = (rows > 0) ? " Staff Registered Successfully !!" : " Staff Registration Failed !!";

                    //assign message to label
                    lblerror.InnerText = msg;




                }
                catch (Exception ex)
                {
                    lblerror.InnerText = ex.Message;
                }

            }

           

        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            string strpath = Path.GetExtension(FileUpload1.PostedFile.FileName);
            if (strpath != ".jpg" && strpath != ".jpeg" && strpath != ".gif" && strpath != ".png") //check if image is correct format
            {
                lblupload.InnerText = "Only .jpg, .jpeg, .gif and .png files are allowed!";
            }
            else
            {
                lblupload.InnerText = "Picture uploaded!";
            }

            string fileimg = Path.GetFileName(FileUpload1.PostedFile.FileName);
            FileUpload1.SaveAs(Server.MapPath("~/UserImages/") + fileimg);   //path of image to upload

            try
            {

                //CreateChildControls and open connection
                SqlConnection conn = new SqlConnection("server=localhost\\SQLEXPRESS; database=FastLane_DB; integrated security=sspi;");
                conn.Open();

                //create command object
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;


                //assigning values through parameters
                cmd.CommandText = $@"UPDATE Staff SET staffID=@0, firstName=@1, surname=@2, gender=@3, DateOfBirth=@4, country=@5, town=@6, staffAddress=@7, email=@8, cellNumber=@9, positionID=@10, staffStatus=@11, staffPassword=@12, groupID=@13, profilePicture=@14;";
                //add parameters and values
                cmd.Parameters.AddWithValue("@0", staffid.Value);
                cmd.Parameters.AddWithValue("@1", firstname.Value);
                cmd.Parameters.AddWithValue("@2", surname.Value);
                cmd.Parameters.AddWithValue("@3", gender.Value);
                cmd.Parameters.AddWithValue("@4", dob.Value);
                cmd.Parameters.AddWithValue("@5", country.Value);
                cmd.Parameters.AddWithValue("@6", town.Value);
                cmd.Parameters.AddWithValue("@7", staffaddress.Value);
                cmd.Parameters.AddWithValue("@8", email.Value);
                cmd.Parameters.AddWithValue("@9", cellno.Value);
                cmd.Parameters.AddWithValue("@10", positionname.Value);
                cmd.Parameters.AddWithValue("@11", staffstatus.Value);
                cmd.Parameters.AddWithValue("@12", password.Value);
                cmd.Parameters.AddWithValue("@13", groupname.Value);
                cmd.Parameters.AddWithValue("@14", "~/UserImages/" + fileimg);   //get value from picture file


                //execute insert sql
                int rows = cmd.ExecuteNonQuery();

                //check for success
                String msg = (rows > 0) ? "Staff details updated successfully !!" : "Staff details updating failed !!";

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