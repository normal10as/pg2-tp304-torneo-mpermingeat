Public MustInherit Class Persona
    Private _nombre As String
    Private _fechaNacimiento As Date

    Public Sub New(Nombre As String, FechaNacimiento As Date)
        Me.FechaNacimiento = FechaNacimiento
        Me.Nombre = Nombre

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

    Public Property FechaNacimiento() As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(ByVal value As Date)
            If (Now.Year - value.Year) >= 16 Then
                _fechaNacimiento = value
            End If
        End Set
    End Property

    Public ReadOnly Property Edad() As UShort
        Get
            Return CalcularEdad(_fechaNacimiento)
        End Get
    End Property

    '///////////////Methods///////////////////
    Public Function CalcularEdad(value As Date) As UShort
        Return Now.Year - value.Year
    End Function

    Public Overrides Function ToString() As String
        Return Nombre
    End Function

End Class
