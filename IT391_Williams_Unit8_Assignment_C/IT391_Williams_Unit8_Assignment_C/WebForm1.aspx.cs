using System;
using System.Collections.Generic;
using System.Net;
using System.Web.UI;
using System.Xml.Linq;
using System.Web.Services;

namespace IT391_Williams_Unit8_Assignment_C
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        Boolean noNulls = false;
        Boolean noSpecials = false;
        public string lttd, lngtd;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (addressBox.Text.Equals(null) || addressBox.Text.Equals("") ||
                 cityBox.Text.Equals(null) || cityBox.Text.Equals("") ||
                 zipCodeBox.Text.Equals(null) || zipCodeBox.Text.Equals(""))
            {
                Label5.Text = "Value cannot be null. Please enter a value first.";
                Label5.Visible = true;
                noNulls = false;
            }
            else
            {
                Label5.Visible = false;
                noNulls = true;
            }

            string zip = zipCodeBox.Text.ToUpper();

            if (zip.Contains("A") || zip.Contains("B") || zip.Contains("C") ||
                zip.Contains("D") || zip.Contains("E") || zip.Contains("F") ||
                zip.Contains("G") || zip.Contains("H") || zip.Contains("I") ||
                zip.Contains("J") || zip.Contains("K") || zip.Contains("L") ||
                zip.Contains("M") || zip.Contains("N") || zip.Contains("O") ||
                zip.Contains("P") || zip.Contains("Q") || zip.Contains("R") ||
                zip.Contains("S") || zip.Contains("T") || zip.Contains("U") ||
                zip.Contains("V") || zip.Contains("W") || zip.Contains("X") ||
                zip.Contains("Y") || zip.Contains("Z") || zip.Contains("!") ||
                zip.Contains("@") || zip.Contains("#") || zip.Contains("$") ||
                zip.Contains("%") || zip.Contains("^") || zip.Contains("&") ||
                zip.Contains("*") || zip.Contains("(") || zip.Contains(")") ||
                zip.Contains("`") || zip.Contains("~") || zip.Contains("-") ||
                zip.Contains("_") || zip.Contains("=") || zip.Contains("+") ||
                zip.Contains("[") || zip.Contains("]") || zip.Contains("{") ||
                zip.Contains("}") || zip.Contains("\\") || zip.Contains("|") ||
                zip.Contains(";") || zip.Contains(":") || zip.Contains("'") ||
                zip.Contains("\"") || zip.Contains(",") || zip.Contains(".") ||
                zip.Contains("/") || zip.Contains("<") || zip.Contains(">") ||
                zip.Contains("?"))
            {
                Label6.Text = "Zip code cannot contain special characters. Please enter a valid zip code.";
                Label6.Visible = true;
                noSpecials = false;
            }
            else
            {
                Label6.Visible = false;
                noSpecials = true;
            }


            //The code used to format the data for the Google Geocoding API borrowed from:
            //https://stackoverflow.com/questions/16274508/how-to-call-google-geocoding-service-from-c-sharp-code

            //The code used to access the JavaScript function borrowed from:
            //https://stackoverflow.com/questions/5731224/calling-javascript-function-from-codebehind
            if (noNulls && noSpecials)
            {
                string address = addressBox.Text + ", " + cityBox.Text;
                string requestUri = string.Format("http://maps.googleapis.com/maps/api/geocode/xml?address={0}&sensor=false", Uri.EscapeDataString(address));

                WebRequest request = WebRequest.Create(requestUri);
                WebResponse response = request.GetResponse();
                XDocument xdoc = XDocument.Load(response.GetResponseStream());

                XElement result = xdoc.Element("GeocodeResponse").Element("result");
                XElement locationElement = result.Element("geometry").Element("location");
                XElement lat = locationElement.Element("lat");
                XElement lng = locationElement.Element("lng");
                lttd = lat.ToString();
                lngtd = lng.ToString();
                Label5.Text = "Latitude: " + lttd;
                Label6.Text = "Longitude: " + lngtd;
                Label5.Visible = true;
                Label6.Visible = true;

                latJS.Value = lttd;
                lngJS.Value = lngtd;
            }
        }
    }
}