Imports System.Threading

Public Class Form1
    Private trd As Thread

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        trd = New Thread(AddressOf ThreadTask)
        trd.IsBackground = True
        trd.Start()
    End Sub
    Private Sub ThreadTask()
        Dim stp As Integer
        Dim newval As Integer
        Dim rnd As New Random()

        Do
            stp = ProgressBar1.Step * rnd.Next(-1, 2)
            newval = ProgressBar1.Value + stp
            If newval > ProgressBar1.Maximum Then
                newval = ProgressBar1.Maximum
            ElseIf newval < ProgressBar1.Minimum Then
                newval = ProgressBar1.Minimum
            End If

            ProgressBar1.Value = newval

            Thread.Sleep(100)
        Loop
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("This is the main thread")
    End Sub
End Class
