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
                ServiceReference2.Service1Client wcfServiceClient = new ServiceReference2.Service1Client();
                var data = wcfServiceClient.GetData(10001);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}