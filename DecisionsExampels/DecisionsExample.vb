'Jason Permann
'Spring 2025
'RCET2265
'OperatorsExample

Option Explicit On
Option Strict On
Option Compare Text

Module DecisionsExample

    Sub Main()
        Dim variable1 As Integer
        Dim userInput As String

        'assign 5 to variable1
        variable1 = 5

        'test is variable1 greater than 6
        'display the result on console
        If variable1 > 6 Then
            Console.WriteLine(variable1 > 6) 'false so it skips 
        End If

        If variable1 > 3 Then
            Console.WriteLine(variable1 > 3) 'true so it prints 
        End If

        If variable1 > 4 Then
            Console.WriteLine(variable1 > 4) 'true so it prints
        End If

        'if anything evaluates to true all other evaluations are skipped
        If variable1 > 6 Then
            Console.WriteLine(variable1 > 6) 'false so it skips 

        ElseIf variable1 > 3 Then
            Console.WriteLine(variable1 > 3) 'true so it prints and dosent contune through

        ElseIf variable1 > 4 Then
            Console.WriteLine(variable1 > 4)
        End If

        'Adds previous variable1 value to new variable1 value
        variable1 += 3

        If variable1 > 6 Then
            Console.WriteLine($"{variable1} is a big number")

        ElseIf variable1 > 3 Then
            Console.WriteLine($"sorry not tall enough..")

        ElseIf variable1 > 4 Then
            Console.WriteLine($"who cares")
        Else
            Console.WriteLine($"Not sure what happend")
        End If

        'Subtracts previous variable1 value to new variable1 value
        variable1 -= 6

        If variable1 > 6 Then
            Console.WriteLine($"{variable1} is a big number")

        ElseIf variable1 > 3 Then
            Console.WriteLine($"sorry not tall enough..")

        ElseIf variable1 > 4 Then
            Console.WriteLine($"who cares")
        Else
            Console.WriteLine($"Not sure what happend") 'if none of the conditions evaluates to true the Else clause triggers
        End If


        Do

            Console.WriteLine("Please enter your age: ")
            userInput = Console.ReadLine()
            Try
                variable1 = CInt(userInput)
                Select Case variable1
                    Case 0 To 3
                        Console.WriteLine("Where are your parents?")
                    Case 4 To 10
                        Console.WriteLine("Sorry kid, why dont you try the tea cups..")
                    Case 11 To 64
                        Console.WriteLine("Enjoy the ride.")
                    Case 65 To 99
                        Console.WriteLine("Please sign this liability release form.")
                    Case > 100
                        Console.WriteLine("Someone misplaced their mamuah!")
                    Case Else
                        Console.WriteLine("How old are you agian?")
                End Select

            Catch ex As Exception
                Console.WriteLine($"You entered: {userInput}")
            End Try
        Loop Until userInput = "Q"
        Console.WriteLine("Have a nice day!")



        Do
            Console.WriteLine("Type something and press enter: ")
            userInput = Console.ReadLine()
            Console.WriteLine($"in the Do, loop until: ")
        Loop Until userInput = "Q"

        Do While userInput = "Q"
            Console.WriteLine("Type something and press enter: ")
            userInput = Console.ReadLine()
            Console.WriteLine($"in the Do, While loop: ")
        Loop


    End Sub

End Module
