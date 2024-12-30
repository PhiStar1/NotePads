Public Class TextNotFound
    Private Sub CloseWindow(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        Debug.WriteLine("Anfang der Funktion: CloseWindow(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp")
        If e.KeyCode = Keys.Escape Then
            Debug.WriteLine("e.KeyCode = Keys.Escape")
            Debug.WriteLine("Schließen von TextNotFound")
            Me.Close()
            Debug.WriteLine("Schließen von TextNotFound abgeschlossen")


        End If

    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub TextNotFound_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Debug.WriteLine("Anfang der Funktion: Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click")
        Debug.WriteLine("Schließen von TextNotFound")

        Me.Close()
        Debug.WriteLine("Schließen von TextNotFound abgeschlossen")

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Debug.WriteLine("Anfang der Funktion: ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click")
        Debug.WriteLine("Schließen von TextNotFound")

        Me.Close()
        Debug.WriteLine("Schließen von TextNotFound abgeschlossen")

    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs)

    End Sub
End Class