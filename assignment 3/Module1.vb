Module Module1

    Sub Main()
        'DECLARATION
        Dim myStr1 As String
        Dim C, alphaCount, digitCount As Integer
        Dim Char1 As Char

        'INITIALISATION
        myStr1 = ""
        C = 0
        alphaCount = 0
        digitCount = 0
        Char1 = ""


        'INPUT
        Console.Write("Please enter string: ")
        myStr1 = Console.ReadLine()


        'PROCESSING
        For C = 1 To Len(myStr1)
            Char1 = Mid(myStr1, C, 1)

            If (Asc(Char1) >= 65 And Asc(Char1) <= 90) Or (Asc(Char1) >= 97 And Asc(Char1) <= 122) Then
                alphaCount = alphaCount + 1

            ElseIf Asc(Char1) >= 48 And Asc(Char1) <= 57 Then
                digitCount = digitCount + 1
            End If
        Next

        'OUTPUT
        Console.WriteLine("Albhabets count = " & alphaCount)
        Console.WriteLine("Digits count = " & digitCount)

        Console.ReadKey()
    End Sub

End Module
