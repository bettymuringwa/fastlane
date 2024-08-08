using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace abc20025_fastlane
{
    public partial class viewproducts : System.Web.UI.Page
    {
        //instantiate class in global section here
        DataAccess da = new DataAccess();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {  //very important to prevent controls reloading and resetting values already selected
                    String sql = @"SELECT productName, categoryID, sellingPrice
                                    from StockEntry where categoryID = 'GR'
                                    ;";

                    DataSet ds = da.GetData(sql);

                    //load USERS INTO GRIDVIEW
                    gridusers.DataSource = ds.Tables["data"];
                    gridusers.DataBind(); //this line binds data to control for viewing, otherwise it wont show data
                }
                //
                if (!IsPostBack)
                {  //very important to prevent controls reloading and resetting values already selected
                    String sql = @"SELECT productName, categoryID, sellingPrice
                                    from StockEntry where categoryID = 'FN'
                                    ;";

                    DataSet ds = da.GetData(sql);

                    //load USERS INTO GRIDVIEW
                    gridf.DataSource = ds.Tables["data"];
                    gridf.DataBind(); //this line binds data to control for viewing, otherwise it wont show data
                }

                if (!IsPostBack)
                {  //very important to prevent controls reloading and resetting values already selected
                    String sql = @"SELECT productName, categoryID, sellingPrice
                                    from StockEntry where categoryID = 'CL'
                                    ;";

                    DataSet ds = da.GetData(sql);

                    //load USERS INTO GRIDVIEW
                    gridc.DataSource = ds.Tables["data"];
                    gridc.DataBind(); //this line binds data to control for viewing, otherwise it wont show data
                }

                if (!IsPostBack)
                {  //very important to prevent controls reloading and resetting values already selected
                    String sql = @"SELECT productName, categoryID, sellingPrice
                                    from StockEntry where categoryID = 'EL'
                                    ;";

                    DataSet ds = da.GetData(sql);

                    //load USERS INTO GRIDVIEW
                    gride.DataSource = ds.Tables["data"];
                    gride.DataBind(); //this line binds data to control for viewing, otherwise it wont show data
                }


            }
            catch (Exception ex)
            {
                lblerror.InnerText = ex.Message;
            }




            //end
        }
    }
}