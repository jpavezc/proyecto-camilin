Imports MySql.Data.MySqlClient
Module crud
    Public Class conexion
        Private MysqlCommand As New MySqlCommand
        Dim MysqlConnString As String = "server=127.0.0.1; user id= root ; password=root"
        Public MysqlConexion As MySqlConnection = New MySqlConnection(MysqlConnString)

        Public Sub ConectionMysql()
            Try
                MysqlConexion.Open()
                MsgBox("la conexión fue exitosa")
                MysqlConexion.Close()
            Catch ex As Exception
                MsgBox("La conexión no fue exitosa")
            End Try
        End Sub
    End Class



End Module
