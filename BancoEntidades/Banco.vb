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

    Public Shared Function containsCliente(cliente As Cliente) As Boolean
        Return _clientes.Contains(cliente)
    End Function

    Public Shared Function existsClienteByDocumento(documento As Integer) As Boolean
        Return _clientes.Exists(Function(c) c.Documento = documento)
    End Function

    Public Shared Function findClienteByDocumento(documento As Integer) As Cliente
        Return _clientes.Find(Function(c) c.Documento = documento)
    End Function

    Public Shared Function findAllClientesByNombre(nombre As String) As List(Of Cliente)
        Return _clientes.FindAll(Function(c) c.Nombre.Contains(nombre))
    End Function
End Class
