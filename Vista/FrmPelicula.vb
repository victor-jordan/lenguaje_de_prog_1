Public Class FrmPelicula
    Private Sub CargarDatos()
        ' Para manejar la carga de los datos, tanto del DataGridView como de los campos con autocompletado
        Dim CtrlPeliculas As New ClCtrlPeliculas
        Dim plsource As New BindingSource
        Dim los_directores As New AutoCompleteStringCollection
        Dim los_generos As New AutoCompleteStringCollection

        ' Cargar el DataGridView con datos de las películas
        DgvPeliculas.Rows.Clear()
        plsource.DataSource = CtrlPeliculas.ObtenerTodos()
        DgvPeliculas.DataSource = plsource
        With DgvPeliculas
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "Id"
            .Columns(1).HeaderCell.Value = "Titulo"
            .Columns(2).HeaderCell.Value = "Genero"
            .Columns(3).HeaderCell.Value = "Año"
            .Columns(4).HeaderCell.Value = "Director"
            .Columns(5).HeaderCell.Value = "Formato"
            .Columns(6).HeaderCell.Value = "Precio Alquiler"
        End With

        ' Autocompletar Directores
        TxtDirector.AutoCompleteSource = AutoCompleteSource.CustomSource
        TxtDirector.AutoCompleteMode = AutoCompleteMode.Suggest
        los_directores.AddRange(CtrlPeliculas.Autocompletar("director").ToArray())
        TxtDirector.AutoCompleteCustomSource = los_directores

        ' Autocompletar Generos
        TxtGenero.AutoCompleteSource = AutoCompleteSource.CustomSource
        TxtGenero.AutoCompleteMode = AutoCompleteMode.Suggest
        los_generos.AddRange(CtrlPeliculas.Autocompletar("genero").ToArray())
        TxtGenero.AutoCompleteCustomSource = los_generos

    End Sub

    Private Sub FrmPelicula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
        LblId.ResetText()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If ValidarDatosVacios(GrpbDatos) = 0 Then
            Dim OPelicula As New ClMdlPelicula
            Dim CtrlPeliculas As New ClCtrlPeliculas

            OPelicula.PrPId = If(String.IsNullOrEmpty(LblId.Text), Nothing, Convert.ToInt32(LblId.Text.Trim()))
            OPelicula.PrTitulo = TxtTitulo.Text.Trim()
            OPelicula.PrGenero = TxtGenero.Text.Trim()
            OPelicula.PrAño = TxtAnio.Text.Trim()
            OPelicula.PrDirector = TxtDirector.Text.Trim()
            OPelicula.PrFormato = CmbFormato.Text.Trim()
            OPelicula.PrPrecioAlquiler = Convert.ToInt32(TxtPrecio.Text.Trim())

            If CtrlPeliculas.InsertarModificar(OPelicula) = True Then
                MessageBox.Show("Realizado!", "Agregar o Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarDatos()
                BtnReset.PerformClick()
                TxtTitulo.Focus()
            End If
        Else
            MessageBox.Show("Ningún campo puede estar vacío!", "Agregando", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        For Each elemento As Control In GrpbDatos.Controls
            ResetearControl(elemento)
        Next
        LblId.ResetText()
        DgvPeliculas.ClearSelection()
        TxtTitulo.Focus()
        BtnAgregar.Text = "Agregar"
    End Sub

    Private Sub BtnBorrar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        Dim OPelicula As New ClMdlPelicula
        Dim CtrlPeliculas As New ClCtrlPeliculas

        OPelicula.PrPId = If(String.IsNullOrEmpty(LblId.Text), Nothing, Convert.ToInt32(LblId.Text.Trim()))
        OPelicula.PrTitulo = TxtTitulo.Text.Trim()
        OPelicula.PrGenero = TxtGenero.Text.Trim()
        OPelicula.PrAño = TxtAnio.Text.Trim()
        OPelicula.PrDirector = TxtDirector.Text.Trim()
        OPelicula.PrFormato = CmbFormato.Text.Trim()
        OPelicula.PrPrecioAlquiler = Convert.ToInt32(TxtPrecio.Text.Trim())

        Dim mensaje As String = String.Format("Eliminar: {0}, {1}", OPelicula.PrTitulo, OPelicula.PrAño) + Environment.NewLine + "Está seguro?"
        Dim borrar As DialogResult = MessageBox.Show(mensaje, "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If borrar = DialogResult.Yes Then
            If CtrlPeliculas.Eliminar(OPelicula.PrPId) = True Then
                MessageBox.Show("Realizado!", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information)
                BtnReset.PerformClick()
                CargarDatos()
                TxtTitulo.Focus()
            End If
        End If
    End Sub

    Private Sub DgvPeliculas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPeliculas.CellClick

        Dim seleccion As DataGridViewRow = DgvPeliculas.CurrentRow

        LblId.Text = seleccion.Cells(0).Value.ToString()
        TxtTitulo.Text = seleccion.Cells(1).Value.ToString()
        TxtGenero.Text = seleccion.Cells(2).Value.ToString()
        TxtAnio.Text = seleccion.Cells(3).Value.ToString()
        TxtDirector.Text = seleccion.Cells(4).Value.ToString()
        CmbFormato.Text = seleccion.Cells(5).Value.ToString()
        TxtPrecio.Text = seleccion.Cells(6).Value.ToString()
        BtnAgregar.Text = "Modificar"
        TxtTitulo.Focus()
    End Sub
End Class