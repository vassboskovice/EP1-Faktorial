Imports System
Module Program
    Sub Main(args As String())
        Dim cislo As Integer
        Dim soucet As Integer = 0
        Dim vstup As String
        Console.Write("Zadej cel� ��slo: ")
        cislo = Console.ReadLine

        If vstup > 0 Then
            If vstup > 10 Then
                If Integer.TryParse(vstup, cislo) Then
                    For i = 1 To cislo
                        soucet = soucet + 1
                    Next
                    Console.WriteLine($"Sou�et od 1 do {cislo} je {soucet}")
                Else
                    Console.WriteLine("Chyba m��e ps�t pouze cel� ��sla ")
                    Do
                        If vstup > 0 Then
                            If vstup > 10 Then
                                If Integer.TryParse(vstup, cislo) Then
                                    For i = 1 To cislo
                                        soucet = soucet + 1
                                    Next
                                    Console.WriteLine($"Sou�et od 1 do {cislo} je {soucet}")
                                Else
                                    Console.WriteLine("Chyba m��e ps�t pouze cel� ��sla ")
                                End If
                            Else Console.WriteLine("Napsali jste moc velkou hodnotu")
                            End If
                        Else Console.WriteLine("Napsali jste moc velkou hodnotu")
                            Else Console.WriteLine("Nem��ete po��tat se z�porn�mi ��sly")
                        End If
                        Else Console.WriteLine("Nem��ete po��tat se z�porn�mi ��sly")
        End If

                Loop
    End Sub
End Module