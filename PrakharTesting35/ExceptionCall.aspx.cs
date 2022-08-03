using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PrakharTesting35
{
    public partial class ExceptionCall : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                var c = 0;
                var data = 1 / c;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}