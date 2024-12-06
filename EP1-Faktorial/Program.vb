Imports System
Imports System.Numerics
Imports System.Security.Cryptography

Module Program
    Sub Main(args As String())
        Dim cislo As Object
        Dim vysledek As Integer = 1
        Do
            Console.WriteLine("Zadej èíslo")
            cislo = Console.ReadLine


            If Not IsNumeric(cislo) Then
                Console.WriteLine(" musí to být èíslo ")
                Console.ReadKey()
                End
            End If

            If cislo > 10 Then
                Console.WriteLine(" èíslo musí být menší než 10 ")
                Console.ReadKey()
                End
            End If

            If cislo < 0 Then
                Console.WriteLine(" minimální èíslo musí být 1")
                Console.ReadKey()
                End
            End If


            For i As Integer = 1 To cislo
                vysledek *= i
            Next



            Console.WriteLine($"faktoriál  èísla {cislo} je {vysledek}")


        Loop

    End Sub
End Module
