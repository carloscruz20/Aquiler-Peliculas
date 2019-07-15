Public Class EntidadCliente
    Private _Cod_Cli As String
    Private _Nombre As String
    Private _Apellido As String
    Private _Direccion As String
    Private _Telefono As String
    Private _Correo As String

    Public Property Cod_Cli As String
        Get
            Return _Cod_Cli
        End Get
        Set(value As String)
            _Cod_Cli = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Apellido As String
        Get
            Return _Apellido
        End Get
        Set(value As String)
            _Apellido = value
        End Set
    End Property
    Public Property Direccion As String
        Get
            Return _Direccion
        End Get
        Set(value As String)
            _Direccion = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _Telefono
        End Get
        Set(value As String)
            _Telefono = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _Correo
        End Get
        Set(value As String)
            _Correo = value
        End Set
    End Property
End Class
