Imports MySql.Data.MySqlClient

Public Class cargo

    Dim comandos As New MySqlCommand
    Dim conexion As New MySqlConnection

    Private Sub cargoload(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            conexion.ConnectionString = "server=localhost;user=root;password=;database=controlclient"
            conexion.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


    Private Sub agregarCargo_Click(sender As Object, e As EventArgs) Handles agregarCargo.Click

        Try
            comandos = New MySqlCommand("INSERT INTO cargo(cgo_nom)" & "VALUES(@cargo)", conexion)
            comandos.Parameters.AddWithValue("@cargo", nbCargoInput.Text)
            comandos.ExecuteNonQuery()
            MsgBox("Datos Guardados")
        Catch ex As Exception
            MsgBox("La conexión no fue exitosa")
        End Try
    End Sub

End Class