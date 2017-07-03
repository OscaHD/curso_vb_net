Public Class Form_baja

    Private Sub AlActivarseFormulario(sender As Object, e As EventArgs) Handles Me.Activated
        Me.MdiParent.Text = "Baja empleado"
    End Sub
    Private Sub AlDesActivarseFormulario(sender As Object, e As EventArgs) Handles Me.FormClosed
        Me.MdiParent.Text = "Principal"
    End Sub
End Class