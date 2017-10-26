Imports BancoEntidades

Module ClienteTest

    Sub Main()
        ' declaración
        Dim cliente1 As Cliente
        ' instanciacion
        cliente1 = New Cliente()
        ' test de setters
        cliente1.Nombre = "Pepe"
        cliente1.Documento = 676765
        cliente1.fechaNacimiento = #4-20-1989#
        ' test de getters
        Console.WriteLine("Nombre: " & cliente1.Nombre)
        Console.WriteLine("Documento: " & cliente1.Documento)
        Console.WriteLine("Fecha de nacimiento: " & cliente1.fechaNacimiento)
        Console.WriteLine("ToString: " & cliente1.ToString())

        Dim cliente2 As New Cliente("Juan", 7797987, #5-12-1990#)
        Console.WriteLine("Nombre: " & cliente2.Nombre)
        Console.WriteLine("Documento: " & cliente2.Documento)
        Console.WriteLine("Fecha de nacimiento: " & cliente2.fechaNacimiento)
        Console.WriteLine("ToString: " & cliente2.ToString())

        Dim cliente3 As New Cliente(cliente1.Nombre, cliente1.Documento, cliente1.fechaNacimiento)
        Console.WriteLine("cliente1  and cliente2: {0}", cliente1.Equals(cliente2))
        Console.WriteLine("cliente1 and cliente3: {0}", cliente1.Equals(cliente3))
    End Sub

End Module
