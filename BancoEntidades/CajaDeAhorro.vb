Public NotInheritable Class CajaDeAhorro
    Inherits Cuenta

    Private _interesMensual As Single

    Sub New()
        MyBase.New
        _interesMensual = 0
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

    End Sub
End Class
