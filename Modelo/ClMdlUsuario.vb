Public Class ClMdlUsuario
    ' Se definen los atributos de la clase
    Dim usuario_id As Integer
    Dim denominacion As String
    Dim clave As String
    Dim nombre As String
    Dim apellido As String
    Dim activo As Boolean

    ' Se definen las propiedades con los geters y seters
    Public Property PrUId
        Get
            Return usuario_id
        End Get
        Set(ByVal identidad)
            usuario_id = identidad
        End Set
    End Property

    Public Property PrDenominacion
        Get
            Return denominacion
        End Get
        Set(ByVal denom)
            denominacion = denom
        End Set
    End Property

    Public Property PrClave
        Get
            Return clave
        End Get
        Set(ByVal pass)
            clave = pass
        End Set
    End Property

    Public Property PrNombre
        Get
            Return nombre
        End Get
        Set(ByVal nom)
            nombre = nom
        End Set
    End Property

    Public Property PrApellido
        Get
            Return apellido
        End Get
        Set(ByVal ape)
            apellido = ape
        End Set
    End Property

    Public Property PrActivo
        Get
            Return activo
        End Get
        Set(ByVal act)
            activo = act
        End Set
    End Property

    ' Constructor Vacío para inicializar objeto nuevo sin ningún dato.
    Public Sub New()
    End Sub

    ' Constructor para utilizar generalmente con LOGIN.
    Public Sub New(ByVal usuario As String, ByVal password As String)
        PrDenominacion = usuario
        PrClave = password
    End Sub
End Class
