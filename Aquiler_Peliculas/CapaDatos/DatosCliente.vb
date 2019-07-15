Imports System.Data.SqlClient
Imports CapaEntidad
Public Class DatosCliente
    Dim Db As New SqlConnection
    Dim RG As New SqlCommand
    Dim Da As New SqlDataAdapter
    Dim conexion As String = ("Data Source=desktop-gg6h7tf;Initial Catalog=Peliculas;Integrated Security=True")
    Public Sub RegistarCliente(ByVal EnClie As EntidadCliente)
        RG = New SqlCommand("InsertarCliente", Db)
        RG.CommandType = CommandType.StoredProcedure
        RG.Parameters.AddWithValue("@Cod_Cli", EnClie.Cod_Cli)
        RG.Parameters.AddWithValue("@Nombre", EnClie.Nombre)
        RG.Parameters.AddWithValue("@Apellido", EnClie.Apellido)
        RG.Parameters.AddWithValue("@Direccion", EnClie.Direccion)
        RG.Parameters.AddWithValue("@Telefono", EnClie.Telefono)
        RG.Parameters.AddWithValue("@Correo", EnClie.Correo)
        RG.ExecuteNonQuery()
    End Sub
    Public Sub Conectar()
        Db = New SqlConnection(conexion)
        Db.Open()
    End Sub
    Public Sub Desconectar()
        Db.Close()
    End Sub
    Public Function ConsultaCliente()
        RG = New SqlCommand("ListaCliente", Db)
        RG.CommandType = CommandType.StoredProcedure
        Da = New SqlDataAdapter(RG)
        ConsultaCliente = New DataTable
        Da.Fill(ConsultaCliente)
    End Function
End Class
