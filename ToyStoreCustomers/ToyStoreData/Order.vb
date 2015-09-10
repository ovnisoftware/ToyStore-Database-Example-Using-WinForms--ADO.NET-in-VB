Public Class Order
    Private _cust_id As String
    Private _order_date As DateTime
    Private _order_num As Integer

    Public Property Cust_id() As String
        Get
            Return _cust_id
        End Get
        Set(ByVal value As String)
            _cust_id = value
        End Set
    End Property

    Public Property Order_date() As DateTime
        Get
            Return _order_date
        End Get
        Set(ByVal value As DateTime)
            _order_date = value
        End Set
    End Property

    Public Property Order_num() As Integer
        Get
            Return _order_num
        End Get
        Set(ByVal value As Integer)
            _order_num = value
        End Set
    End Property

End Class
