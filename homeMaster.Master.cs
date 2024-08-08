using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace abc20025_fastlane
{
    public partial class homeMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                var firstName = Session["firstName"] ?? "";
                var groupID = Session["groupID"] ?? "";

                //assign current user to master page menu
                currentuser.InnerText = (firstName == "") ? "" : $"{firstName} - [{groupID}]";    //name written on webpage
            }
            catch (Exception ex)
            {
                lblerror.InnerHtml = ex.Message;
            }

        }

        /// end
    }
}