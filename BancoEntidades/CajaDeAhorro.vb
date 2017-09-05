Public NotInheritable Class CajaDeAhorro
    Inherits Cuenta

    Private _interesMensual As Single

    Sub New(numero As Integer, balance As Double, interesMensual As Single)
        MyBase.New(numero, balance)
        Me.InteresMensual = interesMensual
    End Sub

    Public Property InteresMensual As Single
        Get
            Return _interesMensual
        End Get
        Set(value As Single)
            _interesMensual = value
        End Set
    End Property

    Public Sub Capitalizar()
        _balance += Balance * InteresMensual / 100
    End Sub
End Class
