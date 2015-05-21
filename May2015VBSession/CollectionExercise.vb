Module CollectionExercise
    ' 2 Collections
    '   The first has 10 names
    '   The second is empty
    '   In the second one you have to transfer all those names except your name
    Dim coll1 As New Collection
    Dim coll2 As New Collection
    Dim myName As String

    Sub ExerciseSolution()
        'Adding the items in collection 1
        coll1.Add("Aditi")
        coll1.Add("Alaka")
        coll1.Add("Aldo")
        coll1.Add("Amol")
        coll1.Add("Anupam")
        coll1.Add("Arsath")
        coll1.Add("Vinod")
        coll1.Add("Mouli")
        coll1.Add("Satya")
        coll1.Add("Ruchira")

        'User's input in name variable
        myName = Console.ReadLine().ToString()

        'myName = "Ruchira"
        'Add items in collection 2 where condition is true
        For Each item In coll1
            Console.WriteLine(item)
            If item <> myName Then
                coll2.Add(item)
            End If
        Next

        'Print items in collection 2
        For Each item In coll2
            Console.WriteLine(item)
        Next
        Console.ReadLine()

        'Another way to approach the solution
        ' Add all items of collection in collection 2
        ' Remove the item which contains your name

    End Sub
End Module
