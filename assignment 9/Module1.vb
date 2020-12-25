Module Module1

    Sub Main()
        'DECLARATION
        Dim stra, strb, strc, strd, L1, L2, L3, L4 As String

        'INITIALIZATION
        stra = ""
        strb = ""
        strc = ""
        strd = ""
        L1 = ""
        L2 = ""
        L3 = ""
        L4 = ""
        'INPUT
        Console.Write("please enter first string: ")
        stra = Console.ReadLine

        Console.Write("please enter second string: ")
        strb = Console.ReadLine

        'PROCESS
        L1 = Left(stra, 2)
        L2 = Right(strb, 1)
        strc = L1 & L2

        L3 = Left(strb, 2)
        L4 = Right(stra, 1)
        strd = L3 & L4

        'OUTPUT
        Console.WriteLine("your string is: " & strc & " " & strd)

        Console.ReadKey()

    End Sub

End Module
