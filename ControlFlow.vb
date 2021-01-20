
Option Explicit On
Option Strict On
Option Compare Binary
Module ControlFlow

    Sub Main()
        Dim firstNumber As Integer
        Dim secondNumber As Integer

        firstNumber = 10
        secondNumber = 8

        If firstNumber > secondNumber Then
            Console.WriteLine("First Number Is Bigger!!")
        ElseIf firstNumber < secondNumber Then
            Console.WriteLine("Second Number Is Bigger!!")
        Else
            Console.WriteLine("The Numbers Are Equal!!")
        End If






        Console.Read()
    End Sub

End Module
