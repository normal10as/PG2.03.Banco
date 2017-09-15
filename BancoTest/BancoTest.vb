Imports BancoEntidades

Module BancoTest
    Sub main()
        Dim banco1 As New Banco()
        Console.WriteLine("Agrego 2 clientes")
        Dim cliente1 = New Cliente("Neymar", 463743, #01-01-1993#)
        banco1.addCliente(cliente1)
        banco1.addCliente(New Cliente("Icardi", 545454, #08-08-1993#))
        Console.WriteLine("Mostrar")

        For Each cliente As Cliente In banco1.getAllClientes
            Console.WriteLine(cliente.ToString)
        Next
        Console.WriteLine("Eliminar")
        banco1.removeCliente(cliente1)
        Console.WriteLine("Mostrar")
        For Each cliente As Cliente In banco1.getAllClientes
            Console.WriteLine(cliente.ToString)
        Next

    End Sub
End Module
