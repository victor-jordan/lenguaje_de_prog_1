Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class ClCtrlClientes
    Inherits ClCtrlConexion

    Public Shared los_clientes As New Collection(Of ClMdlCliente)
    Public Shared el_cliente As New ClMdlCliente
    Dim comando As New SqlCommand()
    Dim lector As SqlDataReader

    Public Function ObtenerTodos()
        Try
            Conectar()

            comando = New SqlCommand("select * from cliente;")
            comando.CommandType = CommandType.Text
            comando.Connection = conexion

            lector = comando.ExecuteReader()

            If lector.HasRows = True Then
                While lector.Read()
                    el_cliente.PrCId = lector.GetInt32(0)
                    el_cliente.PrDocumento = lector.GetString(1).Trim()
                    el_cliente.PrNombre = lector.GetString(2).Trim()
                    el_cliente.PrApellido = lector.GetString(3).Trim()
                    el_cliente.PrFNacimiento = lector.GetDateTime(4)
                    el_cliente.PrDireccion = lector.GetString(5).Trim()
                    el_cliente.PrTelefono = lector.GetString(6).Trim()
                    el_cliente.PrCelular = lector.GetString(7).Trim()
                    el_cliente.PrGenero = lector.GetString(8).Trim()
                    el_cliente.PrEstado = lector.GetString(9).Trim()
                    los_clientes.Add(el_cliente)
                    el_cliente = New ClMdlCliente
                End While
            End If
            Return los_clientes
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            Desconectar()
        End Try
    End Function
End Class
