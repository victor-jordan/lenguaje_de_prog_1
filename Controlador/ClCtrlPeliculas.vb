Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class ClCtrlPeliculas
    Inherits ClCtrlConexion

    Public Shared las_peliculas As New Collection(Of ClMdlPelicula)
    Public Shared la_pelicula As New ClMdlPelicula
    Dim comando As New SqlCommand()
    Dim lector As SqlDataReader

    Public Function ObtenerTodos()
        Try
            Conectar()

            comando = New SqlCommand("select * from pelicula;")
            comando.CommandType = CommandType.Text
            comando.Connection = conexion

            lector = comando.ExecuteReader()

            If lector.HasRows = True Then
                While lector.Read()
                    la_pelicula.PrPId = lector.GetInt32(0)
                    la_pelicula.PrTitulo = lector.GetString(1).Trim()
                    la_pelicula.PrGenero = lector.GetString(2).Trim()
                    la_pelicula.PrAño = lector.GetString(3).Trim()
                    la_pelicula.PrDirector = lector.GetString(4)
                    la_pelicula.PrFormato = lector.GetString(5).Trim()
                    la_pelicula.PrPrecioAlquiler = lector.GetInt32(6)
                    las_peliculas.Add(la_pelicula)
                    la_pelicula = New ClMdlPelicula
                End While
            End If
            Return las_peliculas
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Desconectar()
        End Try
    End Function

    Public Function Autocompletar(campo As String) As Collection(Of String)
        Dim OrigenAC As New Collection(Of String)
        Try
            Dim sentencia As String = String.Format("select distinct {0} from pelicula;", campo)
            Conectar()

            comando = New SqlCommand(sentencia)
            comando.CommandType = CommandType.Text
            comando.Connection = conexion

            lector = comando.ExecuteReader()
            If lector.HasRows = True Then
                While lector.Read()
                    OrigenAC.Add(lector.GetString(0))
                End While
            End If
            Return OrigenAC
        Catch ex As Exception
            Return OrigenAC
        Finally
            Desconectar()
        End Try
    End Function
End Class
