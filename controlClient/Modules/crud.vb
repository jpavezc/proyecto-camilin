Imports MySql.Data.MySqlClient
Module crud


    Public Function strstrconnection() As MySqlConnection
        Return New MySqlConnection("server=127.0.0.1; user id= root ; password=root")
    End Function

    Public strcon As MySqlConnection = strstrconnection()

    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable


    Public Sub addCondominio(ByVal sql As String)
    Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MsgBox("Se produjo un error al guardar el condomino", MsgBoxStyle.Information)
                Else
                    MsgBox("El condominio fue guardado")
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        strcon.Close()
    End Sub




End Module
