Public Class Banco
    Private _clientes As List(Of Cliente)

    Sub New()
        _clientes = New List(Of Cliente)
    End Sub

    Public Sub addCliente(cliente As Cliente)
        _clientes.Add(cliente)
    End Sub

    Public Sub removeCliente(cliente As Cliente)
        _clientes.Remove(cliente)
    End Sub

    Public Function getAllClientes() As List(Of Cliente)
        Return _clientes
    End Function
End Class
