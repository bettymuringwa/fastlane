using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace abc20025_fastlane
{
    public class DataAccess
    { 
        public DataAccess() { }

        //global read minimum age allowed to register from app settings in web.config and enforce on registration
        //public readonly int MinRegistrationAge = Convert.ToInt32(System.Configuration.ConfigurationManager.AppSettings["MinRegistrationAge"]);


        //GetConnection method creating SQL connection using the connection string in web.config file to access the database.
      //method used to get the sql connection from web.config file to access the database
        private SqlConnection GetConnection()         
        {
            String constring = System.Configuration.ConfigurationManager.ConnectionStrings["devcon"].ConnectionString;
            return new SqlConnection(constring);
           
        }

        //data set: in memory database in computer 
        public DataSet GetData(string sql) //parameter
        {
            try
            {
                using (SqlConnection conn = GetConnection())
                {
                    conn.Open();          //open sql connection
                    SqlCommand cmd = new SqlCommand(sql, conn);       //create command > sql
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "data");
                    return ds;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public int ExecuteCommand(String sql, Object[] arrparams)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                //create command
                SqlCommand cmd = new SqlCommand(sql, conn);
                //add parameters
                if (arrparams != null)
                {
                    for (int k = 0; k < arrparams.Length; k++)
                    {
                        String param = String.Format("@{0}", k);                   //new param char setting
                        var reg = new System.Text.RegularExpressions.Regex(@"\?"); //param char specification
                        sql = reg.Replace(sql, param, 1);                          //replace param character, 1 char per round
                        cmd.Parameters.AddWithValue(param, arrparams[k]);          //add param and value
                    }
                    //assign updated command text
                    cmd.CommandText = sql;
                }
                //execute
                int rows = cmd.ExecuteNonQuery();
                return rows; //return
            }
        }

        //method to load htmlselect from database
        public void LoadHtmlSelect(System.Web.UI.HtmlControls.HtmlSelect ctlselect, DataSet ds, String strTableName = "", String KeyColumnName = "", String ValueColumnName = "")
        {
            try
            {
                strTableName = (strTableName == "") ? ds.Tables[0].TableName : strTableName;
                KeyColumnName = (KeyColumnName == "") ? ds.Tables[strTableName].Columns[0].ColumnName : KeyColumnName;
                ValueColumnName = (ValueColumnName == "") ? ds.Tables[strTableName].Columns[1].ColumnName : ValueColumnName;
                DataTable dt = ds.Tables[0].Copy();
                dt.Rows.Add(0, "Select...");
                dt = dt.AsEnumerable().OrderBy(r => r[0]).ThenBy(x => x[1]).CopyToDataTable(); //orders by first and second column
                //dt.DefaultView.Sort= dt.Columns[0].ColumnName + " ASC"; //order by first column
                ctlselect.DataSource = dt;
                ctlselect.DataValueField = dt.Columns[KeyColumnName].ColumnName;
                ctlselect.DataTextField = dt.Columns[ValueColumnName].ColumnName;
                ctlselect.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        ////load gridview
        //public void LoadGridView(System.Web.UI.WebControls.GridView grid, DataSet ds, String strTableName = "")
        //{
        //    try
        //    {
        //        strTableName = (strTableName == "") ? ds.Tables[0].TableName : strTableName;
        //        grid.DataSource = ds.Tables[strTableName];
        //        grid.DataBind();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}







        ///////////////no code here or below//////////
    } 
} 