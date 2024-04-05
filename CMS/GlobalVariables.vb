Module GlobalVariables
    Public PlateItems As New List(Of PlateItem)
End Module

Public Class PlateItem

    Public Property ProductId As Integer
    Public Property Name As String

    Public Property Price As Decimal

    Public Property Quantity As Integer

    Public Property Image As Image

    Public Property Category As String

    Public Property CategoryId As Integer

    Public Property Discount As Decimal
End Class
