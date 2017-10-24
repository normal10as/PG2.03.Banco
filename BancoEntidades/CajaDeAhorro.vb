Public NotInheritable Class CajaDeAhorro
    Inherits Cuenta

    Private Shared _interesMensual As Single

    Shared Sub New()
        InteresMensual = 1
    End Sub

    'Sub New(numero As Integer, balance As Double, interesMensual As Single, cliente As Cliente)
    Sub New(numero As Integer, balance As Double, cliente As Cliente)
        MyBase.New(numero, balance, cliente)
        'InteresMensual = InteresMensual
    End Sub

    Public Shared Property InteresMensual As Single
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
