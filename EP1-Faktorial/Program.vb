Imports System

Module Program
  Sub Main(args As String())
        Dim cislo As Integer
        Dim soucet As Integer = 0
        Dim vstup As String

        Console.Write("Zadej èíslo: ")
        cislo = Console.ReadLine

        If Integer.TryParse(vstup, cislo) Then
            For i = 1 To cislo
                soucet = soucet + 1
            Next
            Console.WriteLine($"Souèet od 1 do {cislo} je {soucet}")
        Else
            Console.WriteLine("Chybièka mùžete psát pouze celá èísla ")
        End If



    End Sub
End Module