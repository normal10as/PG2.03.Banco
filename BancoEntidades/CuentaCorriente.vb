Public NotInheritable Class CuentaCorriente
    Inherits Cuenta
    Private _montoSobregiro As Single

    Sub New(numero As Integer, balance As Double, montoSobregiro As Single)
        MyBase.New(numero, balance)
        Me.MontoSobregiro = montoSobregiro
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

End Class
