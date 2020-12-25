Module Module1

    Sub Main()
        'DECLARATION
        Dim str1, str2 As String
        Dim char1 As Char
        Dim C, V, acount, ecount, icount, ocount, ucount As Integer


        'INITIALIZATION
        str1 = ""
        str2 = "AEIOU"
        char1 = ""
        C = 0

        'INPUT
        Console.Write("Enter A string = ")
        str1 = Console.ReadLine

        'PROCESSING
        For C = 1 To Len(str1)
            char1 = Mid(str1, C, 1)
            char1 = UCase(char1)
            V = InStr(str2, char1)
            If V > 0 Then
                If char1 = "A" Then
                    acount = acount + 1
                ElseIf char1 = "E" Then
                    ecount = ecount + 1
                ElseIf char1 = "I" Then
                    icount = icount + 1
                ElseIf char1 = "O" Then
                    ocount = ocount + 1
                ElseIf char1 = "U" Then
                    ucount = ucount + 1
                End If
            End If
        Next

        'OUTPUT
        Console.WriteLine("Number Of 'A' In A String Is = " & acount)
        Console.WriteLine("Number Of 'E' In A String Is = " & ecount)
        Console.WriteLine("Number Of 'I' In A String Is = " & icount)
        Console.WriteLine("Number Of 'O' In A String Is = " & ocount)
        Console.WriteLine("Number Of 'U' In A String Is = " & ucount)

        Console.ReadKey()
    End Sub

End Module
