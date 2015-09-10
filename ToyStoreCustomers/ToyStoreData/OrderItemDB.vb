Imports System.Data.SqlClient

Public Class OrderItemDB
    Public Shared Function GetOrderItems(ByVal orderNum As Integer) As List(Of OrderItem)
        Dim orderItemList As New List(Of OrderItem)
        Dim connection As SqlConnection = ToyStoreDataDB.GetConnection
        Dim selectStatement As String = "SELECT * FROM OrderItems WHERE order_num = @order_num;"
        Dim selectCommand As New SqlCommand(selectStatement, connection)
        selectCommand.Parameters.AddWithValue("@order_num", orderNum)
        Try
            connection.Open()
            Dim reader As SqlDataReader = selectCommand.ExecuteReader
            Dim orderItem As OrderItem
            While reader.Read
                orderItem = New OrderItem
                orderItem.Order_num = CInt(reader("order_num"))
                orderItem.Order_item = CInt(reader("order_item"))
                orderItem.Prod_id = CStr(reader("prod_id"))
                orderItem.Quantity = CInt(reader("quantity"))
                orderItem.Item_price = CDec(reader("item_price"))
                orderItemList.Add(orderItem)
            End While
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            connection.Close()
        End Try
        Return orderItemList
    End Function
End Class
