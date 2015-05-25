Public Class Animal
    'classes are also refered as entities/nouns
    Private _name As String
    Private _age As Integer
    Private _color As String
    Protected _another As String
    'Sub setName(value As String)
    '    _name = value
    'End Sub
    'Function getName() As String
    '    Return _name
    'End Function

    'Sub setAge(value As Integer)
    '    _age = value
    'End Sub
    'Function getAge() As Integer
    '    Return _age
    'End Function

    'Sub setColor(value As String)
    '    _color = value
    'End Sub
    'Function getColor() As String
    '    Return _color
    'End Function

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property


    Public WriteOnly Property Age() As String
        Set(value As String)
            _age = value
        End Set
    End Property


    Public Property Color() As String
        Get
            Return _color
        End Get
        Set(ByVal value As String)
            _color = value
        End Set
    End Property

    Sub New()
        Console.WriteLine("Hey, we are inside the constructor of base class :Animal")
    End Sub

    Sub New(name As String)
        name = "FirstAnimal"
    End Sub

    'Polymorphism
    Overridable Sub MakeSound()
        'Do Something
        Console.WriteLine("Animal makes a sound")
    End Sub

    Sub Walk()
        Console.WriteLine("Animal walks")
    End Sub
End Class
