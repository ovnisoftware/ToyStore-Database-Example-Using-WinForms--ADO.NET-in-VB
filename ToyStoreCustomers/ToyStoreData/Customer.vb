Public Class Customer
    Private _cust_country As String
    Private _cust_zip As String
    Private _cust_state As String
    Private _cust_city As String
    Private _cust_address As String
    Private _cust_name As String
    Private _cust_id As String

    Public Property Cust_country() As String
        Get
            Return _cust_country
        End Get
        Set(ByVal value As String)
            _cust_country = value
        End Set
    End Property

    Public Property Cust_zip() As String
        Get
            Return _cust_zip
        End Get
        Set(ByVal value As String)
            _cust_zip = value
        End Set
    End Property

    Public Property Cust_state() As String
        Get
            Return _cust_state
        End Get
        Set(ByVal value As String)
            _cust_state = value
        End Set
    End Property

    Public Property Cust_city() As String
        Get
            Return _cust_city
        End Get
        Set(ByVal value As String)
            _cust_city = value
        End Set
    End Property

    Public Property Cust_address() As String
        Get
            Return _cust_address
        End Get
        Set(ByVal value As String)
            _cust_address = value
        End Set
    End Property

    Public Property Cust_name() As String
        Get
            Return _cust_name
        End Get
        Set(ByVal value As String)
            _cust_name = value
        End Set
    End Property

    Public Property Cust_id() As String
        Get
            Return _cust_id
        End Get
        Set(ByVal value As String)
            _cust_id = value
        End Set
    End Property

    Public ReadOnly Property SingleLineAddress() As String
        Get
            Return Cust_name.Trim & ", " & Cust_address.Trim & ", " & Cust_city.Trim & ", " & Cust_state.Trim & ", " &
                Cust_zip.Trim & ", " & Cust_country.Trim
        End Get
    End Property

End Class