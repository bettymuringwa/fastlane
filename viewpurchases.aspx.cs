using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace abc20025_fastlane
{
    public partial class viewpurchases : System.Web.UI.Page
    {
        //instantiate class in global section here
        DataAccess da = new DataAccess();
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {  //very important to prevent controls reloading and resetting values already selected
                    String sql = @"SELECT a.transactionID, a.transactionDate, a.transactionTime, a.customerID, a.product, 
                                        a.quantity, a.price, a.amount
                                     from Purchases a, Customers b
                                        where a.customerID = B.customerID
                                     ;";

                    DataSet ds = da.GetData(sql);

                    //load USERS INTO GRIDVIEW
                    gridusers.DataSource = ds.Tables["data"];
                    gridusers.DataBind(); //this line binds data to control for viewing, otherwise it wont show data
                }
                //
            }
            catch (Exception ex)
            {
                lblerror.InnerText = ex.Message;
            }
        }
    
    }
}