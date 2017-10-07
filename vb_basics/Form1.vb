Public Class Form1
    Private Sub btnMessage_Click(sender As Object, e As EventArgs) Handles btnMessage.Click
        'code for the message button
        'By J.levy 06/10/17
        Dim name As String
        name = txtName.Text
        MsgBox("Welcome to VB " & name)
    End Sub
End Class
