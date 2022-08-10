using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrakharTesting35
{
    public partial class WCFCall : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                AgentDBService.WcfServiceClient wcfServiceClient = new AgentDBService.WcfServiceClient();
                //update
                var updatedata = wcfServiceClient.UpdateAgentData("456");
                //Get
                var data = wcfServiceClient.AgentData();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}