Public Class Form_excel


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtResultado.Text = LectorExcel.DameValorCelda(txtFichero.Text, txtHoja.Text, txtColumna.Text, Integer.Parse(txtFila.Text))
    End Sub
End Class