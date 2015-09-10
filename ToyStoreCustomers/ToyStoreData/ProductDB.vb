Imports System.Data.SqlClient

Public Class ProductDB
    Public Shared Function GetProducts() As List(Of Product)
        Dim productList As New List(Of Product)
        Dim connection As SqlConnection = ToyStoreDataDB.GetConnection
        Dim selectStatement As String = "SELECT * FROM Products"
        Dim selectCommand As New SqlCommand(selectStatement, connection)

        Try
            connection.Open()
            Dim reader As SqlDataReader = selectCommand.ExecuteReader
            Dim product As Product
            While reader.Read
                product = New Product
                product.Prod_id = reader("prod_id").ToString
                product.Vend_id = reader("vend_id").ToString
                product.Prod_name = reader("prod_name").ToString
                product.Prod_price = CDec(reader("prod_price"))
                product.Prod_desc = reader("prod_desc").ToString
                productList.Add(product)
            End While
        Catch ex As Exception
            Throw ex
        Finally
            connection.Close()
        End Try
        Return productList
    End Function
End Class
