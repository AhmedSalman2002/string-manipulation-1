Module Module1

    Sub Main()
        'DECLARATION
        Dim myStr1, myStr2 As String
        Dim C, N As Integer
        Dim myChar As Char
        Dim Pangram As Boolean

        'INITIALISATION
        myStr1 = ""
        myStr2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        C = 0
        myChar = ""
        Pangram = True

        'INPUT
        Console.Write("Please enter string: ")
        myStr1 = Console.ReadLine()
        myStr1 = UCase(myStr1)

        'PROCESSING
        For C = 1 To Len(myStr2)
            myChar = Mid(myStr2, C, 1)
            N = InStr(myStr1, myChar)
            If N = 0 Then
                Pangram = False
            End If
        Next

        'OUTPUT
        If Pangram = True Then
            Console.WriteLine("Entered String is a Pangram")
        Else
            Console.WriteLine("Entered String is NOT a Pangram")
        End If

        Console.ReadKey()
    End Sub

End Module
