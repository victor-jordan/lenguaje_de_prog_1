Module ModUtiles
    Public Function ValidarDatosVacios(Grpbox As GroupBox) As Integer
        Dim campos_vacios As Integer = 0
        Try
            For Each elemento As Control In Grpbox.Controls
                If TypeOf elemento Is TextBox And elemento.Text.Length = 0 Then
                    elemento.BackColor = Color.Red
                    campos_vacios += 1
                ElseIf TypeOf elemento Is ComboBox And elemento.Text.Length = 0 Then
                    elemento.BackColor = Color.Red
                    campos_vacios += 1
                Else
                    If elemento.BackColor = Color.Red Then
                        elemento.BackColor = Color.White
                    End If
                End If
            Next
            Return campos_vacios
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return 1
        End Try
    End Function

    Public Sub ResetearControl(ctrl_reset As Control)
        If TypeOf ctrl_reset Is TextBox Then
            Dim nv_ctrl As TextBox = ctrl_reset
            nv_ctrl.Clear()
            If nv_ctrl.BackColor.Equals(Color.Red) Then
                nv_ctrl.BackColor = Color.White
            End If
        ElseIf TypeOf ctrl_reset Is ComboBox Then
            Dim nv_ctrl As ComboBox = ctrl_reset
            nv_ctrl.ResetText()
            If nv_ctrl.BackColor.Equals(Color.Red) Then
                nv_ctrl.BackColor = Color.White
            End If
        End If
    End Sub
End Module
