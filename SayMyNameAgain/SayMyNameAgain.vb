'Justin Bell
'RCET0265
'Fall2024
'Say My Name Again
'[link]
Option Compare Text
Option Explicit On
Option Strict On
Module SayMyNameAgain

    Sub Main()
        Dim userinput As String
        Dim valid As Boolean = False
        Do
            Console.WriteLine("Enter Name")
            userinput = Console.ReadLine()
            Select Case userinput
                Case "Emily"
                    Console.WriteLine($"Hello {userinput}!")
                    Console.WriteLine($"Have a nice day!")
                    valid = True
                Case "Joe"
                    Console.WriteLine($"Hello {userinput}!")
                    Console.WriteLine($"Have a nice day!")
                    valid = True
                Case "Justin"
                    Console.WriteLine($"Hello {userinput}.")
                    Console.WriteLine($"Do you know when lunch is? I'm starving.")
                    valid = True
            End Select

            If valid = False Then
                Console.WriteLine()
                Console.WriteLine("Try Again")
            End If

        Loop Until valid = True

        Console.WriteLine("Press Enter")
        Console.ReadLine()
    End Sub

End Module
