'Brayden Peck
'RCET0265
'Spring 2021
'Store Messages
'https://github.com/PeckBray/StoreMessage
Module StoreMessages

    Sub Main()
        Dim userInput As String
        Dim clear As Boolean
        Dim list As String

        Console.WriteLine("press""Q"" at any time to quit")
        Console.WriteLine("Enter messages to store. Enter ""read"" at any time to see the list of stored messages. Enter ""clear"" at any time to clear stored messages.")

        While userInput <> "Q" And userInput <> "q"
            userInput = Console.ReadLine()
            clear = False
            If userInput = "clear" Then
                clear = True
            ElseIf userInput = "Clear" Then
                clear = True
            End If
            UserMessages(userInput, clear)
        End While
    End Sub

    Function UserMessages(ByVal newMessage As String, clear As Boolean)
        Static messages As String
        If newMessage = "read" Then
            Console.Write($"{messages}")
        ElseIf newMessage = "Read" Then
            Console.Write($"{messages}")
        ElseIf clear = True Then
            messages = ""
        Else
            messages = $"{messages} {newMessage}" + vbNewLine
        End If


        Return (messages)
    End Function

End Module
