Public Class Jugador
    Inherits Persona
    Private _numero As UShort

    Public Sub New(nombre As String, fechaNacimiento As Date, numero As UShort)
        MyBase.New(nombre, fechaNacimiento)
        Me.Numero = numero

    End Sub

    '///////////////Properties///////////////////

    Public Property Numero() As UShort
        Get
            Return _numero
        End Get
        Set(ByVal value As UShort)
            If value >= 1 And value < 100 Then
                _numero = value
            End If
        End Set
    End Property

    '///////////////Methods///////////////////

    Public Overrides Function ToString() As String
        Return Nombre & "(" & Numero & ")"
    End Function

End Class
