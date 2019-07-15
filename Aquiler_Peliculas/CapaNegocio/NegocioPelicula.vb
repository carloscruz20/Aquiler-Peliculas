Imports CapaDatos
Imports CapaEntidad
Public Class NegocioPelicula
    Dim dp As New DatosPelicula
    Public Sub RegistraPelicula(ByVal EnPel As EntidadPelicula)
        dp.Conectar()
        dp.RegistraPelicula(EnPel)
        dp.Desconectar()
    End Sub
    Public Function ConsultaPelicuala()
        dp.Conectar()
        Return dp.ConsultaPelicuala
        dp.Desconectar()
    End Function
End Class
