Public Class Cliente
    Private _nombre As String
    Private _documento As Integer
    Private _fechaNacimiento As Date

    ' constructor
    Sub New()
        _nombre = ""
        _documento = 0
        _fechaNacimiento = Nothing
    End Sub

    Sub New(nombre As String, documento As Integer, fechaNacimiento As Date)
        Me.New()
        Me.Nombre = nombre
        Me.Documento = documento
        Me.fechaNacimiento = fechaNacimiento
    End Sub

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value.Length <= 30 Then
                _nombre = value
            End If
        End Set
    End Property

    Public Property Documento As Integer
        Get
            Return _documento
        End Get
        Set(value As Integer)
            _documento = value
        End Set
    End Property

    Public Property fechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            _fechaNacimiento = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Nombre & "(" & Documento & ")"
    End Function
End Class
