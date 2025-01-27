'Jason Permann
'Spring 2025
'RCET2265
'OperatorsExample

Option Explicit On
Option Strict On
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

        Console.WriteLine("Please enter your age: ")
        userInput = Console.ReadLine
        variable1 = CInt(userInput)
        Select Case variable1
            Case 0 To 3

            Case 4 To 10

            Case 11 To 64

            Case 65 To 99

            Case > 100

            Case Else

        End Select
    End Sub

End Module
