
Option Explicit On
Option Strict On
Option Compare Binary
Module ControlFlow

    Sub Main()
        'Dim firstNumber As String
        'Dim secondNumber As String

        'firstNumber = 10
        'secondNumber = 8

        'If firstnumber > secondNumber Then
        '    Console.WriteLine("first number is bigger!!")
        'ElseIf firstnumber < secondNumber Then
        '    Console.WriteLine("second number is bigger!!")
        'Else
        '    Console.WriteLine("the numbers are equal!!")
        'End If

        'Dim userInput As String
        'Console.WriteLine("Type a word and press enter")
        'userInput = Console.ReadLine

        ''Console.WriteLine("You typed " & userInput)
        'Console.WriteLine($"You typed {userInput}")

        'Dim firstNumber As String
        'Dim secondNumber As String

        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim userInput As String
        Dim problem As Boolean

        Console.WriteLine("Please enter a number")

        Try
            userInput = (Console.ReadLine())
            firstNumber = CInt(userInput)
        Catch e As Exception
            Console.WriteLine($"I need a number. You entered {userInput}")
            problem = True
        End Try

        Console.WriteLine("Please enter a number")

        Try
            userInput = (Console.ReadLine())
            secondNumber = CInt(userInput)
        Catch e As Exception
            Console.WriteLine($"I need a number. You entered {userInput}")
            problem = True
        End Try

        Console.Clear()

        If problem = True Then
            Console.WriteLine("Could not perform addition. Please enter numbers")
        Else
            'Console.WriteLine(CInt(firstNumber) + CInt(secondNumber))
            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}")
        End If
        Console.Read()
    End Sub

End Module
