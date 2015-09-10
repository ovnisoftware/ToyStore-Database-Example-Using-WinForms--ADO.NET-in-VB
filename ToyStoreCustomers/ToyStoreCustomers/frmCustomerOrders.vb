Imports ToyStoreData

Public Class frmCustomerOrders
    Public customer As Customer
    Private orderList As List(Of Order)

    Private Sub btnGetCustomer_Click(sender As Object, e As EventArgs) Handles btnGetCustomer.Click
        Dim customerID As String = Cust_idTextBox.Text
        If (customerID <> "") AndAlso (IsNumeric(customerID)) Then
            Try
                customer = CustomerDB.GetCustomerByID(customerID)
                If customer Is Nothing Then
                    MessageBox.Show("Please enter a valid customer id")
                Else
                    CustomerBindingSource.Clear()
                    CustomerBindingSource.Add(customer)
                    Me.GetCustomerOrders()
                    btnModifyCustomer.Enabled = True
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, ex.GetType.ToString)
            End Try
        Else
            MessageBox.Show("Please enter a numeric customer id.")
        End If
    End Sub

    Private Sub GetCustomerOrders()
        Try
            orderList = OrderDB.GetCustomerOrders(customer.Cust_id)
            OrderDataGridView.DataSource = orderList
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType.ToString)
        End Try
    End Sub

    Private Sub btnFindCustomer_Click(sender As Object, e As EventArgs) Handles btnFindCustomer.Click
        Dim findCustomerForm As New frmFindCustomer
        Dim result As DialogResult = findCustomerForm.ShowDialog
        If result = Windows.Forms.DialogResult.OK Then
            Cust_idTextBox.Text = customer.Cust_id
            CustomerBindingSource.Clear()
            CustomerBindingSource.Add(customer)
            btnModifyCustomer.Enabled = True
        End If
    End Sub

    Private Sub btnListAllCustomers_Click(sender As Object, e As EventArgs) Handles btnListAllCustomers.Click
        Dim AllCustomersForm As New frmAllCustomers
        Dim result As DialogResult = AllCustomersForm.ShowDialog
        If result = Windows.Forms.DialogResult.OK Then
            Cust_idTextBox.Text = customer.Cust_id
            CustomerBindingSource.Clear()
            CustomerBindingSource.Add(customer)
            btnModifyCustomer.Enabled = True
        End If
    End Sub

    Private Sub btnAddCustomer_Click(sender As Object, e As EventArgs) Handles btnAddCustomer.Click
        Dim AlterCustomerForm = New frmAddModifyCustomers
        AlterCustomerForm.addCustomer = True
        Dim result As DialogResult = AlterCustomerForm.ShowDialog
        If result = Windows.Forms.DialogResult.OK Then
            CustomerBindingSource.Clear()
            CustomerBindingSource.Add(customer)
            Cust_idTextBox.Text = customer.Cust_id
        End If
    End Sub

    Private Sub btnModifyCustomer_Click(sender As Object, e As EventArgs) Handles btnModifyCustomer.Click
        Dim ModiftyCustomerForm = New frmAddModifyCustomers
        ModiftyCustomerForm.addCustomer = False
        Dim result As DialogResult = ModiftyCustomerForm.ShowDialog
        If result = Windows.Forms.DialogResult.OK Then
            CustomerBindingSource.Clear()
            CustomerBindingSource.Add(customer)
            Cust_idTextBox.Text = customer.Cust_id
        End If
    End Sub

    Private Sub OrderDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles OrderDataGridView.CellContentClick
        If e.ColumnIndex = 3 Then
            Dim i As Integer = e.RowIndex
            Dim row As DataGridViewRow = OrderDataGridView.Rows(i)
            Dim order As Order = CType(row.DataBoundItem, Order)

            Dim orderItemForm As New frmOrderItems
            orderItemForm.orderNum = order.Order_num
            orderItemForm.ShowDialog()
        End If
    End Sub
End Class
