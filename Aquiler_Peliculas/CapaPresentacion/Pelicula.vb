Imports CapaEntidad
Imports CapaNegocio
Public Class Pelicula
    Dim ep As New EntidadPelicula
    Dim np As New NegocioPelicula
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ep.Clasificacion = ComboBox1.Text
        ep.Id_Peliculas = txtid.Text
        ep.Nombre_Peli = txtnombre.Text
        np.RegistraPelicula(ep)
        MsgBox("Datos Registrados")
        txtid.Clear()
        txtnombre.Clear()
        DataGridView1.DataSource = np.ConsultaPelicuala
    End Sub

    Private Sub Pelicula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = np.ConsultaPelicuala
    End Sub
End Class