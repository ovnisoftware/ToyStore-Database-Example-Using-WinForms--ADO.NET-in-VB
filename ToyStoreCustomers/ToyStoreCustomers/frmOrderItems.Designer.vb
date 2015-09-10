<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderItems
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim Cust_nameLabel As System.Windows.Forms.Label
        Dim Order_numLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtCustName = New System.Windows.Forms.TextBox()
        Me.txtOrderNum = New System.Windows.Forms.TextBox()
        Me.OrderItemDataGridView = New System.Windows.Forms.DataGridView()
        Me.OrderItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Cust_nameLabel = New System.Windows.Forms.Label()
        Order_numLabel = New System.Windows.Forms.Label()
        CType(Me.OrderItemDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cust_nameLabel
        '
        Cust_nameLabel.AutoSize = True
        Cust_nameLabel.Location = New System.Drawing.Point(9, 12)
        Cust_nameLabel.Name = "Cust_nameLabel"
        Cust_nameLabel.Size = New System.Drawing.Size(38, 13)
        Cust_nameLabel.TabIndex = 1
        Cust_nameLabel.Text = "Name:"
        '
        'Order_numLabel
        '
        Order_numLabel.AutoSize = True
        Order_numLabel.Location = New System.Drawing.Point(9, 45)
        Order_numLabel.Name = "Order_numLabel"
        Order_numLabel.Size = New System.Drawing.Size(59, 13)
        Order_numLabel.TabIndex = 3
        Order_numLabel.Text = "Order num:"
        '
        'txtCustName
        '
        Me.txtCustName.Location = New System.Drawing.Point(75, 9)
        Me.txtCustName.Name = "txtCustName"
        Me.txtCustName.ReadOnly = True
        Me.txtCustName.Size = New System.Drawing.Size(289, 20)
        Me.txtCustName.TabIndex = 2
        '
        'txtOrderNum
        '
        Me.txtOrderNum.Location = New System.Drawing.Point(74, 42)
        Me.txtOrderNum.Name = "txtOrderNum"
        Me.txtOrderNum.ReadOnly = True
        Me.txtOrderNum.Size = New System.Drawing.Size(84, 20)
        Me.txtOrderNum.TabIndex = 4
        '
        'OrderItemDataGridView
        '
        Me.OrderItemDataGridView.AllowUserToAddRows = False
        Me.OrderItemDataGridView.AllowUserToDeleteRows = False
        Me.OrderItemDataGridView.AutoGenerateColumns = False
        Me.OrderItemDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrderItemDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn5, Me.Total, Me.ProductName})
        Me.OrderItemDataGridView.DataSource = Me.OrderItemBindingSource
        Me.OrderItemDataGridView.Location = New System.Drawing.Point(12, 68)
        Me.OrderItemDataGridView.Name = "OrderItemDataGridView"
        Me.OrderItemDataGridView.ReadOnly = True
        Me.OrderItemDataGridView.Size = New System.Drawing.Size(655, 220)
        Me.OrderItemDataGridView.TabIndex = 5
        '
        'OrderItemBindingSource
        '
        Me.OrderItemBindingSource.DataSource = GetType(ToyStoreData.OrderItem)
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataSource = GetType(ToyStoreData.Customer)
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataSource = GetType(ToyStoreData.Order)
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Order_item"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Order_item"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Prod_id"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Prod_id"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Quantity"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Quantity"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Item_price"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Item_price"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Order_num"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Order_num"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'Total
        '
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Total.DefaultCellStyle = DataGridViewCellStyle1
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'ProductName
        '
        Me.ProductName.HeaderText = "Product Name"
        Me.ProductName.Name = "ProductName"
        Me.ProductName.ReadOnly = True
        Me.ProductName.Width = 200
        '
        'frmOrderItems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 300)
        Me.Controls.Add(Me.OrderItemDataGridView)
        Me.Controls.Add(Order_numLabel)
        Me.Controls.Add(Me.txtOrderNum)
        Me.Controls.Add(Cust_nameLabel)
        Me.Controls.Add(Me.txtCustName)
        Me.Name = "frmOrderItems"
        Me.Text = "Order Items"
        CType(Me.OrderItemDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtCustName As System.Windows.Forms.TextBox
    Friend WithEvents OrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtOrderNum As System.Windows.Forms.TextBox
    Friend WithEvents OrderItemBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderItemDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProductName As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
