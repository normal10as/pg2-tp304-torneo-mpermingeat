Imports System
Imports EntidadesTorneo

Module TestJugador
    Dim nacimiento As Date = #11-10-1991#
    Dim jug As New Jugador("Pepe", nacimiento, 9)
    Dim arbitro As New Referee("pedro el falso", nacimiento, True)

    Sub Main()
        Console.WriteLine("Tostring: " & jug.ToString)
        Console.WriteLine("Edad: " & jug.Edad)
        Console.WriteLine("////////////////////")
        Console.WriteLine("Tostring: " & arbitro.ToString)

    End Sub

End Module
