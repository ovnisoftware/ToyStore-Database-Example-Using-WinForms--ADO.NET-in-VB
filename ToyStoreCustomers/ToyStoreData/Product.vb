Public Class Product
    Private _prod_desc As String
    Private _prod_price As Decimal
    Private _prod_name As String
    Private _vend_id As String
    Private _prod_id As String

    Public Property Prod_desc() As String
        Get
            Return _prod_desc
        End Get
        Set(ByVal value As String)
            _prod_desc = value
        End Set
    End Property

    Public Property Prod_price() As Decimal
        Get
            Return _prod_price
        End Get
        Set(ByVal value As Decimal)
            _prod_price = value
        End Set
    End Property

    Public Property Prod_name() As String
        Get
            Return _prod_name
        End Get
        Set(ByVal value As String)
            _prod_name = value
        End Set
    End Property

    Public Property Vend_id() As String
        Get
            Return _vend_id
        End Get
        Set(ByVal value As String)
            _vend_id = value
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

End Class
