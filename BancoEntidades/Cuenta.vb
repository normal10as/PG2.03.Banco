Public MustInherit Class Cuenta

    Private _numero As Integer
    Protected _balance As Double

    Sub New()
        _numero = 0
        _balance = 0
    End Sub

    Public Property Numero As Integer
        Get
            Return _numero
        End Get
        Set(value As Integer)
            _numero = value
        End Set
    End Property

    Public ReadOnly Property Balance As Double
        Get
            Return _balance
        End Get
    End Property

    Public Sub Depositar(value As Double)
        _balance = _balance + value
    End Sub

    Public Overridable Function Extraer(value As Double) As Boolean
        If _balance >= value Then
            _balance = _balance - value
            Return True
        Else
            Return False
        End If
    End Function
End Class
