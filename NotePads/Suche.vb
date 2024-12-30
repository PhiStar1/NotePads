Imports System.IO
Imports Microsoft.Win32
Public Class Suche
    Private mouseDown As Boolean = False
    Private mouseOffset As Point
    Private Sub SearchWhenPressingEnter_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        Debug.WriteLine("Anfang der Funktion: SearchWhenPressingEnter_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp")
        If e.KeyCode = Keys.Enter Then
            Debug.WriteLine("e.KeyCode = Keys.Enter")
            Debug.WriteLine("setze Me.Text = 'Wird gesucht...'")
            Me.Text = "Wird gesucht..."
            Debug.WriteLine("setze Me.Text = 'Wird gesucht...' abgeschlossen")
            Debug.WriteLine("setze Searchtext als String = TextBox1.Text")
            Dim Searchtext As String = TextBox1.Text
            Debug.WriteLine("setze Searchtext als String = TextBox1.Text abgeschlossen")
            Debug.WriteLine("setze form1Text als String = Form1.Textfeld.Text")
            Dim form1Text As String = Form1.Textfeld.Text
            Debug.WriteLine("setze form1Text als String = Form1.Textfeld.Text abgeschlossen")
            Debug.WriteLine("setze index als Integer = form1Text.IndexOf(Searchtext)")
            Dim index As Integer = form1Text.IndexOf(Searchtext)
            Debug.WriteLine("setze index als Integer = form1Text.IndexOf(Searchtext) abgeschlossen")
            If index >= 0 Then
                Debug.WriteLine("index >= 0")
                Debug.WriteLine("Ausführen der Funktion Form1.Textfeld.DeselectAll()")
                Form1.Textfeld.DeselectAll()
                Debug.WriteLine("Ausführen der Funktion Form1.Textfeld.DeselectAll() abgeschlossen")
                Debug.WriteLine("Ausführen der Funktion Form1.Textfeld.Select() mit Parametern index, Searchtext.Length")
                Form1.Textfeld.Select(index, Searchtext.Length)
                Debug.WriteLine("Ausführen der Funktion Form1.Textfeld.Select() mit Parametern index, Searchtext.Length abgeschlossen")
                Debug.WriteLine("Ausführen der Funktion Form1.Textfeld.Focus()")
                Form1.Textfeld.Focus()
                Debug.WriteLine("Ausführen der Funktion Form1.Textfeld.Focus() abgeschlossen")

            Else
                Debug.WriteLine("Not index >= 0")
                Debug.WriteLine("Zeigen von TextNotFound als Dialog")
                TextNotFound.ShowDialog()
                Debug.WriteLine("Zeigen von TextNotFound als Dialog abgeschlossen")

            End If
            Debug.WriteLine("setze Me.Text = 'Suche'")

            Me.Text = "Suche"
            Debug.WriteLine("setze Me.Text = 'Suche' abgeschlossen")

        End If
        If e.KeyCode = Keys.Escape Then
            Debug.WriteLine("e.KeyCode = Keys.Escape")
            Debug.WriteLine("Schließen von Suche")
            Me.Close()
            Debug.WriteLine("Schließen von Suche abgeschlossen")

        End If
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles CancelSuche.Click
        Debug.WriteLine("Anfang der Funktion: Label1_Click(sender As Object, e As EventArgs) Handles CancelSuche.Click")
        Debug.WriteLine("Schließen von Suche")
        Me.Close()
        Debug.WriteLine("Schließen von Suche abgeschlossen")

    End Sub
    Private Sub Label1_MouseHover(sender As Object, e As EventArgs) Handles CancelSuche.MouseHover
        Debug.WriteLine("Anfang der Funktion: Label1_Click(sender As Object, e As EventArgs) Handles CancelSuche.Click")
        Debug.WriteLine("Setze Schriftgroesse als Single = 10")
        Dim Schriftgroesse As Single = 10
        Debug.WriteLine("Setze Schriftgroesse als Single = 10 abgeschlossen")
        Debug.WriteLine("Setze CancelSuche.Font = New Font(CancelSuche.Font.FontFamily, Schriftgroesse, CancelSuche.Font.Style)")
        CancelSuche.Font = New Font(CancelSuche.Font.FontFamily, Schriftgroesse, CancelSuche.Font.Style)
        Debug.WriteLine("Setze CancelSuche.Font = New Font(CancelSuche.Font.FontFamily, Schriftgroesse, CancelSuche.Font.Style) abgeschlossen")

    End Sub
    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles CancelSuche.MouseLeave
        Debug.WriteLine("Anfang der Funktion: Label1_MouseLeave(sender As Object, e As EventArgs) Handles CancelSuche.MouseLeave")
        Debug.WriteLine("Setze Schriftgroesse als Single = 9")
        Dim Schriftgroesse As Single = 9
        Debug.WriteLine("Setze Schriftgroesse als Single = 9 abgeschlossen")
        Debug.WriteLine("Setze CancelSuche.Font = New Font(CancelSuche.Font.FontFamily, Schriftgroesse, CancelSuche.Font.Style)")

        CancelSuche.Font = New Font(CancelSuche.Font.FontFamily, Schriftgroesse, CancelSuche.Font.Style)
        Debug.WriteLine("Setze CancelSuche.Font = New Font(CancelSuche.Font.FontFamily, Schriftgroesse, CancelSuche.Font.Style) abgeschlossen")

    End Sub
    Private Sub Label1_MouseDown(sender As Object, e As EventArgs) Handles CancelSuche.MouseDown
        Debug.WriteLine("Anfang der Funktion: Label1_MouseDown(sender As Object, e As EventArgs) Handles CancelSuche.MouseDown")
        Debug.WriteLine("Setze Schriftgroesse als Single = 8")
        Dim Schriftgroesse As Single = 8
        Debug.WriteLine("Setze Schriftgroesse als Single = 8 abgeschlossen")
        Debug.WriteLine("Setze CancelSuche.Font = New Font(CancelSuche.Font.FontFamily, Schriftgroesse, CancelSuche.Font.Style)")
        CancelSuche.Font = New Font(CancelSuche.Font.FontFamily, Schriftgroesse, CancelSuche.Font.Style)
        Debug.WriteLine("Setze CancelSuche.Font = New Font(CancelSuche.Font.FontFamily, Schriftgroesse, CancelSuche.Font.Style) abgeschlossen")

    End Sub

    Private Sub Suche_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub SuchenButton_Click(sender As Object, e As EventArgs) Handles SuchenButton.Click
        Debug.WriteLine("Anfang der Funktion: SuchenButton_Click(sender As Object, e As EventArgs) Handles SuchenButton.Click")
        Debug.WriteLine("Setze Me.Text = 'Wird gesucht...'")
        Me.Text = "Wird gesucht..."
        Debug.WriteLine("Setze Me.Text = 'Wird gesucht...' abgeschlossen")
        Debug.WriteLine("Setze Searchtext als String = TextBox1.Text")
        Dim Searchtext As String = TextBox1.Text
        Debug.WriteLine("Setze Searchtext als String = TextBox1.Text abgeschlossen")
        Debug.WriteLine("Setze form1Text als String = Form1.Textfeld.Text")
        Dim form1Text As String = Form1.Textfeld.Text
        Debug.WriteLine("Setze form1Text als String = Form1.Textfeld.Text abgeschlossen")

        Debug.WriteLine("Setze index als Integer = form1Text.IndexOf(Searchtext)")

        Dim index As Integer = form1Text.IndexOf(Searchtext)
        Debug.WriteLine("Setze index als Integer = form1Text.IndexOf(Searchtext) abgeschlossen")
        If index >= 0 Then
            Debug.WriteLine("index >= 0")
            Debug.WriteLine("Ausführen der Funktion Form1.Textfeld.DeselectAll()")
            Form1.Textfeld.DeselectAll()
            Debug.WriteLine("Ausführen der Funktion Form1.Textfeld.DeselectAll() abgeschlossen")
            Debug.WriteLine("Ausführen der Funktion Form1.Textfeld.Select() mit den Parametern index, Searchtext.Length")
            Form1.Textfeld.Select(index, Searchtext.Length)
            Debug.WriteLine("Ausführen der Funktion Form1.Textfeld.Select() mit den Parametern index, Searchtext.Length abgeschlossen")
            Debug.WriteLine("Ausführen der Funktion Form1.Textfeld.Focus()")

            Form1.Textfeld.Focus()
            Debug.WriteLine("Ausführen der Funktion Form1.Textfeld.Focus() abgeschlossen")
        Else
            Debug.WriteLine("Not index >= 0")
            Debug.WriteLine("Zeigen von TextNotFound als Dialog")

            TextNotFound.ShowDialog()
            Debug.WriteLine("Zeigen von TextNotFound als Dialog abgeschlossen")

        End If
        Debug.WriteLine("Setze Me.Text = 'Suche'")

        Me.Text = "Suche"
        Debug.WriteLine("Setze Me.Text = 'Suche' abgeschlossen")

    End Sub

    Private Sub SuchenButton_MouseHover(sender As Object, e As EventArgs) Handles SuchenButton.MouseHover
        Debug.WriteLine("Anfang der Funktion: SuchenButton_MouseHover(sender As Object, e As EventArgs) Handles SuchenButton.MouseHover")
        Debug.WriteLine("Setze Schriftgroesse als Single = 10")
        Dim Schriftgroesse As Single = 10
        Debug.WriteLine("Setze Schriftgroesse als Single = 10 abgeschlossen")
        Debug.WriteLine("SuchenButton.Font = New Font(SuchenButton.Font.FontFamily, Schriftgroesse, SuchenButton.Font.Style)")
        SuchenButton.Font = New Font(SuchenButton.Font.FontFamily, Schriftgroesse, SuchenButton.Font.Style)
        Debug.WriteLine("SuchenButton.Font = New Font(SuchenButton.Font.FontFamily, Schriftgroesse, SuchenButton.Font.Style) abgeschlossen")

    End Sub
    Private Sub SuchenButton_MouseLeave(sender As Object, e As EventArgs) Handles SuchenButton.MouseLeave
        Debug.WriteLine("Anfang der Funktion: SuchenButton_MouseLeave(sender As Object, e As EventArgs) Handles SuchenButton.MouseLeave")
        Debug.WriteLine("Setze Schriftgroesse als Single = 9")

        Dim Schriftgroesse As Single = 9
        Debug.WriteLine("Setze Schriftgroesse als Single = 9 abgeschlossen")
        Debug.WriteLine("SuchenButton.Font = New Font(SuchenButton.Font.FontFamily, Schriftgroesse, SuchenButton.Font.Style)")
        SuchenButton.Font = New Font(SuchenButton.Font.FontFamily, Schriftgroesse, SuchenButton.Font.Style)
        Debug.WriteLine("SuchenButton.Font = New Font(SuchenButton.Font.FontFamily, Schriftgroesse, SuchenButton.Font.Style) abgeschlossen")

    End Sub
    Private Sub SuchenButton_MouseDown(sender As Object, e As EventArgs) Handles SuchenButton.MouseDown
        Debug.WriteLine("Anfang der Funktion: SuchenButton_MouseDown(sender As Object, e As EventArgs) Handles SuchenButton.MouseDown")
        Debug.WriteLine("Setze Schriftgroesse als Single = 8")

        Dim Schriftgroesse As Single = 8
        Debug.WriteLine("Setze Schriftgroesse als Single = 8 abgeschlossen")
        Debug.WriteLine("SuchenButton.Font = New Font(SuchenButton.Font.FontFamily, Schriftgroesse, SuchenButton.Font.Style)")

        SuchenButton.Font = New Font(SuchenButton.Font.FontFamily, Schriftgroesse, SuchenButton.Font.Style)
        Debug.WriteLine("SuchenButton.Font = New Font(SuchenButton.Font.FontFamily, Schriftgroesse, SuchenButton.Font.Style) abgeschlossen")

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click
        Debug.WriteLine("Anfang der Funktion: ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click")
        Debug.WriteLine("Schließen von Suche")
        Me.Close()
        Debug.WriteLine("Schließen von Suche abgeschlossen")
    End Sub

    Private Sub ChangeSize_Click(sender As Object, e As EventArgs) Handles ChangeSize.Click
        If Not Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Normal
            ChangeSize.Text = "O"
        Else
            Me.WindowState = FormWindowState.Maximized
            ChangeSize.Text = "><"
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
End Class