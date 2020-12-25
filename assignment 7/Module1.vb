Module Module1

    Sub Main()
        'DECLARATION
        Dim S1, L1, L2 As String

        'INITIALIZATION
        S1 = ""
        L1 = ""
        L2 = ""

        'INPUT
        Console.Write("please enter first string: ")
        S1 = Console.ReadLine

       
        'PROCESS
        If Len(S1) <= 2 Then
            Console.WriteLine("Your string is: " & S1)

            Console.ReadKey()

        ElseIf Len(S1) >= 2 Then
            L1 = Left(S1, 2)
            L2 = Right(S1, 2)
            Console.WriteLine("your string is: " & L1 & L2)

            Console.ReadKey()








        End If


    End Sub

End Module
