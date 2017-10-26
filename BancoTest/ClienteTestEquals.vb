Imports BancoEntidades

Module ClienteTestEquals

    Sub Main()
        Dim person1a As New Cliente("John", 577657, #01-01-2000#)
        Dim person1b As Cliente = person1a
        Dim person2 As New Cliente(person1a.Nombre, person1a.Documento, person1a.fechaNacimiento)

        Console.WriteLine("Calling Equals:")
        Console.WriteLine("person1a and person1b: {0}", person1a.Equals(person1b))
        Console.WriteLine("person1a and person2: {0}", person1a.Equals(person2))
        Console.WriteLine()

        'Console.WriteLine("Casting to an Object and calling Equals:")
        'Console.WriteLine("person1a and person1b: {0}", CObj(person1a).Equals(CObj(person1b)))
        'Console.WriteLine("person1a and person2: {0}", CObj(person1a).Equals(CObj(person2)))
    End Sub
End Module
