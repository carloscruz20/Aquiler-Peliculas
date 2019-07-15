Imports CapaDatos
Imports CapaEntidad
Public Class NegocioCliente
    Dim dp As New DatosCliente
    Public Sub RegistarCliente(ByVal EnClie As EntidadCliente)
        dp.Conectar()
        dp.RegistarCliente(EnClie)
        dp.Desconectar()
    End Sub
    Public Function ConsultaCliente()
        dp.Conectar()
        Return dp.ConsultaCliente
        dp.Desconectar()
    End Function
End Class
