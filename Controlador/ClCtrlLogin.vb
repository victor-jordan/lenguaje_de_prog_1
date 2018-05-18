Imports System.Data.SqlClient

Public Class ClCtrlLogin
    Inherits ClCtrlConexion 'herencia

    Dim comando As New SqlCommand
    Dim lector As SqlDataReader

    Public Function Validar(ByVal user As ClMdlUsuario) As String
        Try
            Conectar()

            comando = New SqlCommand("login_usuario")
            comando.CommandType = CommandType.StoredProcedure
            comando.Connection = conexion
            comando.Parameters.AddWithValue("@usuario", user.PrDenominacion)
            comando.Parameters.AddWithValue("@password", user.PrClave)

            lector = comando.ExecuteReader

            If lector.HasRows = True Then
                Do While lector.Read
                    user.PrNombre = Trim(lector.GetString(2))
                    user.PrApellido = Trim(lector.GetString(3))
                    user.PrActivo = lector.GetBoolean(4)
                Loop
                If user.PrActivo = True Then
                    Return "Activo"
                ElseIf user.PrActivo = False Then
                    Return "Inactivo"
                Else
                    Return "Desconocido"
                End If
            Else
                Return "Inexistente"
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            Return "Error"
        Finally
            Desconectar()
        End Try
    End Function
End Class
