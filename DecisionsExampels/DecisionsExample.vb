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

        ''assign 5 to variable1
        'variable1 = 5

        ''test is variable1 greater than 6
        ''display the result on console
        'If variable1 > 6 Then
        '    Console.WriteLine(variable1 > 6) 'false so it skips 
        'End If

        'If variable1 > 3 Then
        '    Console.WriteLine(variable1 > 3) 'true so it prints 
        'End If

        'If variable1 > 4 Then
        '    Console.WriteLine(variable1 > 4) 'true so it prints
        'End If

        ''if anything evaluates to true all other evaluations are skipped
        'If variable1 > 6 Then
        '    Console.WriteLine(variable1 > 6) 'false so it skips 

        'ElseIf variable1 > 3 Then
        '    Console.WriteLine(variable1 > 3) 'true so it prints and dosent contune through

        'ElseIf variable1 > 4 Then
        '    Console.WriteLine(variable1 > 4)
        'End If

        ''Adds previous variable1 value to new variable1 value
        'variable1 += 3

        'If variable1 > 6 Then
        '    Console.WriteLine($"{variable1} is a big number")

        'ElseIf variable1 > 3 Then
        '    Console.WriteLine($"sorry not tall enough..")

        'ElseIf variable1 > 4 Then
        '    Console.WriteLine($"who cares")
        'Else
        '    Console.WriteLine($"Not sure what happend")
        'End If

        ''Subtracts previous variable1 value to new variable1 value
        'variable1 -= 6

        'If variable1 > 6 Then
        '    Console.WriteLine($"{variable1} is a big number")

        'ElseIf variable1 > 3 Then
        '    Console.WriteLine($"sorry not tall enough..")

        'ElseIf variable1 > 4 Then
        '    Console.WriteLine($"who cares")
        'Else
        '    Console.WriteLine($"Not sure what happend") 'if none of the conditions evaluates to true the Else clause triggers
        'End If


        'Do

        '    Console.WriteLine("Please enter your age: ")
        '    userInput = Console.ReadLine()
        '    Try
        '        variable1 = CInt(userInput)
        '        Select Case variable1
        '            Case 0 To 3
        '                Console.WriteLine("Where are your parents?")
        '            Case 4 To 10
        '                Console.WriteLine("Sorry kid, why dont you try the tea cups..")
        '            Case 11 To 64
        '                Console.WriteLine("Enjoy the ride.")
        '            Case 65 To 99
        '                Console.WriteLine("Please sign this liability release form.")
        '            Case > 100
        '                Console.WriteLine("Someone misplaced their mamuah!")
        '            Case Else
        '                Console.WriteLine("How old are you agian?")
        '        End Select

        '    Catch ex As Exception
        '        Console.WriteLine($"You entered: {userInput}")
        '    End Try
        'Loop Until userInput = "Q"
        'Console.WriteLine("Have a nice day!")



        'Do
        '    Console.WriteLine("Type something and press enter: ")
        '    userInput = Console.ReadLine()
        '    Console.WriteLine($"in the Do, loop until: ")
        'Loop Until userInput = "Q"

        'Do While userInput = "Q"
        '    Console.WriteLine("Type something and press enter: ")
        '    userInput = Console.ReadLine()
        '    Console.WriteLine($"in the Do, While loop: ")
        'Loop

        'For i As Integer = 1 To 10 Step 2
        '    Console.WriteLine(i)
        'Next
        'Console.WriteLine(StrDup(80, "*"))

        'For i = 1 To 10 Step 0.5
        '    Console.WriteLine(i)
        'Next
        'Console.WriteLine(StrDup(80, "*"))

        'For i = 1 To 10
        '    Console.WriteLine(i)
        'Next
        'Console.WriteLine(StrDup(80, "*"))

        ''nested for loop
        'For i = 1 To 10

        '    For j = 1 To 10

        '        Console.Write(CStr(j + i).PadLeft(3) & " |")

        '    Next

        '    Console.WriteLine()
        'Next

        'Dim result As String
        'Console.WriteLine(StrDup(80, "*"))

        'For i = 1 To 10

        '    For j = 1 To 10
        '        result = (i + j).ToString("C")
        '        result = result.PadLeft(8)
        '        Console.Write(result)
        '    Next

        '    Console.WriteLine()
        'Next

        Dim firstNumber As Integer
        Dim getOutOfHere As Boolean = False

        'Do
        '    Console.WriteLine("In the first loop. loop while firstnumber <= 3")
        '    firstNumber += 1
        '    Console.WriteLine($"FirstNumber is {firstNumber}!")
        '    Console.WriteLine()

        'Loop While firstNumber <= 3

        'Console.WriteLine()

        'Do
        '    Console.WriteLine("In the second loop. loop while firstnumber <= 3")
        '    firstNumber += 1
        '    Console.WriteLine($"FirstNumber is {firstNumber}!")
        '    Console.WriteLine()

        'Loop While firstNumber <= 3

        'Console.WriteLine()

        'Do Until firstNumber >= 3
        '    Console.WriteLine("In the third loop. loop while firstnumber <= 3")
        '    firstNumber += 1
        '    Console.WriteLine($"FirstNumber is {firstNumber}!")
        '    Console.WriteLine()
        'Loop

        'Console.WriteLine()

        'Do While firstNumber >= 3
        '    Console.WriteLine("In the fourth loop. loop while firstnumber <= 3")
        '    firstNumber -= 1
        '    Console.WriteLine($"FirstNumber is {firstNumber}!")
        '    Console.WriteLine()
        'Loop

        'Console.WriteLine()

        Do
            Console.WriteLine("Enter a number 1")
            Console.WriteLine("Enter Q to quit")
            userInput = Console.ReadLine()
            Console.WriteLine($"You entered {userInput}")
            'Console.Clear()
            Try
                firstNumber = CInt(userInput)
                getOutOfHere = True

            Catch ex As Exception

                If userInput <> "Q" Then
                    Console.WriteLine("Please enter a whole number")
                Else
                    getOutOfHere = True
                End If

            End Try

        Loop Until getOutOfHere = True

        getOutOfHere = False

        Do While userInput <> "Q" And getOutOfHere = False
            Console.WriteLine("Enter a number 2")
            Console.WriteLine("Enter Q to quit")
            userInput = Console.ReadLine()
            Console.WriteLine($"You entered {userInput}")
            'Console.Clear()
            Try
                firstNumber = CInt(userInput)
                getOutOfHere = True

            Catch ex As Exception

                If userInput <> "Q" Then
                    Console.WriteLine("Please enter a whole number")
                Else
                    getOutOfHere = True
                End If

            End Try
        Loop
    End Sub

End Module
