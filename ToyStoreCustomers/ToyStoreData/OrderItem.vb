Public Class OrderItem
    Private _item_price As Decimal
    Private _quantity As Integer
    Private _prod_id As String
    Private _order_item As Integer
    Private _order_num As Integer

    Public Property Item_price() As Decimal
        Get
            Return _item_price
        End Get
        Set(ByVal value As Decimal)
            _item_price = value
        End Set
    End Property

    Public Property Quantity() As Integer
        Get
            Return _quantity
        End Get
        Set(ByVal value As Integer)
            _quantity = value
        End Set
    End Property

    Public Property Prod_id() As String
        Get
            Return _prod_id
        End Get
        Set(ByVal value As String)
            _prod_id = value
        End Set
    End Property

    Public Property Order_item() As Integer
        Get
            Return _order_item
        End Get
        Set(ByVal value As Integer)
            _order_item = value
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