Imports System.Data.SqlClient
Imports CapaEntidad
Public Class DatosPelicula
    Dim Db As New SqlConnection
    Dim RG As New SqlCommand
    Dim Da As New SqlDataAdapter
    Dim conexion As String = ("Data Source=desktop-gg6h7tf;Initial Catalog=Peliculas;Integrated Security=True")
    Public Sub RegistraPelicula(ByVal EnPel As EntidadPelicula)
        RG = New SqlCommand("InsertarPeliculas", Db)
        RG.CommandType = CommandType.StoredProcedure
        RG.Parameters.AddWithValue("@Id_Peliculas", EnPel.Id_Peliculas)
        RG.Parameters.AddWithValue("@Nombre_Peli", EnPel.Nombre_Peli)
        RG.Parameters.AddWithValue("@Clasificacion", EnPel.Clasificacion)
        RG.ExecuteNonQuery()
    End Sub
    Public Sub Conectar()
        Db = New SqlConnection(conexion)
        Db.Open()
    End Sub
    Public Sub Desconectar()
        Db.Close()
    End Sub
    Public Function ConsultaPelicuala()
        RG = New SqlCommand("ListaPelicula", Db)
        RG.CommandType = CommandType.StoredProcedure
        Da = New SqlDataAdapter(RG)
        ConsultaPelicuala = New DataTable
        Da.Fill(ConsultaPelicuala)
    End Function
End Class
