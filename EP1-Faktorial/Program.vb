Imports System
Imports System.Numerics
Imports System.Security.Cryptography

Module Program
    Sub Main(args As String())
        Dim cislo As Object
        Dim vysledek As Integer = 1
        Do
            Console.WriteLine("Zadej ��slo")
            cislo = Console.ReadLine


            If Not IsNumeric(cislo) Then
                Console.WriteLine(" mus� to b�t ��slo ")
                Console.ReadKey()
                End
            End If

            If cislo > 10 Then
                Console.WriteLine(" ��slo mus� b�t men�� ne� 10 ")
                Console.ReadKey()
                End
            End If

            If cislo < 0 Then
                Console.WriteLine(" minim�ln� ��slo mus� b�t 1")
                Console.ReadKey()
                End
            End If


            For i As Integer = 1 To cislo
                vysledek *= i
            Next



            Console.WriteLine($"faktori�l  ��sla {cislo} je {vysledek}")


        Loop

    End Sub
End Module
