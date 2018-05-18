Imports System.Data.SqlClient

Public Class ClCtrlConexion

    Public Shared conexion As New SqlConnection

    Public Shared Function Conectar()
        Try
            'conexion = New SqlConnection("Server=(local);Database=video_club;Trusted_Connection=True")
            'conexion = New SqlConnection("Data Source=SET-NOC-NB04\SQLEXPRESS;Initial Catalog=video_club;User ID=vdcuser; Password=123456;")
            conexion = New SqlConnection("Data Source=(local);Database=video_club;User ID=usuario_vc; Password=123456;")
            conexion.Open()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Function Desconectar()
        Try
            If conexion.State = ConnectionState.Open Then
                conexion.Close()
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function
End Class
