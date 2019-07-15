Imports CapaDatos
Imports CapaEntidad
Public Class NegocioBoleta
    Dim dp As New DatosBoleta
    Public Sub RegistrarBoleta(ByVal EnBo As EntidadBoleta)
        dp.Conectar()
        dp.RegistrarBoleta(EnBo)
        dp.Desconectar()
    End Sub
    Public Function ConsultaBoleta()
        dp.Conectar()
        Return dp.ConsultaBoleta
        dp.Desconectar()
    End Function
End Class
