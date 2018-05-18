Public Class ClMdlCliente
    Dim cliente_id As Integer
    Dim documento As String
    Dim nombre As String
    Dim apellido As String
    Dim fecha_nacimiento As String
    Dim direccion As String
    Dim telefono As String
    Dim celular As String
    Dim genero As String
    Dim estado As String

    Public Property PrCId
        Get
            Return cliente_id
        End Get
        Set(ByVal identidad)
            cliente_id = identidad
        End Set
    End Property

    Public Property PrDocumento
        Get
            Return documento
        End Get
        Set(ByVal docid)
            documento = docid
        End Set
    End Property

    Public Property PrNombre
        Get
            Return nombre
        End Get
        Set(ByVal nmbr)
            nombre = nmbr
        End Set
    End Property

    Public Property PrApellido
        Get
            Return apellido
        End Get
        Set(ByVal aplld)
            apellido = aplld
        End Set
    End Property

    Public Property PrFNacimiento
        Get
            Return fecha_nacimiento
        End Get
        Set(ByVal fchdn)
            fecha_nacimiento = fchdn
        End Set
    End Property

    Public Property PrDireccion
        Get
            Return direccion
        End Get
        Set(ByVal drccn)
            direccion = drccn
        End Set
    End Property

    Public Property PrTelefono
        Get
            Return telefono
        End Get
        Set(ByVal tlfn)
            telefono = tlfn
        End Set
    End Property

    Public Property PrCelular
        Get
            Return celular
        End Get
        Set(ByVal cllr)
            celular = cllr
        End Set
    End Property

    Public Property PrGenero
        Get
            Return genero
        End Get
        Set(ByVal gnr)
            genero = gnr
        End Set
    End Property

    Public Property PrEstado
        Get
            Return estado
        End Get
        Set(ByVal stdo)
            estado = stdo
        End Set
    End Property
End Class
