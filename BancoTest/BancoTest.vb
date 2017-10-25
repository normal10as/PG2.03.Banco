Imports BancoEntidades

Module BancoTest
    Sub main()
        'Dim banco As New Banco()
        Console.WriteLine("Agrego 2 clientes")
        Dim cliente1 = New Cliente("Neymar", 463743, #01-01-1993#)
        Banco.addCliente(cliente1)
        Banco.addCliente(New Cliente("Icardi", 545454, #08-08-1993#))
        Console.WriteLine("Mostrar")

        For Each cliente As Cliente In Banco.getAllClientes
            Console.WriteLine(cliente.ToString)
        Next

        Dim documento As Integer = 463743
        Console.WriteLine(Banco.containsCliente(cliente1))
        Console.WriteLine(Banco.existsClienteByDocumento(documento))
        Console.WriteLine(Banco.findClienteByDocumento(documento))
        Console.WriteLine("Buscar Ney")
        For Each cliente As Cliente In Banco.findAllClientesByNombre("Ney")
            Console.WriteLine(cliente.ToString)
        Next

        Console.WriteLine("Buscar r")
        For Each cliente As Cliente In Banco.findAllClientesByNombre("r")
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
