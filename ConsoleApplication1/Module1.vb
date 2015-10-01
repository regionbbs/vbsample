Module Module1

    Sub Main()

        For i As Integer = 1 To 9
            For j As Integer = 1 To 9
                Console.WriteLine("{0}x{1}={2}", i, j, i * j)
            Next
        Next

        Console.ReadLine()

    End Sub

End Module
