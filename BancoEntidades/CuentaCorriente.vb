Public NotInheritable Class CuentaCorriente
    Inherits Cuenta
    Private _montoSobregiro As Single

    Sub New()
        MyBase.New
        _montoSobregiro = 0
    End Sub

    Public Property MontoSobregiro As Single
        Get
            Return _montoSobregiro
        End Get
        Set(value As Single)
            _montoSobregiro = value
        End Set
    End Property

    Public Overrides Function Extraer(value As Double) As Boolean
        If Balance + MontoSobregiro >= value Then
            _balance = Balance - value
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub Capitalizar()

    End Sub
End Class
