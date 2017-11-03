''----------------------------------------------------''
'' This container deals with Message Box Dialogs
''----------------------------------------------------''

Public Class Form1
    Private Sub BtnShowMessage_Click(sender As Object, e As EventArgs) Handles btnShowMessage.Click
        If MessageBox.Show("Hiya", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) = DialogResult.Yes Then
            MessageBox.Show("You clicked Yes")
        Else
            MessageBox.Show("You clicked No")
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        If MessageBox.Show("Are you sure you would like to exit the program?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Application.Exit() 'Exiting the program
        Else
            MessageBox.Show("The program will not exit")
        End If
    End Sub

    ''----------------------------------------------------''
    '' This container deals with Open and Save Dialogs
    ''----------------------------------------------------''

    Private Sub BtnFileToOpen_Click(sender As Object, e As EventArgs) Handles btnFileToOpen.Click, OpenToolStripMenuItem.Click
        ofdData.FileName = txtFileToOpen.Text
        If ofdData.ShowDialog() = DialogResult.OK Then
            txtFileToOpen.Text = ofdData.FileName
        End If
    End Sub

    Private Sub BtnSaveFile_Click(sender As Object, e As EventArgs) Handles btnSaveFile.Click, SaveToolStripMenuItem.Click
        sfdData.FileName = txtSaveFile.Text
        If sfdData.ShowDialog() = DialogResult.OK Then
            txtSaveFile.Text = sfdData.FileName
        End If
    End Sub
End Class
