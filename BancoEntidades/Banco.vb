Public Class Banco
    Private Shared _clientes As List(Of Cliente)

    Shared Sub New()
        _clientes = New List(Of Cliente)
    End Sub

    Public Shared Sub addCliente(cliente As Cliente)
        _clientes.Add(cliente)
    End Sub

    Public Shared Sub removeCliente(cliente As Cliente)
        _clientes.Remove(cliente)
    End Sub

    Public Shared Function getAllClientes() As List(Of Cliente)
        Return _clientes
    End Function
End Class
