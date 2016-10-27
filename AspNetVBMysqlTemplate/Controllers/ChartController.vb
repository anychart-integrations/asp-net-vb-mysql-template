Imports System.Web.Mvc
Imports System.Web.Script.Serialization

Namespace Controllers
    Public Class ChartController
        Inherits Controller

        Private db As New FruitDBContext

        ' GET: Chart
        Function Index() As ActionResult
            Dim fruits As List(Of fruit) = db.topFruits()
            Dim jsonSerialiser As New JavaScriptSerializer
            Dim json = jsonSerialiser.Serialize(fruits)
            ViewBag.Title = "Anychart ASP.NET C# template"
            ViewBag.ChartTitle = "Top 5 fruits"
            ViewBag.ChartData = json
            Return View(fruits)
        End Function
    End Class
End Namespace