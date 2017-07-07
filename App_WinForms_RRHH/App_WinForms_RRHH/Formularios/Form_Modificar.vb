Imports App_WinForms_RRHH.Modelo

Public Class Form_Modificar
    Public indice As Integer
    Public empleado As Empleado

    Public Sub cargarDatos() Handles Me.Load

        txtNombre.Text = empleado.nombre
        txtApellidos.Text = empleado.apellidos
        cmbGenero.SelectedIndex = empleado.genero
        domCategoria.SelectedIndex = empleado.categoria

    End Sub
    Public Sub AlActivarseFormulario(sender As Object, e As EventArgs) _
        Handles Me.Activated
        Me.MdiParent.Text = "Modificar empleado"

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim nuevoEmpleado As Empleado = New Empleado()

        ' Asignamos valores
        nuevoEmpleado.nombre = txtNombre.Text
        nuevoEmpleado.apellidos = txtApellidos.Text
        nuevoEmpleado.genero = CType(cmbGenero.SelectedIndex + 1, TipoGenero)
        nuevoEmpleado.categoria = CType(domCategoria.SelectedIndex + 1, TipoCategoria)
        nuevoEmpleado.retribucionFija = numRetribucion.Value
        EmpleadosCRUD.Actualizar(indice, nuevoEmpleado)
        Me.Close()
    End Sub
End Class