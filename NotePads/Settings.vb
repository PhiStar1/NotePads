Public Class Settings
    Private mouseDown As Boolean = False
    Private mouseOffset As Point
    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Debug.WriteLine("Anfang der Funktion: ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click")
        Debug.WriteLine("Schließen von Settings")
        Me.Close()
        Debug.WriteLine("Schließen von Settings abgeschlossen")
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Debug.WriteLine("Anfang der Funktion: RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged")
        Debug.WriteLine("Setze My.Settings.AutoSave = 'TextChanged'")
        My.Settings.AutoSave = "TextChanged"
        Debug.WriteLine("Setze My.Settings.AutoSave = 'TextChanged' abgeschlossen")

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        Debug.WriteLine("Anfang der Funktion: RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged")
        Debug.WriteLine("Setze My.Settings.AutoSave = 'after10seconds'")
        My.Settings.AutoSave = "after10seconds"
        Debug.WriteLine("Setze My.Settings.AutoSave = 'after10seconds' abgeschlossen")
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        Debug.WriteLine("Anfang der Funktion: RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged")
        Debug.WriteLine("Setze My.Settings.AutoSave = 'after30seconds'")
        My.Settings.AutoSave = "after30seconds"
        Debug.WriteLine("Setze My.Settings.AutoSave = 'after30seconds' abgeschlossen")

    End Sub

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine("Anfang der Funktion: Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load")
        If My.Settings.AutoSave = "TextChanged" Then
            Debug.WriteLine("My.Settings.AutoSave = 'TextChanged'")
            Debug.WriteLine("setze RadioButton1.Checked = True")
            RadioButton1.Checked = True
            Debug.WriteLine("setze RadioButton1.Checked = True abgeschlossen")
        End If
        If My.Settings.AutoSave = "after10seconds" Then
            Debug.WriteLine("My.Settings.AutoSave = 'after10seconds'")
            Debug.WriteLine("setze RadioButton2.Checked = True")
            RadioButton2.Checked = True
            Debug.WriteLine("setze RadioButton2.Checked = True abgeschlossen")
        End If
        If My.Settings.AutoSave = "after30seconds" Then
            Debug.WriteLine("My.Settings.AutoSave = 'after30seconds'")
            Debug.WriteLine("setze RadioButton3.Checked = True")
            RadioButton3.Checked = True
            Debug.WriteLine("setze RadioButton3.Checked = True abgeschlossen")
        End If
    End Sub
    Private Sub ToolStrip1_MouseDown(sender As Object, e As MouseEventArgs) Handles ToolStrip1.MouseDown
        If e.Button = MouseButtons.Left Then
            mouseDown = True
            mouseOffset = New Point(e.X, e.Y)
        End If
    End Sub

    ' MouseMove-Ereignis hinzufügen
    Private Sub ToolStrip1_MouseMove(sender As Object, e As MouseEventArgs) Handles ToolStrip1.MouseMove
        If mouseDown Then
            ' Position des Fensters aktualisieren
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(-mouseOffset.X, -mouseOffset.Y)
            Me.Location = mousePos
        End If
    End Sub

    ' MouseUp-Ereignis hinzufügen
    Private Sub ToolStrip1_MouseUp(sender As Object, e As MouseEventArgs) Handles ToolStrip1.MouseUp
        mouseDown = False
    End Sub
    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub ToolStripLabel2_Click(sender As Object, e As EventArgs) Handles ChangeSize.Click
        If Not Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Normal
            ChangeSize.Text = "O"
        Else
            Me.WindowState = FormWindowState.Maximized
            ChangeSize.Text = "><"
        End If
    End Sub
End Class