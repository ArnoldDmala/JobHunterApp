<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GoogMap.aspx.cs" Inherits="JobHunterApp.Models.GoogMap" %>

<!DOCTYPE html>

<html>
<head>
    <title></title>
</head>
<body>
<div id="map"></div>
    <script>
        var map;
        function initMap() {
            map = new google.maps.Map(document.getElementById('map'), {
                center: { lat: -34.397, lng: 150.644 },
                zoom: 8
            });
        }
    </script>
    <script src="https://maps.googleapis.com/maps/api/js?callback=myMap"></script>
</body>
</html>
