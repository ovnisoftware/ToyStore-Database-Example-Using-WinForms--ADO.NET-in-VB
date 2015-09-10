Imports ToyStoreData

Public Class frmOrderItems
    Public orderNum As Integer

    Private Sub frmOrderItems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim orderItemList As List(Of OrderItem) = OrderItemDB.GetOrderItems(orderNum)
        OrderItemDataGridView.DataSource = orderItemList
        txtOrderNum.Text = orderNum
        txtCustName.Text = frmCustomerOrders.customer.Cust_name
        'Create ProductDB.GetProducts that returns a list of products
        Dim productList As List(Of Product) = ProductDB.GetProducts()

        For Each row As DataGridViewRow In OrderItemDataGridView.Rows
            Dim pid As String = row.Cells(1).Value
            Dim prodName = From product In productList Where product.Prod_id = pid Select product.Prod_name, product.Prod_desc
            For Each Product In prodName
                row.Cells("ProductName").Value = Product.Prod_name
            Next
            Dim quantityCell As DataGridViewCell = row.Cells(2)
            Dim priceCell As DataGridViewCell = row.Cells(3)
            row.Cells("Total").Value = quantityCell.Value * priceCell.Value
        Next
    End Sub
End Class