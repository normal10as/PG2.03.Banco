Imports BancoEntidades

Module CuentaCorrienteTest
    Sub main()
        ' creacion e instanciacion
        Dim cliente1 As New Cliente("Neymar", 463743, #01-01-1993#)
        Dim cuenta1 As New CuentaCorriente(432432, 0, 1000, cliente1)
        'cuenta1.Numero = 54345345
        'cuenta1.MontoSobregiro = 1000
        'no se puede hacer cuenta1.Balance = 530000000
        Console.WriteLine("toString: " & cuenta1.ToString)
        Console.WriteLine("Numero de cuenta: " & cuenta1.Numero)
        Console.WriteLine("Balance: " & cuenta1.Balance)
        Console.WriteLine("Monto de sobregiro: " & cuenta1.MontoSobregiro)
        ' test de metodos
        Dim monto As Double = 1000
        Console.WriteLine("Deposito " & monto)
        cuenta1.Depositar(monto)
        Console.WriteLine("Balance: " & cuenta1.Balance)
        monto = 500
        Console.WriteLine("Extraigo {0}: " & cuenta1.Extraer(monto), monto)
        Console.WriteLine("Balance: " & cuenta1.Balance)
        monto = 600
        Console.WriteLine("Extraigo {0}: " & cuenta1.Extraer(monto), monto)
        Console.WriteLine("Balance: " & cuenta1.Balance)
        monto = 1000
        Console.WriteLine("Extraigo {0}: " & cuenta1.Extraer(monto), monto)
        Console.WriteLine("Balance: " & cuenta1.Balance)

        Dim cuenta2 As Cuenta
        'cuenta2 = New CuentaCorriente(54354, 0, 1000, New Cliente("Neymar", 463743, #01-01-1993#))
        cuenta2 = New CuentaCorriente(54354, 0, 1000, cliente1)
        monto = 900
        Console.WriteLine("Extraigo {0}: " & cuenta2.Extraer(monto), monto)
        Console.WriteLine("Balance: " & cuenta2.Balance)

        Console.WriteLine("Cuenta - Cliente")
        For Each cuenta As Cuenta In cliente1.getAllCuentas()
            Console.WriteLine(cuenta.ToString & " - " & cuenta.cliente.ToString())
        Next
    End Sub
End Module
