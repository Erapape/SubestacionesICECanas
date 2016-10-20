Public Class SubestacionEntidad
    Private Id_Subestacion As Integer
    Private NombreSubestacion As String


    Public Property Id_Subestacion_s() As Integer

        Get
            Return Id_Subestacion
        End Get
        Set(value As Integer)
            Id_Subestacion = value
        End Set

    End Property

    Public Property NombreSubestacion_s() As String

        Get
            Return Id_Subestacion
        End Get
        Set(value As String)
            Id_Subestacion = value
        End Set
    End Property
End Class
