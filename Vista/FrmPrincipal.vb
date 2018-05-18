Public Class FrmPrincipal
    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles BtnSalir.Click
        Application.Exit()
    End Sub

    Private Sub BtnClientes_Click(sender As Object, e As EventArgs) Handles BtnClientes.Click
        Dim OFCliente As New FrmCliente()
        OFCliente.Show()
    End Sub

    Private Sub BtnAlquileres_Click(sender As Object, e As EventArgs) Handles BtnAlquileres.Click
        Dim OFAlquiler As New FrmAlquiler()
        OFAlquiler.Show()
    End Sub

    Private Sub BtnPeliculas_Click(sender As Object, e As EventArgs) Handles BtnPeliculas.Click
        Dim OFPelicula As New FrmPelicula()
        OFPelicula.Show()
    End Sub
End Class