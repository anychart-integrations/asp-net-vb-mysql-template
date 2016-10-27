Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial
Imports System.Web.Script.Serialization

<Table("anychart_db.fruits")>
Partial Public Class fruit
    <ScriptIgnore>
    Public Property id As Integer

    <StringLength(64)>
    Public Property name As String

    Public Property value As Integer?
End Class
