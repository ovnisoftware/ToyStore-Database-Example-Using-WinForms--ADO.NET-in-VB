<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerOrders
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
        Dim Cust_idLabel As System.Windows.Forms.Label
        Dim Cust_nameLabel As System.Windows.Forms.Label
        Dim Cust_addressLabel As System.Windows.Forms.Label
        Dim Cust_cityLabel As System.Windows.Forms.Label
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cust_idTextBox = New System.Windows.Forms.TextBox()
        Me.btnGetCustomer = New System.Windows.Forms.Button()
        Me.btnFindCustomer = New System.Windows.Forms.Button()
        Me.Cust_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Cust_addressTextBox = New System.Windows.Forms.TextBox()
        Me.Cust_cityTextBox = New System.Windows.Forms.TextBox()
        Me.Cust_stateTextBox = New System.Windows.Forms.TextBox()
        Me.Cust_zipTextBox = New System.Windows.Forms.TextBox()
        Me.Cust_countryTextBox = New System.Windows.Forms.TextBox()
        Me.btnListAllCustomers = New System.Windows.Forms.Button()
        Me.btnAddCustomer = New System.Windows.Forms.Button()
        Me.btnModifyCustomer = New System.Windows.Forms.Button()
        Me.OrderDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ViewOrderItems = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.OrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Cust_idLabel = New System.Windows.Forms.Label()
        Cust_nameLabel = New System.Windows.Forms.Label()
        Cust_addressLabel = New System.Windows.Forms.Label()
        Cust_cityLabel = New System.Windows.Forms.Label()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cust_idLabel
        '
        Cust_idLabel.AutoSize = True
        Cust_idLabel.Location = New System.Drawing.Point(11, 17)
        Cust_idLabel.Name = "Cust_idLabel"
        Cust_idLabel.Size = New System.Drawing.Size(42, 13)
        Cust_idLabel.TabIndex = 1
        Cust_idLabel.Text = "Cust id:"
        '
        'Cust_nameLabel
        '
        Cust_nameLabel.AutoSize = True
        Cust_nameLabel.Location = New System.Drawing.Point(11, 55)
        Cust_nameLabel.Name = "Cust_nameLabel"
        Cust_nameLabel.Size = New System.Drawing.Size(38, 13)
        Cust_nameLabel.TabIndex = 5
        Cust_nameLabel.Text = "Name:"
        '
        'Cust_addressLabel
        '
        Cust_addressLabel.AutoSize = True
        Cust_addressLabel.Location = New System.Drawing.Point(11, 89)
        Cust_addressLabel.Name = "Cust_addressLabel"
        Cust_addressLabel.Size = New System.Drawing.Size(48, 13)
        Cust_addressLabel.TabIndex = 7
        Cust_addressLabel.Text = "Address:"
        '
        'Cust_cityLabel
        '
        Cust_cityLabel.AutoSize = True
        Cust_cityLabel.Location = New System.Drawing.Point(11, 119)
        Cust_cityLabel.Name = "Cust_cityLabel"
        Cust_cityLabel.Size = New System.Drawing.Size(121, 13)
        Cust_cityLabel.TabIndex = 9
        Cust_cityLabel.Text = "City, State, Zip, Country:"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataSource = GetType(ToyStoreData.Customer)
        '
        'Cust_idTextBox
        '
        Me.Cust_idTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_id", True))
        Me.Cust_idTextBox.Location = New System.Drawing.Point(59, 14)
        Me.Cust_idTextBox.Name = "Cust_idTextBox"
        Me.Cust_idTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cust_idTextBox.TabIndex = 2
        '
        'btnGetCustomer
        '
        Me.btnGetCustomer.Location = New System.Drawing.Point(165, 12)
        Me.btnGetCustomer.Name = "btnGetCustomer"
        Me.btnGetCustomer.Size = New System.Drawing.Size(103, 23)
        Me.btnGetCustomer.TabIndex = 3
        Me.btnGetCustomer.Text = "Get Customer"
        Me.btnGetCustomer.UseVisualStyleBackColor = True
        '
        'btnFindCustomer
        '
        Me.btnFindCustomer.Location = New System.Drawing.Point(272, 12)
        Me.btnFindCustomer.Name = "btnFindCustomer"
        Me.btnFindCustomer.Size = New System.Drawing.Size(103, 23)
        Me.btnFindCustomer.TabIndex = 4
        Me.btnFindCustomer.Text = "Find Customer"
        Me.btnFindCustomer.UseVisualStyleBackColor = True
        '
        'Cust_nameTextBox
        '
        Me.Cust_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_name", True))
        Me.Cust_nameTextBox.Location = New System.Drawing.Point(138, 55)
        Me.Cust_nameTextBox.Name = "Cust_nameTextBox"
        Me.Cust_nameTextBox.ReadOnly = True
        Me.Cust_nameTextBox.Size = New System.Drawing.Size(363, 20)
        Me.Cust_nameTextBox.TabIndex = 6
        '
        'Cust_addressTextBox
        '
        Me.Cust_addressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_address", True))
        Me.Cust_addressTextBox.Location = New System.Drawing.Point(138, 86)
        Me.Cust_addressTextBox.Name = "Cust_addressTextBox"
        Me.Cust_addressTextBox.ReadOnly = True
        Me.Cust_addressTextBox.Size = New System.Drawing.Size(363, 20)
        Me.Cust_addressTextBox.TabIndex = 8
        '
        'Cust_cityTextBox
        '
        Me.Cust_cityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_city", True))
        Me.Cust_cityTextBox.Location = New System.Drawing.Point(138, 116)
        Me.Cust_cityTextBox.Name = "Cust_cityTextBox"
        Me.Cust_cityTextBox.ReadOnly = True
        Me.Cust_cityTextBox.Size = New System.Drawing.Size(165, 20)
        Me.Cust_cityTextBox.TabIndex = 10
        '
        'Cust_stateTextBox
        '
        Me.Cust_stateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_state", True))
        Me.Cust_stateTextBox.Location = New System.Drawing.Point(309, 116)
        Me.Cust_stateTextBox.Name = "Cust_stateTextBox"
        Me.Cust_stateTextBox.ReadOnly = True
        Me.Cust_stateTextBox.Size = New System.Drawing.Size(41, 20)
        Me.Cust_stateTextBox.TabIndex = 12
        '
        'Cust_zipTextBox
        '
        Me.Cust_zipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_zip", True))
        Me.Cust_zipTextBox.Location = New System.Drawing.Point(356, 116)
        Me.Cust_zipTextBox.Name = "Cust_zipTextBox"
        Me.Cust_zipTextBox.ReadOnly = True
        Me.Cust_zipTextBox.Size = New System.Drawing.Size(78, 20)
        Me.Cust_zipTextBox.TabIndex = 14
        '
        'Cust_countryTextBox
        '
        Me.Cust_countryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_country", True))
        Me.Cust_countryTextBox.Location = New System.Drawing.Point(440, 116)
        Me.Cust_countryTextBox.Name = "Cust_countryTextBox"
        Me.Cust_countryTextBox.ReadOnly = True
        Me.Cust_countryTextBox.Size = New System.Drawing.Size(61, 20)
        Me.Cust_countryTextBox.TabIndex = 16
        '
        'btnListAllCustomers
        '
        Me.btnListAllCustomers.Location = New System.Drawing.Point(379, 12)
        Me.btnListAllCustomers.Name = "btnListAllCustomers"
        Me.btnListAllCustomers.Size = New System.Drawing.Size(103, 23)
        Me.btnListAllCustomers.TabIndex = 17
        Me.btnListAllCustomers.Text = "List All Customers"
        Me.btnListAllCustomers.UseVisualStyleBackColor = True
        '
        'btnAddCustomer
        '
        Me.btnAddCustomer.Location = New System.Drawing.Point(517, 53)
        Me.btnAddCustomer.Name = "btnAddCustomer"
        Me.btnAddCustomer.Size = New System.Drawing.Size(101, 23)
        Me.btnAddCustomer.TabIndex = 18
        Me.btnAddCustomer.Text = "Add Customer"
        Me.btnAddCustomer.UseVisualStyleBackColor = True
        '
        'btnModifyCustomer
        '
        Me.btnModifyCustomer.Enabled = False
        Me.btnModifyCustomer.Location = New System.Drawing.Point(517, 86)
        Me.btnModifyCustomer.Name = "btnModifyCustomer"
        Me.btnModifyCustomer.Size = New System.Drawing.Size(101, 23)
        Me.btnModifyCustomer.TabIndex = 19
        Me.btnModifyCustomer.Text = "Modify Customer"
        Me.btnModifyCustomer.UseVisualStyleBackColor = True
        '
        'OrderDataGridView
        '
        Me.OrderDataGridView.AllowUserToAddRows = False
        Me.OrderDataGridView.AllowUserToDeleteRows = False
        Me.OrderDataGridView.AutoGenerateColumns = False
        Me.OrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.OrderDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.ViewOrderItems})
        Me.OrderDataGridView.DataSource = Me.OrderBindingSource
        Me.OrderDataGridView.Location = New System.Drawing.Point(14, 153)
        Me.OrderDataGridView.Name = "OrderDataGridView"
        Me.OrderDataGridView.ReadOnly = True
        Me.OrderDataGridView.Size = New System.Drawing.Size(651, 176)
        Me.OrderDataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Cust_id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Cust_id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Order_date"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Order_date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Order_num"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Order_num"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'ViewOrderItems
        '
        Me.ViewOrderItems.HeaderText = ""
        Me.ViewOrderItems.Name = "ViewOrderItems"
        Me.ViewOrderItems.ReadOnly = True
        Me.ViewOrderItems.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ViewOrderItems.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ViewOrderItems.Text = "View Order Items"
        Me.ViewOrderItems.UseColumnTextForButtonValue = True
        '
        'OrderBindingSource
        '
        Me.OrderBindingSource.DataSource = GetType(ToyStoreData.Order)
        '
        'frmCustomerOrders
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(678, 341)
        Me.Controls.Add(Me.OrderDataGridView)
        Me.Controls.Add(Me.btnModifyCustomer)
        Me.Controls.Add(Me.btnAddCustomer)
        Me.Controls.Add(Me.btnListAllCustomers)
        Me.Controls.Add(Me.Cust_countryTextBox)
        Me.Controls.Add(Me.Cust_zipTextBox)
        Me.Controls.Add(Me.Cust_stateTextBox)
        Me.Controls.Add(Cust_cityLabel)
        Me.Controls.Add(Me.Cust_cityTextBox)
        Me.Controls.Add(Cust_addressLabel)
        Me.Controls.Add(Me.Cust_addressTextBox)
        Me.Controls.Add(Cust_nameLabel)
        Me.Controls.Add(Me.Cust_nameTextBox)
        Me.Controls.Add(Me.btnFindCustomer)
        Me.Controls.Add(Me.btnGetCustomer)
        Me.Controls.Add(Cust_idLabel)
        Me.Controls.Add(Me.Cust_idTextBox)
        Me.Name = "frmCustomerOrders"
        Me.Text = "Customer Orders"
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.OrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cust_idTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnGetCustomer As System.Windows.Forms.Button
    Friend WithEvents btnFindCustomer As System.Windows.Forms.Button
    Friend WithEvents Cust_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cust_addressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cust_cityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cust_stateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cust_zipTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cust_countryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnListAllCustomers As System.Windows.Forms.Button
    Friend WithEvents btnAddCustomer As System.Windows.Forms.Button
    Friend WithEvents btnModifyCustomer As System.Windows.Forms.Button
    Friend WithEvents OrderBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OrderDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ViewOrderItems As System.Windows.Forms.DataGridViewButtonColumn

End Class
