Public Class EquiposEntidad

    Private Id_Equipos_E As Integer
    Private Id_Distritos_E As Integer
    Private Marca_E As String
    Private Tipo_E As String
    Private NuICE_Marca_E As Integer
    Private Modelo_E As String
    Private Control_E As String
    Private NuICE_Cont_E As Integer
    Private SCADA_E As Boolean
    Private Remota_E As String
    Private NuICE_Rem_E As Integer
    Private Localizacion_E As Integer
    Private Ubicacion_E As String


    Public Property Id_Equipos() As Integer

        Get
            Return Id_Equipos
        End Get
        Set(value As Integer)
            Id_Equipos_E = value
        End Set

    End Property


    Public Property Id_Distritos() As Integer

        Get
            Return Id_Distritos_E
        End Get
        Set(value As Integer)
            Id_Distritos_E = value
        End Set

    End Property


    Public Property Marca() As String

        Get
            Return Marca_E
        End Get
        Set(value As String)
            Marca_E = value
        End Set

    End Property


    Public Property Tipo() As String

        Get
            Return Tipo_E
        End Get
        Set(value As String)
            Tipo_E = value
        End Set

    End Property


    Public Property NuICE_Marca() As Integer

        Get
            Return NuICE_Marca_E
        End Get
        Set(value As Integer)
            NuICE_Marca_E = value
        End Set

    End Property


    Public Property Modelo() As String

        Get
            Return Modelo_E
        End Get
        Set(value As String)
            Modelo_E = value
        End Set

    End Property


    Public Property Control() As String

        Get
            Return Control_E
        End Get
        Set(value As String)
            Control_E = value
        End Set

    End Property


    Public Property NuICE_Cont() As Integer

        Get
            Return NuICE_Cont_E
        End Get
        Set(value As Integer)
            NuICE_Cont_E = value
        End Set

    End Property


    Public Property SCADA() As Boolean

        Get
            Return SCADA_E
        End Get
        Set(value As Boolean)
            SCADA_E = value
        End Set

    End Property


    Public Property Remota() As String

        Get
            Return Remota_E
        End Get
        Set(value As String)
            Remota_E = value
        End Set

    End Property


    Public Property NuICE_Rem() As Integer

        Get
            Return NuICE_Rem_E
        End Get
        Set(value As Integer)
            NuICE_Rem_E = value
        End Set

    End Property


    Public Property Localizacion() As Integer

        Get
            Return Localizacion_E
        End Get
        Set(value As Integer)
            Localizacion_E = value
        End Set

    End Property


    Public Property Ubicacion() As String

        Get
            Return Ubicacion_E
        End Get
        Set(value As String)
            Ubicacion_E = value
        End Set

    End Property

End Class
