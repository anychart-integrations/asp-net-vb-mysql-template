﻿@ModelType IEnumerable(Of AspNetVBMysqlTemplate.fruit)

@Code
    Layout = Nothing
End Code

<!DOCTYPE html>
<html lang="en">
<head>
    <meta name="viewport" content="width=device-width" />
    <title>@ViewBag.Title</title>
    <script src="https://cdn.anychart.com/releases/v8/js/anychart-base.min.js"></script>
    <script src="https://cdn.anychart.com/releases/v8/js/anychart-exports.min.js"></script>
    <script src="https://cdn.anychart.com/releases/v8/js/anychart-vml.min.js"></script>
    <link rel="stylesheet" href="https://cdn.anychart.com/releases/v8/css/anychart-ui.min.css" />
    <link rel="stylesheet" href="https://cdn.anychart.com/releases/v8/fonts/css/anychart.min.css"/>
    <link rel="stylesheet" href="/css/style.css" />
</head>
<body>
    <div id="container"></div>
    <script>
    anychart.onDocumentReady(function() {
        var chart = anychart.pie(@Html.Raw(ViewBag.ChartData));
        chart.title("@ViewBag.ChartTitle");
        chart.container("container");
        chart.draw();
    });
    </script>
</body>
</html>
