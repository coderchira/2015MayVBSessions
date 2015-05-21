Module LogicDemo
    'Logic
    '   Function
    '       They return a value
    '   Subroutines
    '       They do not return a value

    'Lifecycle of logic blocks
    '   Declare
    '       Keyword Function 
    '       Name of the function
    '       Return type
    '   Implement/ Body
    '   Call


    'Returns a value
    Dim modVar As Integer ' Module level variable 
    'Dim is Private
    'Access Modifiers 
    Public var As Integer
    Function DoThis() As Integer
        'body of the function
        'Call a sub
        'DoThisAsWell()
        'Dim rtr As Boolean 'Logic block variable and scope is limited to this function
        modVar = 20
        Return 0
    End Function

    'Does not return a value
    Sub DoThisAsWell()
        'body of the subroutine
        'Call a function
        ' DoThis()
        Dim flag As Boolean 'Logic block variable and scope is limited to this subroutine
        flag = Calculation(12, 12.0, "Ruchira")
        modVar = 30
    End Sub

    'Signature of the function
    '   Name
    '   No. of parameters
    '   Type of parameters
    '   Sequence of parameters
    '   Return type of the function
    '   Security

    'Function overloading
    Function Calculation(num As Integer, weight As Single, name As String) As Boolean

        'Conditional statements
        If num = 10 Then
            'body of the if block  -- do something
            Console.WriteLine("The num value is " & num)
            'num = 20
        ElseIf num > 10 Then
            'Do something else
            Console.WriteLine("The number value is greater than 10")
        Else
            ' Do something else of above conditions are false
            Console.WriteLine("The above conditions are false")
        End If
        Console.ReadLine()

        ' Nested ifs
        If name = "Ruchira" Then
            If num > 10 Then
                Console.WriteLine("We are inside nested ifs")
            ElseIf num <= 10 Then

            Else
                Console.WriteLine(" We are inside else of nested if")
            End If
        End If

        'Select
        Select Case num
            Case 10
                'Do something
            Case 20
                'Do something
            Case 12, 13, 14 Or num > 10
                'Do Something
        End Select

        'Looping statements
        For counter = 3 To 5
            Console.WriteLine(counter)
        Next
        Console.ReadLine()

        For index = 1 To 10 Step 2
            'Prints 1, 3, 5 and so on
            Console.WriteLine(index)
        Next

        For index2 = 10 To 1 Step -2
            Console.WriteLine(index2)
        Next

        Dim mycoll As New Collection
        For index3 = 1 To 5
            mycoll.Add(index3)
        Next

        For Each item In mycoll
            Console.WriteLine(CStr(item))
        Next
        Console.ReadLine()

        'While Loop
        While num >= 10
            'Do something
            Console.WriteLine("The number value is " & num)
            num = num - 1
        End While

        'Do While
        Do
            'Do something
            Console.WriteLine("This piece of code will be executed atleast once! ")
            num = num - 1
        Loop While num >= 10

        Return True
    End Function

    Function Calculation(int As Integer) As String
        Return "Good"
    End Function

    Function Calculation(flag As Boolean, weight As Single) As Boolean

        Return True
    End Function

End Module
