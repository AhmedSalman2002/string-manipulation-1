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
        char2 = ""
        char3 = ""
        C = 0

        'INPUT
        Console.Write("Please Enter A String: ")
        stra = Console.ReadLine

        Console.Write("Please Enter A Character You Want To Replace: ")
        char1 = Console.ReadLine

        Console.Write("Please Enter A Subsitute Character: ")
        char2 = Console.ReadLine

        'PROCESS
        For C = 1 To Len(stra)
            char3 = Mid(stra, C, 1)

            If char3 = char1 Then
                strb = strb & char2
            Else
                strb = strb & char3
            End If
        Next

        'OUTPUT
        Console.WriteLine("Resulting string after substitution is: " & strb)
        Console.ReadKey()

    End Sub

End Module
