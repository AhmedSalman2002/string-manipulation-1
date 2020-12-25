Module Module1

    Sub Main()
        'DECLARATION
        Dim donuts1 As Integer
        Dim donuts2 As String


        'INITIALIATION
        donuts1 = 0
        donuts2 = "many"

        'INPUT
        Console.Write("please enter number of donuts: ")
        donuts1 = Console.ReadLine

        'PROCESS
        If donuts1 < 10 Then
            Console.WriteLine("number of donuts: " & donuts1)
        ElseIf donuts1 >= 10 Then
            Console.WriteLine("number of donuts: " & donuts2)
        End If

        Console.ReadKey()
    End Sub

End Module
