
Option Explicit On
Option Strict On
Option Compare Binary
Module ControlFlow

    Sub Main()
        Dim firstNumber As Integer
        Dim secondNumber As Integer

        firstNumber = 5
        secondNumber = 8

        If firstNumber > secondNumber Then
            Console.WriteLine("first number is Bigger!!")
        End If
        Console.Read()
    End Sub

End Module
