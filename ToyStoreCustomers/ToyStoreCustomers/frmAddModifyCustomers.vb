Imports ToystoreData

Public Class frmAddModifyCustomers

    Public addCustomer As Boolean
    Private oldCustomer As Customer
    Private newCustomer As Customer

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        If IsValidData() Then
            If addCustomer Then
                'Add customer
                Try
                    newCustomer.Cust_id = CustomerDB.AddCustomer(newCustomer)
                    frmCustomerOrders.customer = newCustomer
                    Me.DialogResult = DialogResult.OK
                Catch ex As Exception
                    MessageBox.Show(ex.Message, ex.GetType.ToString)
                End Try
            Else
                'Modify customer
                Try
                    If CustomerDB.UpdateCustomer(oldCustomer, newCustomer) Then
                        frmCustomerOrders.customer = newCustomer
                        Me.DialogResult = Windows.Forms.DialogResult.OK
                    End If
                Catch ex As Exception
                    MessageBox.Show("Another user has updated or deleted that customer.", "Database Error")
                    Me.DialogResult = DialogResult.Retry
                End Try
            End If
        End If
    End Sub

    Private Sub frmAddModifyCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If addCustomer Then
            Me.Text = "Add Customer"
            newCustomer = New Customer
        Else
            Me.Text = "Modify Customer"
            oldCustomer = frmCustomerOrders.customer
            newCustomer = New Customer
            Me.PutNewCustomer()
        End If
        CustomerBindingSource.Clear()
        CustomerBindingSource.Add(newCustomer)
    End Sub

    Private Sub PutNewCustomer()
        newCustomer.Cust_id = oldCustomer.Cust_id
        newCustomer.Cust_name = oldCustomer.Cust_name
        newCustomer.Cust_address = oldCustomer.Cust_address
        newCustomer.Cust_city = oldCustomer.Cust_city
        newCustomer.Cust_state = oldCustomer.Cust_state
        newCustomer.Cust_zip = oldCustomer.Cust_zip
        newCustomer.Cust_country = oldCustomer.Cust_country
    End Sub

    Private Function IsValidData() As Boolean
        If Validator.IsPresent(Cust_nameTextBox) AndAlso
            Validator.IsPresent(Cust_addressTextBox) AndAlso
            Validator.IsPresent(Cust_cityTextBox) AndAlso
            Validator.IsPresent(Cust_stateTextBox) AndAlso
            Validator.IsPresent(Cust_zipTextBox) AndAlso
            Validator.IsPresent(Cust_countryTextBox) Then
            Return True
        Else
            Return False
        End If
    End Function

End Class