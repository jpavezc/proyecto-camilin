Imports MySql.Data.MySqlClient


Public Class addingCasa

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

    Private Sub cntAddCasa_Paint(sender As Object, e As PaintEventArgs) Handles cntAddCasa.Paint

    End Sub

    Private Sub agregarCasabtn_Click(sender As Object, e As EventArgs) Handles agregarCasabtn.Click
        Try

        Catch ex As Exception

        End Try
    End Sub
End Class