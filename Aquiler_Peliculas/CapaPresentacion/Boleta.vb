Imports CapaEntidad
Imports CapaNegocio
Public Class Boleta
    Dim eb As New EntidadBoleta
    Dim nb As New NegocioBoleta
    Private Sub Boleta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = nb.ConsultaBoleta
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        eb.Cod_Cli = txtcliente.Text
        eb.Fecha_De_Salida = dtp1.Value
        eb.Fecha_Limite = dtp2.Value
        eb.Id_Aquiler = txtboleta.Text
        eb.Id_Peliculas = txtpelicula.Text
        eb.Precio = txtprecio.Text
        nb.RegistrarBoleta(eb)
        MsgBox("Dtos Registrados")
        txtboleta.Clear()
        txtcliente.Clear()
        txtpelicula.Clear()
        txtprecio.Clear()
        DataGridView1.DataSource = nb.ConsultaBoleta
    End Sub
End Class