Public Class Form1
    Private Sub BtnShowMessage_Click(sender As Object, e As EventArgs) Handles btnShowMessage.Click
        MessageBox.Show("Hiya", "Caption", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
    End Sub
End Class
