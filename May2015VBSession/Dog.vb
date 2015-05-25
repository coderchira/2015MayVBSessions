Public Class Dog ' child class/ derived / sub
    Inherits Animal 'parent class / base / super

    Private _breed As String
    Public Property Breed() As String
        Get
            Return _breed
        End Get
        Set(ByVal value As String)
            _breed = value
        End Set
    End Property

    Sub New()
        Console.WriteLine("Hey we are inside the constructor of child class: Dog")
    End Sub
    Sub Jump()
        ' Name = "MyDog"
        '_another =
        Console.WriteLine("This is the dog jumping")
    End Sub

    Overrides Sub MakeSound()
        'different implemaentation
        Console.WriteLine("This is the dog barking")
    End Sub

   
End Class
