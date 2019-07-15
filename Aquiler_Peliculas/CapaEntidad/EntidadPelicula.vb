Public Class EntidadPelicula
    Private _Id_Peliculas As String
    Private _Nombre_Peli As String
    Private _Clasificacion As String
    Public Property Id_Peliculas As String
        Get
            Return _Id_Peliculas
        End Get
        Set(value As String)
            _Id_Peliculas = value
        End Set
    End Property

    Public Property Nombre_Peli As String
        Get
            Return _Nombre_Peli
        End Get
        Set(value As String)
            _Nombre_Peli = value
        End Set
    End Property

    Public Property Clasificacion As String
        Get
            Return _Clasificacion
        End Get
        Set(value As String)
            _Clasificacion = value
        End Set
    End Property
End Class
