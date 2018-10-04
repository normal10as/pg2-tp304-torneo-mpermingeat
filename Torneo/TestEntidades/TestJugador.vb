Imports System
Imports EntidadesTorneo

Module TestJugador
    Dim nacimiento As Date = #11-10-1991#

    Dim jug As New Jugador("pepe", nacimiento, 9)

    Sub Main()
        Console.WriteLine("Tostring " & jug.ToString)

        Console.WriteLine("Edad: " & jug.Edad)

    End Sub

End Module
