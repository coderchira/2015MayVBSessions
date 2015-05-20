Module Module1

    Sub Main()
        'What is a Program?
        '   Data <----> Logic  (Bidirectional relationship)
        '       Data
        '           Variables -- change their values
        '               Native type(Stack)
        '                   Faster to access
        '                   They have fixed size
        '                   Dispose on their own
        '               Reference type(Heap)
        '                   Slower
        '                   Their size varies
        '                   Disposed explicitly
        '           Lifecycle of variables
        '               Declare
        '               Assign/Use
        '               Dispose
        '           Constants -- they do not change their value

        'Native type
        'Declare a variable
        Dim flag As Boolean '2 bytes
        Dim num As Integer '4 bytes
        Dim precision As Single ' 4 bytes
        Dim precisionDouble As Double '8 bytes
        Dim accuracy As Decimal '16 bytes
        Dim message As String 'dependent on the value of string

        'Use variables
        flag = True
        num = 10
        precision = 0.1234567
        precisionDouble = 0.123456789101112
        accuracy = 0.12322153215312573
        message = "Day 1 of VB session"

        'Displaying the values on the console window
        Console.WriteLine(flag)
        Console.ReadLine()

        'Integer operations
        Dim leftInt As Integer
        Dim rightInt As Integer
        Dim addNums As Integer
        Dim prodNums As Integer
        Dim subNums As Integer
        Dim divNums As Single
        Dim remainder As Integer
        Dim quotient As Single

        leftInt = 10
        rightInt = 20
        addNums = leftInt + rightInt
        subNums = rightInt - leftInt
        prodNums = rightInt * leftInt
        divNums = rightInt / leftInt
        quotient = Math.DivRem(rightInt, leftInt, remainder)

        'String operations
        Dim message1 As String
        Dim message2 As String
        Dim resultMsg As String

        message1 = "This is Day 1 of VB session"
        message2 = " and we are confident of learning in this session"

        'Concatenation of two strings
        'resultMsg = message1 & message2 ' safest way to concatenate
        resultMsg = message1 + message2  ' might give you unexpected results
        Console.WriteLine(resultMsg)
        Console.ReadLine()

        Dim numAsStr As String
        Dim num2AsStr As String
        Dim result As String

        'If variables are declared as strings ; the numerals are concatenated too
        numAsStr = "1"
        num2AsStr = "2"
        result = num2AsStr + numAsStr
        Console.WriteLine(result)
        Console.ReadLine()

        'Position of a string within a string
        Dim position As Integer
        Dim position2 As Integer

        'position = InStr(resultMsg.ToLower(), "vb")
        position = InStr(resultMsg.ToUpper(), "VB")
        Console.WriteLine("The position of 'session' in the resultmsg is " & position)
        Console.ReadLine()

        position2 = InStr(position + 1, resultMsg, "session")
        Console.WriteLine("The position of second word 'session' in the resultmsg is " & position2)
        Console.ReadLine()

        Dim leftPortion As String
        Dim rightPortion As String
        leftPortion = Left(resultMsg, 25)
        rightPortion = Right(resultMsg, 20)
        Console.WriteLine("The left portion is : " & leftPortion)
        Console.WriteLine("The right portion is :" & rightPortion)
        Console.ReadLine()

        'Conversion
        Dim newNum As Integer
        Dim numAsString As String
        newNum = 20
        numAsString = newNum.ToString()
        numAsString = CStr(newNum)

        Dim newStr As String
        Dim strAsNumber As Integer
        newStr = "100"
        strAsNumber = CInt(newStr)

        Dim str As String
        str = "1.23"
        Dim dblvalue As Double
        dblvalue = CDbl(str)

        'Reference type /Object type
        Dim myColl As New Collection ' capable of holding any native type variable 
        'Adding items to collection
        myColl.Add(20)
        myColl.Add("Ruchira")
        myColl.Add(True)

        'Retreiving from the collection
        Console.WriteLine("The values in collection are {0}, {1}, {2} ", myColl.Item(1), myColl.Item(2), myColl.Item(3))
        Console.ReadLine()

        'Remove items in collection
        myColl.Remove(2)
        Console.WriteLine("The values in collection are {0}, {1} ", myColl.Item(1), myColl.Item(2))
        Console.ReadLine()

        'Dispose a reference type variable
        myColl = Nothing
        'Console.WriteLine("The values in collection are {0}, {1} ", myColl.Item(1), myColl.Item(2))

    End Sub
End Module
