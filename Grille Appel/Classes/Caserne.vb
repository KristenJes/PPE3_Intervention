Public Class Caserne
    Private _cis_id As Integer
    Private _cis_nom As String

    Public Sub New(ByVal cis_id, ByVal nom)
        _cis_id = cis_id
        _cis_nom = cis_nom
    End Sub

    Public Property cis_id As Integer
        Get
            Return _cis_id
        End Get
        Set(ByVal value As Integer)
            _cis_id = value
        End Set
    End Property

    Public Property cis_nom As String
        Get
            Return _cis_nom
        End Get
        Set(ByVal value As String)
            _cis_nom = value
        End Set
    End Property
End Class
