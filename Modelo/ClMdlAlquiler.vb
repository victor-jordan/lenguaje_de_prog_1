Public Class ClMdlAlquiler
    Dim alquiler_id As Integer
    Dim pelicula_id As Integer
    Dim cliente_id As Integer
    Dim fecha_alquiler As Date
    Dim fecha_devolucion As Date
    Dim situacion As String
    Dim creado_por As Integer
    Dim modificado_por As Integer

    Public Property PrAId
        Get
            Return alquiler_id
        End Get
        Set(ByVal identidad)
            alquiler_id = identidad
        End Set
    End Property

    Public Property PrPId
        Get
            Return pelicula_id
        End Get
        Set(ByVal plid)
            pelicula_id = plid
        End Set
    End Property

    Public Property PrCId
        Get
            Return cliente_id
        End Get
        Set(ByVal clid)
            cliente_id = clid
        End Set
    End Property

    Public Property PrFAlquiler
        Get
            Return fecha_alquiler
        End Get
        Set(ByVal falq)
            fecha_alquiler = falq
        End Set
    End Property

    Public Property PrFDevolucion
        Get
            Return fecha_devolucion
        End Get
        Set(ByVal fdvl)
            fecha_devolucion = fdvl
        End Set
    End Property

    Public Property PrSituacion
        Get
            Return situacion
        End Get
        Set(ByVal stcn)
            situacion = stcn
        End Set
    End Property

    Public Property PrCreadoPor
        Get
            Return creado_por
        End Get
        Set(ByVal crdpr)
            creado_por = crdpr
        End Set
    End Property

    Public Property PrModificadoPor
        Get
            Return modificado_por
        End Get
        Set(ByVal mdfcdpr)
            modificado_por = mdfcdpr
        End Set
    End Property
End Class
