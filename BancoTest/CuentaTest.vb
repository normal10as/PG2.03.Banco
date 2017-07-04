Imports BancoEntidades

Module CuentaTest
    Sub main()
        ' creacion e instanciacion
        Dim cuenta1 As New Cuenta()
        cuenta1.Numero = 54345345
        'no se puede hacer cuenta1.Balance = 530000000
        Console.WriteLine("Numero de cuenta: " & cuenta1.Numero)
        Console.WriteLine("Balance: " & cuenta1.Balance)
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
    End Sub
End Module
