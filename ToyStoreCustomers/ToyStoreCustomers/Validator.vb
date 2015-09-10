Module Validator
    Public Function IsPresent(control As Control) As Boolean
        If control.GetType.ToString = "System.Windows.Forms.TextBox" Then
            Dim textBox As TextBox = CType(control, TextBox)
            If textBox.Text = "" Then
                MessageBox.Show(control.Name & " is a required field.")
                'textBox.Tag.ToString()
                textBox.Select()
                Return False
            Else
                Return True
            End If
        Else
            MessageBox.Show("Textbox control was not passed correctly.")
            Return False
        End If
    End Function

End Module
