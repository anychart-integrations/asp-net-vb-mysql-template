Imports System
Imports System.Data.Entity
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq
Imports System.Collections.Generic

Partial Public Class FruitDBContext
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=FruitDBContext")
    End Sub

    Public Overridable Property fruits As DbSet(Of fruit)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of fruit)() _
            .Property(Function(e) e.name) _
            .IsUnicode(False)
    End Sub

    Public Function topFruits() As List(Of fruit)
        Return fruits.OrderByDescending(Function(item) item.value).Take(5).ToList()
    End Function
End Class
