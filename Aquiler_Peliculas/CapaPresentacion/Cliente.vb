Imports CapaEntidad
Imports CapaNegocio
Public Class Cliente
    Dim ec As New EntidadCliente
    Dim nc As New NegocioCliente
    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtgcliente.DataSource = nc.ConsultaCliente
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ec.Apellido = txtapellido.Text
        ec.Cod_Cli = txtcodigo.Text
        ec.Correo = txtcorreo.Text
        ec.Direccion = txtdireccion.Text
        ec.Nombre = txtnombre.Text
        ec.Telefono = txttelefono.Text
        nc.RegistarCliente(ec)
        MsgBox("Datos Registrados")
        txtapellido.Clear()
        txtcodigo.Clear()
        txtcorreo.Clear()
        txtdireccion.Clear()
        txtnombre.Clear()
        txttelefono.Clear()
        dtgcliente.DataSource = nc.ConsultaCliente
    End Sub
End Class
