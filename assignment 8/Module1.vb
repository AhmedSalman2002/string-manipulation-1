Module Module1

    Sub Main()
        'DECLARATION
        Dim stra, strb As String
        Dim char1, char2, char3 As Char
        Dim C As Integer

        'INITIALIZATION
        stra = ""
        strb = ""
        char1 = ""
        char2 = "*"
        char3 = ""


        'INPUT
        Console.Write("please enter a string: ")
        stra = Console.ReadLine

        'PROCESS
        char1 = Left(stra, 1)

        For C = 2 To Len(stra)
            char3 = Mid(stra, C, 1)
            If char1 = char3 Then
                strb = strb & char2
            Else
                strb = strb & char3
            End If
        Next

        Console.WriteLine("your resulted string is: " & char1 & strb)
        Console.ReadKey()

    End Sub

End Module
