Imports System.IO
Imports Microsoft.Win32

Public Class About
    ' Variablen für die Position der Maus
    Private mouseDown As Boolean = False
    Private mouseOffset As Point

    Private Sub exitversion_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        Debug.WriteLine("Anfang der Funktion: exitversion_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp")

        If e.KeyCode = Keys.Escape Then
            Debug.WriteLine("e.KeyCode = Keys.Escape")
            Debug.WriteLine("Schließen von About")
            Me.Close()
            Debug.WriteLine("Schließen von About abgeschlossen")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Debug.WriteLine("Anfang der Funktion: ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click")
        Debug.WriteLine("Schließen von About")

        Me.Close()
        Debug.WriteLine("Schließen von About abgeschlossen")
    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    ' MouseDown-Ereignis hinzufügen
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
End Class
