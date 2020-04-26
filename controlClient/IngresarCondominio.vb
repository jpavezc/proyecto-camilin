Public Class IngresarCondominio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            addCondominio("INSERT INTO CONDOMINIO (`cdm_nom`, `cdm_dir`) VALUES ('" & txtUbicacion.Text & "','" _
                   & txtCasas.Text & "')")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class