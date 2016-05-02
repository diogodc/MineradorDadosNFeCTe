Public Class ClientesDML

    Private _clienteID As Integer
    Public Property ClienteID() As Integer
        Get
            Return _clienteID
        End Get
        Set(ByVal value As Integer)
            _clienteID = value
        End Set
    End Property

    Private _razaoSocial As String
    Public Property RazaoSocial() As String
        Get
            Return _razaoSocial
        End Get
        Set(ByVal value As String)
            _razaoSocial = value
        End Set
    End Property

    Private _nomeFantasia As String
    Public Property NomeFantasia() As String
        Get
            Return _nomeFantasia
        End Get
        Set(ByVal value As String)
            _nomeFantasia = value
        End Set
    End Property

    Private _CNPJ As String
    Public Property CNPJ() As String
        Get
            Return _CNPJ
        End Get
        Set(ByVal value As String)
            _CNPJ = value
        End Set
    End Property

    Private _inscricaoEstadual As String
    Public Property InscricaoEstadual() As String
        Get
            Return _inscricaoEstadual
        End Get
        Set(ByVal value As String)
            _inscricaoEstadual = value
        End Set
    End Property

    Private _email As String
    Public Property Email() As String
        Get
            Return _email
        End Get
        Set(ByVal value As String)
            _email = value
        End Set
    End Property

    Private _rua As String
    Public Property Rua() As String
        Get
            Return _rua
        End Get
        Set(ByVal value As String)
            _rua = value
        End Set
    End Property

    Private _numero As String
    Public Property Numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
        End Set
    End Property

    Private _bairro As String
    Public Property Bairro() As String
        Get
            Return _bairro
        End Get
        Set(ByVal value As String)
            _bairro = value
        End Set
    End Property

    Private _cidade As String
    Public Property Cidade() As String
        Get
            Return _cidade
        End Get
        Set(ByVal value As String)
            _cidade = value
        End Set
    End Property

    Private _UF As String
    Public Property UF() As String
        Get
            Return _UF
        End Get
        Set(ByVal value As String)
            _UF = value
        End Set
    End Property

    Private _fone As String
    Public Property Fone() As String
        Get
            Return _fone
        End Get
        Set(ByVal value As String)
            _fone = value
        End Set
    End Property

    Private _CEP As String
    Public Property CEP() As String
        Get
            Return _CEP
        End Get
        Set(ByVal value As String)
            _CEP = value
        End Set
    End Property
End Class
