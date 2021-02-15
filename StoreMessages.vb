'Brayden Peck
'RCET0265
'Spring 2021
'Store Messages
'https://github.com/PeckBray/StoreMessage
Module StoreMessages

    Sub Main()
        Dim userInput As String
        Dim list As String = ""

        Console.WriteLine("press""Q"" at any time to quit")
        Console.WriteLine("Enter messages to store. Enter ""read"" at any time to see the list of stored messages. Enter ""clear"" at any time to clear stored messages.")

        While userInput <> "Q" And userInput <> "q"
            userInput = Console.ReadLine()
            list = MessageList(userInput, list)
        End While
    End Sub

    Function MessageList(input As String, list As String)
        If input = "read" Then
            Console.Write($"{list}")
        ElseIf input = "Read" Then
            Console.Write($"{list}")
        ElseIf input = "clear" Then
            list = ""
        ElseIf input = "Clear" Then
            list = ""
        Else
            list = $"{list} {input}" + vbNewLine
        End If


        Return (list)
    End Function

End Module
