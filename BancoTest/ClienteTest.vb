Imports BancoEntidades

Module ClienteTest

    Sub Main()
        ' declaración
        Dim cliente1 As Cliente
        ' instanciacion
        cliente1 = New Cliente
        ' test de setters
        cliente1.Nombre = "Pepe"
        cliente1.Documento = 676765
        cliente1.fechaNacimiento = #4-20-1989#
        ' test de getters
        Console.WriteLine("Nombre: " & cliente1.Nombre)
        Console.WriteLine("Documento: " & cliente1.Documento)
        Console.WriteLine("Fecha de nacimiento: " & cliente1.fechaNacimiento)

        Dim cliente2 As New Cliente("Juan", 7797987, #5-12-1990#)
        Console.WriteLine("Nombre: " & cliente2.Nombre)
        Console.WriteLine("Documento: " & cliente2.Documento)
        Console.WriteLine("Fecha de nacimiento: " & cliente2.fechaNacimiento)
    End Sub

End Module
