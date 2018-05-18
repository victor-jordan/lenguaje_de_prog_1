Public Class FrmLogin
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text = "Acceso - " & Format(Now, "dd/MM/yyyy H:mm")
        TxtUsuario.Focus()
    End Sub

    Private Sub BtnIngresar_Click(sender As Object, e As EventArgs) Handles BtnIngresar.Click
        Dim OUsuario As New ClMdlUsuario
        Dim OAcceso As New ClCtrlLogin
        Dim estado As String
        Dim mensaje As String

        Try
            OUsuario.PrDenominacion = Trim(TxtUsuario.Text)
            OUsuario.PrClave = Trim(TxtPassword.Text)
            estado = OAcceso.Validar(OUsuario)
            If estado = "Activo" Then
                '   mensaje = String.Format("Usuario: {0} {1}", OUsuario.PrNombre, OUsuario.PrApellido)
                '   MsgBox(mensaje, MsgBoxStyle.Information, "Acceso correcto!")
                '   Close()
                'Esconder el form login para hilo principal
                Hide()
                ' Crear un objeto del tipo form prin
                ' Dim OFPrincipal As New FrmCliente(OUsuario)
                Dim OFPrincipal As New FrmPrincipal()
                OFPrincipal.Show()
            ElseIf estado = "Inactivo" Then
                mensaje = String.Format("Usuario: {0} {1} inactivo!", OUsuario.PrNombre, OUsuario.PrApellido) & Environment.NewLine & "Favor contactar con el administrador."
                MsgBox(mensaje, MsgBoxStyle.Exclamation, "Usuario inactivo!")
            ElseIf estado = "Desconocido" Or estado = "Inexistente" Then
                mensaje = String.Format("Usuario no existe!") & Environment.NewLine & "Favor contactar con el administrador."
                MsgBox(mensaje, MsgBoxStyle.Critical, "Desconocido o Inexistente!")
            Else
                mensaje = String.Format("Combinación usuario/password incorrecta..." & Environment.NewLine & "o Usuario: {0} inexistente", OUsuario.PrDenominacion)
                MsgBox(mensaje, MsgBoxStyle.Critical, "Verificar!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Close()
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Close()
    End Sub
End Class
