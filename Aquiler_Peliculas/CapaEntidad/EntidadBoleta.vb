Public Class EntidadBoleta
    Private _Id_Aquiler As String
    Private _Cod_Cli As String
    Private _Id_Peliculas As String
    Private _Fecha_De_Salida As Date
    Private _Fecha_Limite As Date
    Private _Precio As Integer

    Public Property Id_Aquiler As String
        Get
            Return _Id_Aquiler
        End Get
        Set(value As String)
            _Id_Aquiler = value
        End Set
    End Property

    Public Property Cod_Cli As String
        Get
            Return _Cod_Cli
        End Get
        Set(value As String)
            _Cod_Cli = value
        End Set
    End Property

    Public Property Id_Peliculas As String
        Get
            Return _Id_Peliculas
        End Get
        Set(value As String)
            _Id_Peliculas = value
        End Set
    End Property

    Public Property Fecha_De_Salida As Date
        Get
            Return _Fecha_De_Salida
        End Get
        Set(value As Date)
            _Fecha_De_Salida = value
        End Set
    End Property

    Public Property Fecha_Limite As Date
        Get
            Return _Fecha_Limite
        End Get
        Set(value As Date)
            _Fecha_Limite = value
        End Set
    End Property
    Public Property Precio As Integer
        Get
            Return _Precio
        End Get
        Set(value As Integer)
            _Precio = value
        End Set
    End Property
End Class
