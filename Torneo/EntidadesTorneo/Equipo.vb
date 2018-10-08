Public Class Equipo
    Private _nombre As String
    Public Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub

    '///////////////Properties///////////////////
    Public Property Nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    '///////////////Methods///////////////////
    Public Overrides Function ToString() As String
        Return Nombre
    End Function
End Class
