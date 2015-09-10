Imports ToyStoreData

Public Class frmFindCustomer
    Private customerList As List(Of Customer)

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        customerList = CustomerDB.GetSelectedCustomers(txtName.Text, txtState.Text)
        SingleLineAddressListBox.DataSource = customerList

        Select Case customerList.Count
            Case 0
                lblMessage.Text = "No customers found with that name and state."
            Case 1
                lblMessage.Text = "One customer found with that name and state"
            Case 2
                lblMessage.Text = SingleLineAddressListBox.Items.Count & " customers found with that name and state."
        End Select
        SingleLineAddressListBox.SelectedIndex = -1
        btnOK.Enabled = False
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        frmCustomerOrders.customer = customerList(SingleLineAddressListBox.SelectedIndex)
    End Sub

    Private Sub SingleLineAddressListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SingleLineAddressListBox.SelectedIndexChanged
        btnOK.Enabled = True
    End Sub

    Private Sub SingleLineAddressListBox_DoubleClick(sender As Object, e As EventArgs) Handles SingleLineAddressListBox.DoubleClick
        frmCustomerOrders.customer = customerList(SingleLineAddressListBox.SelectedIndex)
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

End Class