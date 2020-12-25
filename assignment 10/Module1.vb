Module Module1

    Sub Main()
        'DECLARATION
        Dim stra, strb, strc As String
        Dim N As Integer

        'INITIALIZATION
        stra = ""
        strb = "ly"
        strc = "ing"
        N = 0

        'INPUT
        Console.Write("please enter a string: ")
        stra = Console.ReadLine

        'PROCESS
        N = InStr(stra, "ing")
        If Len(stra) < 3 Then
            Console.WriteLine("your string is: " & stra)
            Console.ReadKey()

        ElseIf Len(stra) > 3 Then

            If N > 0 Then
                stra = stra & strb
                Console.WriteLine("your string is: " & stra)
                Console.ReadKey()
            End If
        End If

        If N = 0 Then
            stra = stra & strc
            Console.WriteLine("your string is: " & stra)
            Console.ReadKey()

        End If

        Console.ReadKey()



    End Sub

End Module
