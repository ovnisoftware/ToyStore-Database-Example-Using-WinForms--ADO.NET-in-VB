Imports ToyStoreData

Public Class frmAllCustomers

    Private customerList As List(Of Customer)

    Private Sub frmAllCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Get a list of all customer objects in the database
        customerList = CustomerDB.GetSelectedCustomers("", "")

        'Databind list of customers to listbox
        SingleLineAddressListBox.DataSource = customerList
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