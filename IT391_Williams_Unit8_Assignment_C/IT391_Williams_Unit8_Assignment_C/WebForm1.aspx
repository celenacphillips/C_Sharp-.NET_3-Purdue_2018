<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="IT391_Williams_Unit8_Assignment_C.WebForm1" %>

<!DOCTYPE html>

<!-- The code on how to insert a Google Maps API borrowed from:
https://developers.google.com/maps/documentation/javascript/tutorial -->

<!-- The information on how to enable my Google Maps API borrowed from:
https://churchthemes.com/page-didnt-load-google-maps-correctly/#MissingKeyMapError -->

<!-- The line to reload the map borrowed from:
https://msdn.microsoft.com/en-us/library/aa478975.aspx -->

<!-- The code to parse the string passed from the C# code to a double borrowed from:
https://www.w3schools.com/jsref/jsref_parseint.asp -->

<!-- The code to create the hidden input to attempt to change the coordinates borrowed from:
https://msdn.microsoft.com/en-us/library/aa478975.aspx -->

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 760px;
        }

        #map {
            height: 100%;
        }

        html, body {
            height: 100%;
            margin: 0;
            padding: 0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 182px">
            <asp:Label ID="Label1" runat="server" Text="Address"></asp:Label>
            <asp:TextBox ID="addressBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="City"></asp:Label>
            <asp:TextBox ID="cityBox" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="State"></asp:Label>
            <asp:DropDownList ID="stateList" runat="server">
                <asp:ListItem Selected="True">Select a State</asp:ListItem>
                <asp:ListItem>AL</asp:ListItem>
                <asp:ListItem>AK</asp:ListItem>
                <asp:ListItem>AZ</asp:ListItem>
                <asp:ListItem>AR</asp:ListItem>
                <asp:ListItem>CA</asp:ListItem>
                <asp:ListItem>CO</asp:ListItem>
                <asp:ListItem>CT</asp:ListItem>
                <asp:ListItem>DE</asp:ListItem>
                <asp:ListItem>FL</asp:ListItem>
                <asp:ListItem>GA</asp:ListItem>
                <asp:ListItem>HI</asp:ListItem>
                <asp:ListItem>ID</asp:ListItem>
                <asp:ListItem>IL</asp:ListItem>
                <asp:ListItem>IN</asp:ListItem>
                <asp:ListItem>IA</asp:ListItem>
                <asp:ListItem>KS</asp:ListItem>
                <asp:ListItem>KY</asp:ListItem>
                <asp:ListItem>LA</asp:ListItem>
                <asp:ListItem>ME</asp:ListItem>
                <asp:ListItem>MD</asp:ListItem>
                <asp:ListItem>MA</asp:ListItem>
                <asp:ListItem>MI</asp:ListItem>
                <asp:ListItem>MN</asp:ListItem>
                <asp:ListItem>MS</asp:ListItem>
                <asp:ListItem>MO</asp:ListItem>
                <asp:ListItem>MT</asp:ListItem>
                <asp:ListItem>NE</asp:ListItem>
                <asp:ListItem>NV</asp:ListItem>
                <asp:ListItem>NH</asp:ListItem>
                <asp:ListItem>NJ</asp:ListItem>
                <asp:ListItem>NM</asp:ListItem>
                <asp:ListItem>NY</asp:ListItem>
                <asp:ListItem>NC</asp:ListItem>
                <asp:ListItem>ND</asp:ListItem>
                <asp:ListItem>OH</asp:ListItem>
                <asp:ListItem>OK</asp:ListItem>
                <asp:ListItem>OR</asp:ListItem>
                <asp:ListItem>PA</asp:ListItem>
                <asp:ListItem>RI</asp:ListItem>
                <asp:ListItem>SC</asp:ListItem>
                <asp:ListItem>SD</asp:ListItem>
                <asp:ListItem>TN</asp:ListItem>
                <asp:ListItem>TX</asp:ListItem>
                <asp:ListItem>UT</asp:ListItem>
                <asp:ListItem>VT</asp:ListItem>
                <asp:ListItem>VA</asp:ListItem>
                <asp:ListItem>WA</asp:ListItem>
                <asp:ListItem>WV</asp:ListItem>
                <asp:ListItem>WI</asp:ListItem>
                <asp:ListItem>WY</asp:ListItem>
            </asp:DropDownList>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Zip Code"></asp:Label>
            <asp:TextBox ID="zipCodeBox" runat="server" MaxLength="5"></asp:TextBox>
            <br />
            <asp:Button ID="submitButton" runat="server" Height="26px" OnClick="Button1_Click" Text="Submit" Width="62px" />
            <input type="button" onclick="buttonPress()" value="Reload Map"/>
            <br />
            <asp:Label ID="Label5" runat="server" Visible="False"></asp:Label>
            <br />
            <asp:Label ID="Label6" runat="server" Visible="False"></asp:Label>

            <input type="hidden" id="latJS" runat="server" value="50" />
            <input type="hidden" id="lngJS" runat="server" value="-80" />
        </div>

        <div id="map"></div>
    <script>
        var map;
        
        function initMap() {
          map = new google.maps.Map(document.getElementById('map'), {
              center: {lat: 30, lng: -90},
              zoom: 4
          });
        }
     </script>
        
    <script src="https://maps.googleapis.com/maps/api/js?key=AIzaSyAmt8_qvyXDILnKZdwsrmfTSGJrCV_jwKI&callback=initMap"
    async defer></script>



        <script type="text/javascript">
            var map;

            function buttonPress() {
                //var latitude = parseDouble($('#latJS').val());
                //var longitude = parseDouble($('#lngJS').val());

                var latitude = 41.5550130;
                var longitude = -90.5505281;

                map = new google.maps.Map(document.getElementById('map'), {
                  center: {lat: latitude, lng: longitude},
                  zoom: 12
                });
            }
        </script>
    </form>
</body>
</html>
