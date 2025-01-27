'Jason Permann
'Spring 2025
'RCET2265
'OperatorsExample

Option Explicit On
Option Strict On
Module DecisionsExample

    Sub Main()
        Dim variable1 As Integer

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


        If variable1 > 6 Then
            Console.WriteLine(variable1 > 6) 'false so it skips 

        ElseIf variable1 > 3 Then
            Console.WriteLine(variable1 > 3) 'true so it prints and dosent contune through

        ElseIf variable1 > 4 Then
            Console.WriteLine(variable1 > 4)
        End If
    End Sub

End Module
