Public Class FrmInicial

    Private Sub btnEquipo_Click(sender As Object, e As EventArgs) Handles btnEquipo.Click
        'Permite llamar a otro formulario
        Dim frmEquipos As New FrmEquipos
        frmEquipos.Show() 'Muestra el formulario llamado
    End Sub
End Class