Imports System

Module Program
    Sub Main()

        '#EXAMPLE ONE#

        'Dim str_input As String

        'str_input = Console.readin()
        '__________________________

        '#EXAMPLE TWO#

        'Dim int_count As Short
        'Do Until False

        'int_count += 1

        'Loop
        '__________________

        '#EXAMPLE THREE#

        Dim int_count As Short
        Dim bol_maxed As Boolean = False
        Do Until bol_maxed
            Try
                int_count += 1
            Catch
                Console.WriteLine("Maxed out at " & int_count)
                bol_maxed = True
            End Try
        Loop
        Console.ReadKey()

    End Sub
End Module
