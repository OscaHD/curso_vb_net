<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_excel
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtFichero = New System.Windows.Forms.TextBox()
        Me.txtHoja = New System.Windows.Forms.TextBox()
        Me.txtColumna = New System.Windows.Forms.TextBox()
        Me.txtFila = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblColumna = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtFichero
        '
        Me.txtFichero.Location = New System.Drawing.Point(152, 47)
        Me.txtFichero.Name = "txtFichero"
        Me.txtFichero.Size = New System.Drawing.Size(188, 20)
        Me.txtFichero.TabIndex = 0
        '
        'txtHoja
        '
        Me.txtHoja.Location = New System.Drawing.Point(152, 88)
        Me.txtHoja.Name = "txtHoja"
        Me.txtHoja.Size = New System.Drawing.Size(188, 20)
        Me.txtHoja.TabIndex = 1
        '
        'txtColumna
        '
        Me.txtColumna.Location = New System.Drawing.Point(152, 126)
        Me.txtColumna.Name = "txtColumna"
        Me.txtColumna.Size = New System.Drawing.Size(188, 20)
        Me.txtColumna.TabIndex = 2
        '
        'txtFila
        '
        Me.txtFila.Location = New System.Drawing.Point(152, 172)
        Me.txtFila.Name = "txtFila"
        Me.txtFila.Size = New System.Drawing.Size(188, 20)
        Me.txtFila.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Fichero"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Hoja"
        '
        'lblColumna
        '
        Me.lblColumna.AutoSize = True
        Me.lblColumna.Location = New System.Drawing.Point(76, 126)
        Me.lblColumna.Name = "lblColumna"
        Me.lblColumna.Size = New System.Drawing.Size(48, 13)
        Me.lblColumna.TabIndex = 6
        Me.lblColumna.Text = "Columna"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(76, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Fila"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(265, 211)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Leer Fichero"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtResultado
        '
        Me.txtResultado.Location = New System.Drawing.Point(76, 211)
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(111, 20)
        Me.txtResultado.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Resultado"
        '
        'Form_excel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 265)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtResultado)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblColumna)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFila)
        Me.Controls.Add(Me.txtColumna)
        Me.Controls.Add(Me.txtHoja)
        Me.Controls.Add(Me.txtFichero)
        Me.Name = "Form_excel"
        Me.Text = "Form_excel"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFichero As System.Windows.Forms.TextBox
    Friend WithEvents txtHoja As System.Windows.Forms.TextBox
    Friend WithEvents txtColumna As System.Windows.Forms.TextBox
    Friend WithEvents txtFila As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblColumna As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtResultado As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
