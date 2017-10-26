Imports BancoEntidades

Module BancoTest
    Sub main()
        'Dim banco As New Banco()
        Console.WriteLine("Agrego 2 clientes")
        Dim documentoNEymar As Integer = 463743
        Dim cliente1 = New Cliente("Neymar", documentoNEymar, #01-01-1993#)
        Banco.addCliente(cliente1)
        Banco.addCliente(New Cliente("Icardi", 545454, #08-08-1993#))
        Console.WriteLine("Mostrar")

        Console.WriteLine("Buscar Neymar")
        Console.WriteLine(Banco.containsCliente(cliente1))

        Console.WriteLine("Buscar Neymar x documento")
        Console.WriteLine(Banco.existsClienteByDocumento(documentoNEymar))

        Console.WriteLine("Obtener Neymar x documento")
        Console.WriteLine(Banco.findClienteByDocumento(documentoNEymar))

        Console.WriteLine("Mostrar nombres con una d")
        For Each cliente As Cliente In Banco.findAllClientesByNombre("d")
            Console.WriteLine(cliente.ToString)
        Next
        Console.WriteLine("Mostrar nombres con una r")
        For Each cliente As Cliente In Banco.findAllClientesByNombre("r")
            Console.WriteLine(cliente.ToString)
        Next
        Console.WriteLine("Mostrar todos")
        For Each cliente As Cliente In Banco.getAllClientes
            Console.WriteLine(cliente.ToString)
        Next
        Console.WriteLine("Eliminar")
        Banco.removeCliente(cliente1)
        Console.WriteLine("Mostrar")
        For Each cliente As Cliente In Banco.getAllClientes
            Console.WriteLine(cliente.ToString)
        Next

    End Sub
End Module
