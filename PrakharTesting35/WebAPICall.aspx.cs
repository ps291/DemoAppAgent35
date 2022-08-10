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
                // Function and Action
                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072;
                string url = "https://gorest.co.in/public/v2/users";
                string strResult = string.Empty;
                HttpWebRequest webrequest = (HttpWebRequest)WebRequest.Create(url);
                webrequest.Method = "GET";
                webrequest.ContentType = "application/x-www-form-urlencoded";
                HttpWebResponse webresponse = (HttpWebResponse)webrequest.GetResponse();

                string url0 = "https://services.odata.org/TripPinRESTierService/ResetDataSource";
                string strResult0 = string.Empty;
                HttpWebRequest webrequest0 = (HttpWebRequest)WebRequest.Create(url);
                webrequest.Method = "POST";
                webrequest.ContentType = "application/x-www-form-urlencoded";
                HttpWebResponse webresponse0 = (HttpWebResponse)webrequest.GetResponse();


                string url1 = "https://services.odata.org/TripPinRESTierService/GetNearestAirport(lat = 33, lon = -118)";
                string strResult1 = string.Empty;
                HttpWebRequest webrequest1 = (HttpWebRequest)WebRequest.Create(url);
                webrequest.Method = "GET";
                webrequest.ContentType = "application/x-www-form-urlencoded";
                HttpWebResponse webresponse1 = (HttpWebResponse)webrequest.GetResponse();

                //Querying Data
                string url2 = "https://services.odata.org/TripPinRESTierService/Me/Friends?$filter=Friends/any(f:f/FirstName eq 'Scott')";
                string strResult2 = string.Empty;
                HttpWebRequest webrequest2 = (HttpWebRequest)WebRequest.Create(url);
                webrequest.Method = "GET";
                webrequest.ContentType = "application/x-www-form-urlencoded";
                HttpWebResponse webresponse2 = (HttpWebResponse)webrequest.GetResponse();

                //Querying Data
                string url3 = "https://services.odata.org/TripPinRESTierService/Airports?$filter=contains(Location/Address, 'San Francisco')";
                string strResult3 = string.Empty;
                HttpWebRequest webrequest3 = (HttpWebRequest)WebRequest.Create(url);
                webrequest.Method = "GET";
                webrequest.ContentType = "application/x-www-form-urlencoded";
                HttpWebResponse webresponse3 = (HttpWebResponse)webrequest.GetResponse();

                //Request Etag
                string url4 = "https://services.odata.org/TripPinRESTierService/Airlines";
                string strResult4 = string.Empty;
                HttpWebRequest webrequest4 = (HttpWebRequest)WebRequest.Create(url);
                webrequest.Method = "GET";
                webrequest.ContentType = "application/x-www-form-urlencoded";
                HttpWebResponse webresponse4 = (HttpWebResponse)webrequest.GetResponse();

                //Delete Data
                string url5 = "https://services.odata.org/TripPinRESTierService/People('russellwhyte')";
                string strResult5 = string.Empty;
                HttpWebRequest webrequest5 = (HttpWebRequest)WebRequest.Create(url);
                webrequest.Method = "DELETE";
                webrequest.ContentType = "application/x-www-form-urlencoded";
                HttpWebResponse webresponse5 = (HttpWebResponse)webrequest.GetResponse();

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}