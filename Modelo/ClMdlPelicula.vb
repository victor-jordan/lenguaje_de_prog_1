Public Class ClMdlPelicula
    Dim pelicula_id As Integer
    Dim titulo As String
    Dim genero As String
    Dim año As String
    Dim director As String
    Dim formato As String
    Dim precio_alquiler As Integer

    Public Property PrPId
        Get
            Return pelicula_id
        End Get
        Set(ByVal identidad)
            pelicula_id = identidad
        End Set
    End Property


    Public Property PrTitulo
        Get
            Return titulo
        End Get
        Set(ByVal titl)
            titulo = titl
        End Set
    End Property

    Public Property PrGenero
        Get
            Return genero
        End Get
        Set(ByVal genr)
            genero = genr
        End Set
    End Property

    Public Property PrAño
        Get
            Return año
        End Get
        Set(ByVal anio)
            año = anio
        End Set
    End Property

    Public Property PrDirector
        Get
            Return director
        End Get
        Set(ByVal drctr)
            director = drctr
        End Set
    End Property

    Public Property PrFormato
        Get
            Return formato
        End Get
        Set(ByVal forma)
            formato = forma
        End Set
    End Property

    Public Property PrPrecioAlquiler
        Get
            Return precio_alquiler
        End Get
        Set(ByVal pralq)
            precio_alquiler = pralq
        End Set
    End Property
End Class
