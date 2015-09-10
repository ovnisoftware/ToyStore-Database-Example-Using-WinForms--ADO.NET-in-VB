<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddModifyCustomers
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
        Dim Cust_addressLabel As System.Windows.Forms.Label
        Dim Cust_cityLabel As System.Windows.Forms.Label
        Dim Cust_stateLabel As System.Windows.Forms.Label
        Dim Cust_zipLabel As System.Windows.Forms.Label
        Dim Cust_countryLabel As System.Windows.Forms.Label
        Me.Cust_nameTextBox = New System.Windows.Forms.TextBox()
        Me.Cust_addressTextBox = New System.Windows.Forms.TextBox()
        Me.Cust_cityTextBox = New System.Windows.Forms.TextBox()
        Me.Cust_stateTextBox = New System.Windows.Forms.TextBox()
        Me.Cust_zipTextBox = New System.Windows.Forms.TextBox()
        Me.Cust_countryTextBox = New System.Windows.Forms.TextBox()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Cust_nameLabel = New System.Windows.Forms.Label()
        Cust_addressLabel = New System.Windows.Forms.Label()
        Cust_cityLabel = New System.Windows.Forms.Label()
        Cust_stateLabel = New System.Windows.Forms.Label()
        Cust_zipLabel = New System.Windows.Forms.Label()
        Cust_countryLabel = New System.Windows.Forms.Label()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Cust_nameLabel
        '
        Cust_nameLabel.AutoSize = True
        Cust_nameLabel.Location = New System.Drawing.Point(14, 15)
        Cust_nameLabel.Name = "Cust_nameLabel"
        Cust_nameLabel.Size = New System.Drawing.Size(38, 13)
        Cust_nameLabel.TabIndex = 1
        Cust_nameLabel.Text = "Name:"
        '
        'Cust_addressLabel
        '
        Cust_addressLabel.AutoSize = True
        Cust_addressLabel.Location = New System.Drawing.Point(14, 42)
        Cust_addressLabel.Name = "Cust_addressLabel"
        Cust_addressLabel.Size = New System.Drawing.Size(48, 13)
        Cust_addressLabel.TabIndex = 3
        Cust_addressLabel.Text = "Address:"
        '
        'Cust_cityLabel
        '
        Cust_cityLabel.AutoSize = True
        Cust_cityLabel.Location = New System.Drawing.Point(14, 69)
        Cust_cityLabel.Name = "Cust_cityLabel"
        Cust_cityLabel.Size = New System.Drawing.Size(27, 13)
        Cust_cityLabel.TabIndex = 5
        Cust_cityLabel.Text = "City:"
        '
        'Cust_stateLabel
        '
        Cust_stateLabel.AutoSize = True
        Cust_stateLabel.Location = New System.Drawing.Point(14, 96)
        Cust_stateLabel.Name = "Cust_stateLabel"
        Cust_stateLabel.Size = New System.Drawing.Size(35, 13)
        Cust_stateLabel.TabIndex = 7
        Cust_stateLabel.Text = "State:"
        '
        'Cust_zipLabel
        '
        Cust_zipLabel.AutoSize = True
        Cust_zipLabel.Location = New System.Drawing.Point(14, 123)
        Cust_zipLabel.Name = "Cust_zipLabel"
        Cust_zipLabel.Size = New System.Drawing.Size(53, 13)
        Cust_zipLabel.TabIndex = 9
        Cust_zipLabel.Text = "Zip Code:"
        '
        'Cust_countryLabel
        '
        Cust_countryLabel.AutoSize = True
        Cust_countryLabel.Location = New System.Drawing.Point(14, 150)
        Cust_countryLabel.Name = "Cust_countryLabel"
        Cust_countryLabel.Size = New System.Drawing.Size(46, 13)
        Cust_countryLabel.TabIndex = 11
        Cust_countryLabel.Text = "Country:"
        '
        'Cust_nameTextBox
        '
        Me.Cust_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_name", True))
        Me.Cust_nameTextBox.Location = New System.Drawing.Point(74, 12)
        Me.Cust_nameTextBox.Name = "Cust_nameTextBox"
        Me.Cust_nameTextBox.Size = New System.Drawing.Size(272, 20)
        Me.Cust_nameTextBox.TabIndex = 2
        '
        'Cust_addressTextBox
        '
        Me.Cust_addressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_address", True))
        Me.Cust_addressTextBox.Location = New System.Drawing.Point(74, 39)
        Me.Cust_addressTextBox.Name = "Cust_addressTextBox"
        Me.Cust_addressTextBox.Size = New System.Drawing.Size(272, 20)
        Me.Cust_addressTextBox.TabIndex = 4
        '
        'Cust_cityTextBox
        '
        Me.Cust_cityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_city", True))
        Me.Cust_cityTextBox.Location = New System.Drawing.Point(74, 66)
        Me.Cust_cityTextBox.Name = "Cust_cityTextBox"
        Me.Cust_cityTextBox.Size = New System.Drawing.Size(272, 20)
        Me.Cust_cityTextBox.TabIndex = 6
        '
        'Cust_stateTextBox
        '
        Me.Cust_stateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_state", True))
        Me.Cust_stateTextBox.Location = New System.Drawing.Point(74, 93)
        Me.Cust_stateTextBox.Name = "Cust_stateTextBox"
        Me.Cust_stateTextBox.Size = New System.Drawing.Size(46, 20)
        Me.Cust_stateTextBox.TabIndex = 8
        '
        'Cust_zipTextBox
        '
        Me.Cust_zipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_zip", True))
        Me.Cust_zipTextBox.Location = New System.Drawing.Point(74, 120)
        Me.Cust_zipTextBox.Name = "Cust_zipTextBox"
        Me.Cust_zipTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cust_zipTextBox.TabIndex = 10
        '
        'Cust_countryTextBox
        '
        Me.Cust_countryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CustomerBindingSource, "Cust_country", True))
        Me.Cust_countryTextBox.Location = New System.Drawing.Point(74, 147)
        Me.Cust_countryTextBox.Name = "Cust_countryTextBox"
        Me.Cust_countryTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Cust_countryTextBox.TabIndex = 12
        '
        'btnAccept
        '
        Me.btnAccept.Location = New System.Drawing.Point(17, 189)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(75, 23)
        Me.btnAccept.TabIndex = 13
        Me.btnAccept.Text = "Accept"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(271, 189)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataSource = GetType(ToyStoreData.Customer)
        '
        'frmAddModifyCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 220)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Cust_countryLabel)
        Me.Controls.Add(Me.Cust_countryTextBox)
        Me.Controls.Add(Cust_zipLabel)
        Me.Controls.Add(Me.Cust_zipTextBox)
        Me.Controls.Add(Cust_stateLabel)
        Me.Controls.Add(Me.Cust_stateTextBox)
        Me.Controls.Add(Cust_cityLabel)
        Me.Controls.Add(Me.Cust_cityTextBox)
        Me.Controls.Add(Cust_addressLabel)
        Me.Controls.Add(Me.Cust_addressTextBox)
        Me.Controls.Add(Cust_nameLabel)
        Me.Controls.Add(Me.Cust_nameTextBox)
        Me.Name = "frmAddModifyCustomers"
        Me.Text = "AddModifyCustomers"
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cust_nameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cust_addressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cust_cityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cust_stateTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cust_zipTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Cust_countryTextBox As System.Windows.Forms.TextBox
    Friend WithEvents btnAccept As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
