Public Class FrmCliente
    Dim clientes As New ClCtrlClientes
    Dim clsource As New BindingSource

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        clsource.DataSource = clientes.ObtenerTodos()
    End Sub

    ' Public Sub New(OUsuario As ClMdlUsuario)
    Public Sub New(OUsuario As ClMdlUsuario)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Text = OUsuario.PrDenominacion & " - " & Format(Now, "dd/MM/yyyy H:mm")

        clsource.DataSource = clientes.ObtenerTodos()
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DgvClientes.DataSource = clsource
        With DgvClientes
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Id"
            .Columns(1).HeaderCell.Value = "Documento"
            .Columns(2).HeaderCell.Value = "Nombre"
            .Columns(3).HeaderCell.Value = "Apellido"
            .Columns(4).HeaderCell.Value = "Fecha_Nac"
            .Columns(5).HeaderCell.Value = "Direccion"
            .Columns(6).HeaderCell.Value = "Telefono"
            .Columns(7).HeaderCell.Value = "Celular"
            .Columns(8).HeaderCell.Value = "Genero"
            .Columns(9).HeaderCell.Value = "Estado"
        End With
    End Sub

End Class