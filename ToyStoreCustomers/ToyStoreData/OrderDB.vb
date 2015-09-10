Imports System.Data.SqlClient

Public Class OrderDB
    Public Shared Function GetCustomerOrders(ByVal CustomerID As Integer) As List(Of Order)
        Dim orderList As New List(Of Order)
        Dim connection As SqlConnection = ToyStoreDataDB.GetConnection
        Dim selectStatement As String = "SELECT * FROM Orders WHERE cust_id = @cust_id ORDER BY order_date desc;"
        Dim selectCommand As New SqlCommand(selectStatement, connection)
        selectCommand.Parameters.AddWithValue("@cust_id", CustomerID)
        Try
            connection.Open()
            Dim reader As SqlDataReader = selectCommand.ExecuteReader
            Dim order As New Order
            While (reader.Read)
                order = New Order
                order.Cust_id = CInt(reader("cust_id"))
                order.Order_date = CDate(reader("order_date"))
                order.Order_num = CStr(reader("order_num"))
                orderList.Add(order)
            End While
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            connection.Close()
        End Try
        Return orderList
    End Function
End Class
