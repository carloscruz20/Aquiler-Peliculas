Imports System.Data.SqlClient
Imports CapaEntidad
Public Class DatosBoleta
    Dim Db As New SqlConnection
    Dim RG As New SqlCommand
    Dim Da As New SqlDataAdapter
    Dim conexion As String = ("Data Source=desktop-gg6h7tf;Initial Catalog=Peliculas;Integrated Security=True")
    Public Sub RegistrarBoleta(ByVal EnBo As EntidadBoleta)
        RG = New SqlCommand("InseBoleta", Db)
        RG.CommandType = CommandType.StoredProcedure
        RG.Parameters.AddWithValue("@Id_Aquiler", EnBo.Id_Aquiler)
        RG.Parameters.AddWithValue("@Cod_Cli", EnBo.Cod_Cli)
        RG.Parameters.AddWithValue("@Id_Peliculas", EnBo.Id_Peliculas)
        RG.Parameters.AddWithValue("@Fecha_De_Salida", EnBo.Fecha_De_Salida)
        RG.Parameters.AddWithValue("@Fecha_Limite", EnBo.Fecha_Limite)
        RG.Parameters.AddWithValue("@Precio", EnBo.Precio)
        RG.ExecuteNonQuery()
    End Sub
    Public Sub Conectar()
        Db = New SqlConnection(conexion)
        Db.Open()
    End Sub
    Public Sub Desconectar()
        Db.Close()
    End Sub
    Public Function ConsultaBoleta()
        RG = New SqlCommand("ListaBoleta", Db)
        RG.CommandType = CommandType.StoredProcedure
        Da = New SqlDataAdapter(RG)
        ConsultaBoleta = New DataTable
        Da.Fill(ConsultaBoleta)
    End Function
End Class
