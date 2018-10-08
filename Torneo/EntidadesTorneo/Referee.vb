Public Class Referee
    Inherits Persona
    Private _intenacional As Boolean

    Public Sub New(nombre As String, fechaNacimiento As Date, internacional As Boolean)
        MyBase.New(nombre, fechaNacimiento)
        Me.International = internacional

    End Sub

    Public Property International() As Boolean
        Get
            Return _intenacional
        End Get
        Set(ByVal value As Boolean)

            _intenacional = value

        End Set
    End Property

    '///////////////Methods///////////////////

    Public Overrides Function ToString() As String
        If _intenacional Then
            Return Nombre & "(I)"
        Else
            Return Nombre
        End If
    End Function
End Class
