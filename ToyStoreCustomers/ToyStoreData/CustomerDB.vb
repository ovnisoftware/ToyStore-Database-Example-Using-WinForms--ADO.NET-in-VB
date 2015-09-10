Imports System.Data.SqlClient

Public Class CustomerDB

    Public Shared Function AddCustomer(ByVal customer As Customer) As String
        Dim connection As SqlConnection = ToyStoreDataDB.GetConnection
        Dim insertStatement As String = "INSERT Customers (cust_name, cust_address, cust_city, cust_state, " &
            "cust_zip, cust_country) VALUES (@cust_name, @cust_address, @cust_city, @cust_state, @cust_zip, " &
            "@cust_country);"
        Dim insertcommand As New SqlCommand(insertStatement, connection)
        insertcommand.Parameters.AddWithValue("@cust_name", customer.Cust_name)
        insertcommand.Parameters.AddWithValue("@cust_address", customer.Cust_address)
        insertcommand.Parameters.AddWithValue("@cust_city", customer.Cust_city)
        insertcommand.Parameters.AddWithValue("@cust_state", customer.Cust_state)
        insertcommand.Parameters.AddWithValue("@cust_zip", customer.Cust_zip)
        insertcommand.Parameters.AddWithValue("@cust_country", customer.Cust_country)
        Try
            connection.Open()
            insertcommand.ExecuteNonQuery()
            Dim selectStatement As String = "SELECT DISTINCT IDENT_CURRENT('Customers') FROM Customers"
            Dim selectCommand As New SqlCommand(selectStatement, connection)
            Dim customerID As Integer = CInt(selectCommand.ExecuteScalar)
            Return customerID
        Catch ex As Exception
            Throw ex
        Finally
            connection.Close()
        End Try

    End Function

    Public Shared Function GetSelectedCustomers(ByVal name As String, ByVal state As String) As List(Of Customer)
        Dim customerList As New List(Of Customer)
        Dim connection As SqlConnection = ToyStoreDataDB.GetConnection
        Dim selectStatement As String = "SELECT * " &
            "FROM Customers " &
            "WHERE (cust_name LIKE @cust_name) AND (cust_state LIKE @cust_state) " &
            "Order by cust_name;"
        Dim selectCommand As New SqlCommand(selectStatement, connection)
        selectCommand.Parameters.AddWithValue("@cust_name", name & "%")
        selectCommand.Parameters.AddWithValue("@cust_state", state & "%")

        Try
            connection.Open()
            Dim reader As SqlDataReader = selectCommand.ExecuteReader
            Dim customer As Customer
            While reader.Read
                customer = New Customer
                customer.Cust_id = reader("cust_id").ToString
                customer.Cust_name = reader("cust_name").ToString
                customer.Cust_address = reader("cust_address").ToString
                customer.Cust_city = reader("cust_city").ToString
                customer.Cust_state = reader("cust_state").ToString
                customer.Cust_zip = reader("cust_zip").ToString
                customer.Cust_country = reader("cust_country").ToString
                customerList.Add(customer)
            End While
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            connection.Close()
        End Try
        Return customerList
    End Function

    Public Shared Function GetCustomerByID(ByVal custID As String) As Customer
        Dim customer As New Customer
        Dim connection As SqlConnection = ToyStoreDataDB.GetConnection
        'Get rid of * and specify columns?
        Dim selectStatement As String = "SELECT * " &
            "FROM Customers " &
            "WHERE cust_id = @cust_id;"
        Dim selectCommand As New SqlCommand(selectStatement, connection)
        selectCommand.Parameters.AddWithValue("@cust_id", custID)

        Try
            connection.Open()
            Dim reader As SqlDataReader = selectCommand.ExecuteReader()
            If reader.Read Then
                customer.Cust_id = reader("cust_id").ToString
                customer.Cust_name = reader("cust_name").ToString
                customer.Cust_address = reader("cust_address").ToString
                customer.Cust_city = reader("cust_city").ToString
                customer.Cust_state = reader("cust_state").ToString
                customer.Cust_zip = reader("cust_zip").ToString
                customer.Cust_country = reader("cust_country").ToString
            Else
                customer = Nothing
            End If
            reader.Close()
        Catch ex As Exception
            Throw ex
        Finally
            connection.Close()
        End Try
        Return customer
    End Function

    Public Shared Function UpdateCustomer(ByVal oldCustomer As Customer, ByVal newCustomer As Customer) As Boolean
        Dim connection As SqlConnection = ToyStoreDataDB.GetConnection
        Dim updateStatement As String = "UPDATE Customers SET cust_name = @newcust_name, " &
            "cust_address = @newcust_address, " &
            "cust_city = @newcust_city, " &
            "cust_state = @newcust_state, " &
            "cust_zip = @newcust_zip, " &
            "cust_country = @newcust_country WHERE " &
            "cust_id = @oldcust_id AND " &
            "cust_name = @oldcust_name AND " &
            "cust_address = @oldcust_address AND " &
            "cust_city = @oldcust_city AND " &
            "cust_state = @oldcust_state AND " &
            "cust_zip = @oldcust_zip AND " &
            "cust_country = @oldcust_country "
        Dim updateCommand As New SqlCommand(updateStatement, connection)
        updateCommand.Parameters.AddWithValue("@newcust_name", newCustomer.Cust_name)
        updateCommand.Parameters.AddWithValue("@newcust_address", newCustomer.Cust_address)
        updateCommand.Parameters.AddWithValue("@newcust_city", newCustomer.Cust_city)
        updateCommand.Parameters.AddWithValue("@newcust_state", newCustomer.Cust_state)
        updateCommand.Parameters.AddWithValue("@newcust_zip", newCustomer.Cust_zip)
        updateCommand.Parameters.AddWithValue("@newcust_country", newCustomer.Cust_country)
        updateCommand.Parameters.AddWithValue("@oldcust_id", oldCustomer.Cust_id)
        updateCommand.Parameters.AddWithValue("@oldcust_name", oldCustomer.Cust_name)
        updateCommand.Parameters.AddWithValue("@oldcust_address", oldCustomer.Cust_address)
        updateCommand.Parameters.AddWithValue("@oldcust_city", oldCustomer.Cust_city)
        updateCommand.Parameters.AddWithValue("@oldcust_state", oldCustomer.Cust_state)
        updateCommand.Parameters.AddWithValue("@oldcust_zip", oldCustomer.Cust_zip)
        updateCommand.Parameters.AddWithValue("@oldcust_country", oldCustomer.Cust_country)
        Try
            connection.Open()
            Dim count As Integer = updateCommand.ExecuteNonQuery()
            If count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Throw ex
        Finally
            connection.Close()
        End Try
    End Function

End Class