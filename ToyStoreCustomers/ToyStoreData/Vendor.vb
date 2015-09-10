Public Class Vendor
    Private _vend_country As String
    Private _vend_zip As String
    Private _vend_state As String
    Private _vend_city As String
    Private _vend_address As String
    Private _vend_name As String
    Private _vend_id As String

    Public Property Vend_country() As String
        Get
            Return _vend_country
        End Get
        Set(ByVal value As String)
            _vend_country = value
        End Set
    End Property

    Public Property Vend_zip() As String
        Get
            Return _vend_zip
        End Get
        Set(ByVal value As String)
            _vend_zip = value
        End Set
    End Property

    Public Property Vend_state() As String
        Get
            Return _vend_state
        End Get
        Set(ByVal value As String)
            _vend_state = value
        End Set
    End Property

    Public Property Vend_city() As String
        Get
            Return _vend_city
        End Get
        Set(ByVal value As String)
            _vend_city = value
        End Set
    End Property

    Public Property Vend_Address() As String
        Get
            Return _vend_address
        End Get
        Set(ByVal value As String)
            _vend_address = value
        End Set
    End Property

    Public Property Vend_name() As String
        Get
            Return _vend_name
        End Get
        Set(ByVal value As String)
            _vend_name = value
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

End Class