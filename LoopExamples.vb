Option Strict On
Option Explicit On

Module LoopExamples

    Sub main()
        Dim someText As String
        Dim countBy As Integer = 1
        'For i = 0 To 10 Step countBy
        '    someText &= "*"
        '    Console.WriteLine(someText)
        '    If i >= 9 Then
        '        countBy = -1
        '    End If
        'Next

        'For i = 0 To 10

        '    For j = 0 To 10
        '        Console.Write(j)
        '    Next
        '    Console.WriteLine("*")
        'Next


        Dim loopCount As Integer = 1
        Dim countUp As Boolean = True
        Dim fullLoop As Integer
        Dim totalLoops As Integer

        While loopCount < 10 Or loopCount < 1

            Console.WriteLine(StrDup(loopCount, "*"))
            If loopCount = 0 Then
                countUp = True
                fullLoop += 1
            End If

            If fullLoop = 10 Then
                Exit While
            End If

            If loopCount >= 9 Then
                countUp = False
            End If

            If countUp = True Then
                loopCount += 1
            Else
                loopCount -= 1
            End If

            totalLoops += 1
        End While
        Console.WriteLine(totalLoops)
        Console.ReadLine()
    End Sub

End Module
