Public Class ConsultaDML
    Public Sub New(ByVal CampoPesquisa As String, ByVal Pesquisa As String, ByVal TipoPesquisa As Integer)
        Me._CampoPesquisa = CampoPesquisa
        Me._Pesquisa = Pesquisa
        Me._TipoPesquisa = TipoPesquisa
    End Sub
    Private _TipoPesquisa As Integer
    Public Property TipoPesquisa() As Integer
        Get
            Return _TipoPesquisa
        End Get
        Set(ByVal value As Integer)
            _TipoPesquisa = value
        End Set
    End Property
    Private _CampoPesquisa As Integer
    Public Property CampoPesquisa() As Integer
        Get
            Return _CampoPesquisa
        End Get
        Set(ByVal value As Integer)
            _CampoPesquisa = value
        End Set
    End Property
    Private _Pesquisa As String
    Public Property Pesquisa() As String
        Get
            Return _Pesquisa
        End Get
        Set(ByVal value As String)
            _Pesquisa = value
        End Set
    End Property
End Class
