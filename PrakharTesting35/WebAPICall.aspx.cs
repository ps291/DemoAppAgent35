using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ThirdParty.Json.LitJson;

namespace PrakharTesting35
{
    public partial class WebAPICall : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://gorest.co.in/public/v2/users");
                request.Method = "GET";
                request.ContentType = "application/json";
                WebResponse response = request.GetResponse();
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    var ApiStatus = reader.ReadToEnd();
                    JsonData data = JsonMapper.ToObject(ApiStatus);
                }

                }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}