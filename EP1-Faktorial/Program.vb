Imports System

Module Program
    Sub Main(args As String())
        Dim cislo As Integer
        Dim soucet As Integer = 0
        Dim vstup As String

        Console.Write("Zadej celé èíslo: ")
        cislo = Console.ReadLine

        If vstup > 0 Then
            If vstup > 10 Then
                If Integer.TryParse(vstup, cislo) Then
                    For i = 1 To cislo
                        soucet = soucet + 1
                    Next
                    Console.WriteLine($"Souèet od 1 do {cislo} je {soucet}")
                Else
                    Console.WriteLine("Chybièka mùžete psát pouze celá èísla ")
                End If
            Else Console.WriteLine("Napsali jste moc velkou hodnotu")
            End If
        Else Console.WriteLine("Nemùžete poèítat se zápornými èísly")
        End If

    End Sub
End Module