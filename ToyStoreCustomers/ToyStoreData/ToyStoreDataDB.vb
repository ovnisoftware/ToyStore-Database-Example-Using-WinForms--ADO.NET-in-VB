Imports System.Data.SqlClient

Public Class ToyStoreDataDB
    Public Shared Function GetConnection() As SqlConnection
        Dim connectionString As String = "Data Source = localhost\sqlexpress; Integrated Security = true; " &
            "Initial Catalog = ToyStore;"
        Return New SqlConnection(connectionString)
    End Function
End Class