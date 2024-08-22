<Serializable()> Public Class CVender

    Private csName As String
    Private csAddress As String
    Private csCity As String

    Private ciZipcode As Integer
    Private ciPhoneArea As Integer
    Private ciPhoneExchange As Integer
    Private ciPhoneNumber As Integer
    Private esState As EStates

    Private cbDirty As Boolean

    Public Sub New(ByVal psName As String, Optional ByVal psAddr As String = "", Optional ByVal psCity As String = "",
                   Optional ByVal piZipCode As Integer = 0, Optional ByVal piPhoneNumber As Integer = 0,
                   Optional ByVal eiState As EStates = 0)
        csName = psName
        csAddress = psAddr
        csCity = psCity

        cbDirty = False

        ciPhoneNumber = piPhoneNumber
        esState = eiState
        ciZipcode = piZipCode
    End Sub

#Region " Interface Properties of the Class "
    Public Property PhoneAreaCode() As Integer
        Get
            Return ciPhoneArea
        End Get
        Set(ByVal value As Integer)
            If value <> ciPhoneArea Then
                Dirtied = True
            End If
            ciPhoneArea = value
        End Set
    End Property
    Public Property PhoneExchangeCode() As Integer
        Get
            Return ciPhoneExchange
        End Get
        Set(ByVal value As Integer)
            If value <> ciPhoneExchange Then
                Dirtied = True
            End If
            ciPhoneExchange = value
        End Set
    End Property
    Public Property PhoneNumber() As Integer
        Get
            Return ciPhoneNumber
        End Get
        Set(ByVal value As Integer)
            If value <> ciPhoneNumber Then
                Dirtied = True
            End If
            ciPhoneNumber = value
        End Set
    End Property
    Public Property State() As EStates
        Get
            Return esState
        End Get
        Set(ByVal value As EStates)
            If esState.CompareTo(value) <> 0 Then
                Dirtied = True
            End If
            esState = value
        End Set
    End Property

    Public Property StateID() As Integer
        Get
            Return CType(esState, Integer)
        End Get
        Set(ByVal value As Integer)
            Dim newState As EStates = CType(value, EStates)
            If esState.CompareTo(newState) <> 0 Then
                Dirtied = True
            End If
            esState = newState
        End Set
    End Property

    Public Property Zipcode() As Integer
        Get
            Return ciZipcode
        End Get
        Set(ByVal value As Integer)
            If value <> ciZipcode Then
                Dirtied = True
            End If
            ciZipcode = value
        End Set
    End Property
    Public Property CompanyName() As String
        Get
            Return csName
        End Get
        Set(ByVal Value As String)
            If csName.CompareTo(Value) <> 0 Then
                Dirtied = True
            End If
            csName = Value
        End Set
    End Property

    Public Property Address() As String
        Get
            Return csAddress
        End Get
        Set(ByVal Value As String)
            If csAddress.CompareTo(Value) <> 0 Then
                Dirtied = True
            End If
            csAddress = Value
        End Set
    End Property

    Public Property City() As String
        Get
            Return csCity
        End Get
        Set(ByVal Value As String)
            If csCity.CompareTo(Value) <> 0 Then
                Dirtied = True
            End If
            csCity = Value
        End Set
    End Property

    Public Property Dirtied() As Boolean
        Get
            Return cbDirty
        End Get
        Set(ByVal value As Boolean)
            cbDirty = value
        End Set
    End Property
#End Region

End Class
