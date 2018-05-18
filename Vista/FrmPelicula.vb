Public Class FrmPelicula
    Private Sub CargarDatos()
        ' Para manejar la carga de los datos, tanto del DataGridView como de los campos con autocompletado
        Dim peliculas As New ClCtrlPeliculas
        Dim plsource As New BindingSource
        Dim los_directores As New AutoCompleteStringCollection
        Dim los_generos As New AutoCompleteStringCollection

        ' Cargar el DataGridView con datos de las películas
        plsource.DataSource = peliculas.ObtenerTodos()
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
        los_directores.AddRange(peliculas.Autocompletar("director").ToArray())
        TxtDirector.AutoCompleteCustomSource = los_directores

        ' Autocompletar Generos
        TxtGenero.AutoCompleteSource = AutoCompleteSource.CustomSource
        TxtGenero.AutoCompleteMode = AutoCompleteMode.Suggest
        los_generos.AddRange(peliculas.Autocompletar("genero").ToArray())
        TxtGenero.AutoCompleteCustomSource = los_generos

    End Sub

    Private Sub FrmPelicula_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If ValidarDatosVacios(GrpbDatos) = 0 Then
            MsgBox("Oikota")
        Else
            MsgBox("Llenar campos vacios.")
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        For Each elemento As Control In GrpbDatos.Controls
            ResetearControl(elemento)
        Next
    End Sub
End Class