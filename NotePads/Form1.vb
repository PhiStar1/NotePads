
Imports System.IO
Imports System.Linq.Expressions
Imports System.Security
Imports System.Web
Imports Microsoft.Win32


Public Class Form1
    Dim AutoSave As String
    Private Sub MeinDialogForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Debug.WriteLine("Anfang der Funktion: MeinDialogForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown")
        ' Überprüfen, ob die Tastenkombination Strg + N gedrückt wurde
        If e.Control AndAlso e.KeyCode = Keys.F Then
            Debug.WriteLine("e.Control AndAlso e.KeyCode = Keys.F")
            Debug.WriteLine("Zeigen von Suche")
            Suche.ShowDialog()
            Debug.WriteLine("Zeigen von Suche abgeschlossen")
        End If
        If e.Control AndAlso e.KeyCode = Keys.N Then
            Debug.WriteLine("e.Control AndAlso e.KeyCode = Keys.N")
            If isDocumentEdited Then
                Debug.WriteLine("isDocumentEdited = true")
                Debug.WriteLine("Nachricht anzeigen: Text: Willst du die Arbeit speichern? PS: Wäre schade wenn's weg ist, Button: Speichern?")
                Dim result As DialogResult = MessageBox.Show("Willst du die Arbeit speichern? PS: Wäre schade wenn's weg ist", "Speichern?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                Debug.WriteLine("Nachricht anzeigen: Text: Willst du die Arbeit speichern? PS: Wäre schade wenn's weg ist, Button: Speichern? abgeschlossen")

                If result = DialogResult.Yes Then
                    Debug.WriteLine("result = DialogResult.Yes")
                    Debug.WriteLine("Ausführen der Funktion Speichern")

                    Speichern()
                    Debug.WriteLine("Ausführen der Funktion Speichern abgeschlossen")
                ElseIf result = DialogResult.Cancel Then
                    Debug.WriteLine("result = DialogResult.Cancel")

                    Debug.WriteLine("Return")
                    Return
                    Debug.WriteLine("Return abgeschlossen")
                End If
            End If
            Debug.WriteLine("Textfeld leeren")
            Textfeld.Text = String.Empty
            Debug.WriteLine("Textfeld leeren abgeschlossen")
            Debug.WriteLine("Setze isDocumentEdited = False")
            isDocumentEdited = False
            Debug.WriteLine("Setze isDocumentEdited = False abgeschlossen")
            Debug.WriteLine("Leere filePath")
            filePath = ""
            Debug.WriteLine("Leere filePath abgeschlossen")
            Debug.WriteLine("Ausführen der Funktion UpdateFenstertitel")
            UpdateFenstertitel()
            Debug.WriteLine("Ausführen der Funktion UpdateFenstertitel abgeschlossen")
            Debug.WriteLine("Ausführen der Funktion UpdateInfobar")
            UpdateInfobar()
            Debug.WriteLine("Ausführen der Funktion UpdateInfobar abgeschlossen")


        End If
        If e.Control AndAlso e.KeyCode = Keys.O Then
            Debug.WriteLine("e.Control AndAlso e.KeyCode = Keys.O")
            Debug.WriteLine("Konfigurieren von openFileDialog als neuer OpenFileDialog")
            Dim openFileDialog As New OpenFileDialog()
            Debug.WriteLine("Konfigurieren von openFileDialog als neuer OpenFileDialog abgeschlossen")
            Debug.WriteLine("Dateitypfilter von openFileDialog setzen auf: NotePads-Dokument (*.ntp)|*.ntp|Text (*.txt)|*.txt|Batch-Programm (*.bat)|*.bat|Alle Dateien (*.*)|*.*")
            openFileDialog.Filter = "NotePads-Dokument (*.ntp)|*.ntp|Text (*.txt)|*.txt|Batch-Programm (*.bat)|*.bat|Alle Dateien (*.*)|*.*"
            Debug.WriteLine("Dateitypfilter von openFileDialog setzen auf: NotePads-Dokument (*.ntp)|*.ntp|Text (*.txt)|*.txt|Batch-Programm (*.bat)|*.bat|Alle Dateien (*.*)|*.* abgeschlossen")

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Debug.WriteLine("openFileDialog.ShowDialog() = DialogResult.OK")
                If isDocumentEdited Then
                    Debug.WriteLine("isDocumentEdited = True")
                    Debug.WriteLine("Nachricht anzeigen: Text: Willst du die Arbeit speichern? PS: Wäre schade wenn's weg ist, Button: Speichern?")
                    Dim result As DialogResult = MessageBox.Show("Willst du die Arbeit speichern? PS: Wäre schade wenn's weg ist", "Speichern?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                    Debug.WriteLine("Nachricht anzeigen: Text: Willst du die Arbeit speichern? PS: Wäre schade wenn's weg ist, Button: Speichern? abgeschlossen")
                    If result = DialogResult.Yes Then
                        Debug.WriteLine("result = DialogResult.Yes")
                        Debug.WriteLine("Ausführen der Funktion Speichern")

                        Speichern()
                        Debug.WriteLine("Ausführen der Funktion Speichern abgeschlossen")
                    ElseIf result = DialogResult.Cancel Then
                        Debug.WriteLine("result = DialogResult.Cancel")
                        Debug.WriteLine("Return")

                        Return
                        Debug.WriteLine("Return abgeschlossen")

                    End If
                End If
                Debug.WriteLine("Zeigen von Importing")
                Importing.Show()
                Debug.WriteLine("Zeigen von Importing abgeschlossen")
                Debug.WriteLine("setze filePath = openFileDialog.FileName")
                filePath = openFileDialog.FileName
                Debug.WriteLine("setze filePath = openFileDialog.FileName abgeschlossen")
                Try
                    Debug.WriteLine("Try: setze fileContent als String = File.ReadAllText(filePath)")
                    Dim fileContent As String

                    Try
                        fileContent = File.ReadAllText(filePath)
                    Catch ex As FileNotFoundException
                        FileNotFound.ShowDialog()

                    Catch ex As UnauthorizedAccessException
                        UnauthorizedAccess.ShowDialog()
                    Catch ex As IOException
                        IO.ShowDialog()
                    Catch ex As PathTooLongException
                        PathTooLong.ShowDialog()
                    Catch ex As ArgumentException
                        Argument.ShowDialog()
                    Catch ex As SecurityException
                        Security.ShowDialog()
                    Catch ex As OutOfMemoryException
                        OutOfMemory.ShowDialog()
                    End Try

                    Debug.WriteLine("Try: setze fileContent als String = File.ReadAllText(filePath) abgeschlossen")
                    Debug.WriteLine("Try: setze Textfeld.Text = fileContent")
                    Textfeld.Text = fileContent
                    Debug.WriteLine("Try: setze Textfeld.Text = fileContent abgeschlossen")
                    Debug.WriteLine("Try: setze isDocumentEdited = False")
                    isDocumentEdited = False
                    Debug.WriteLine("Try: setze isDocumentEdited = False abgeschlossen")
                    Debug.WriteLine("Try: Ausführen der Funktion UpdateFenstertitel")
                    UpdateFenstertitel()
                    Debug.WriteLine("Try: Ausführen der Funktion UpdateFenstertitel abgeschlossen")
                    Debug.WriteLine("Try: Ausführen der Funktion UpdateInfobar")
                    UpdateInfobar()
                    Debug.WriteLine("Try: Ausführen der Funktion UpdateInfobar abgeschlossen")
                    Debug.WriteLine("Try: Schließen von Importing")
                    Importing.Hide()
                    Debug.WriteLine("Try: Schließen von Importing")
                Catch ex As Exception
                    Debug.WriteLine("Exception: Schließen von Importing")
                    Importing.Hide()
                    Debug.WriteLine("Exception: Schließen von Importing abgeschlossen")
                    Debug.WriteLine("Exception: Nachricht anzeigen: Text: :-( Dein Dokument kann nicht gelesen werden: , Betreff: :-( Ein Fehler ist aufgetreten, MessageBoxButtons.OK, MessageBoxIcon.Error")
                    MessageBox.Show(":-( Dein Dokument kann nicht gelesen werden: " & ex.Message, ":-( Ein Fehler ist aufgetreten", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Debug.WriteLine("Exception: Nachricht anzeigen: Text: :-( Dein Dokument kann nicht gelesen werden: , Betreff: :-( Ein Fehler ist aufgetreten, MessageBoxButtons.OK, MessageBoxIcon.Error abgeschlossen")
                End Try
            End If
        End If
        If e.Control AndAlso e.KeyCode = Keys.S Then
            Debug.WriteLine("Ausführen der Funktion Speichern")
            Speichern()
            Debug.WriteLine("Ausführen der Funktion Speichern abgeschlossen")
        End If
        If e.Control AndAlso e.Shift AndAlso e.KeyCode = Keys.S Then
            Debug.WriteLine("Ausführen der Funktion SpeichernUnter")

            SpeichernUnter()
            Debug.WriteLine("Ausführen der Funktion SpeichernUnter abgeschlossen")

        End If



    End Sub
    Private Sub Form1_DragEnter(sender As Object, e As DragEventArgs) Handles MyBase.DragEnter
        Debug.WriteLine("Anfang der Funktion: Form1_DragEnter(sender As Object, e As DragEventArgs) Handles MyBase.DragEnter")
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Debug.WriteLine("e.Data.GetDataPresent(DataFormats.FileDrop) = True")
            Debug.WriteLine("setze e.Effect = DragDropEffects.Copy")

            e.Effect = DragDropEffects.Copy
            Debug.WriteLine("setze e.Effect = DragDropEffects.Copy abgeschlossen")
        Else
            UnsupportedFileDrag.ShowDialog()
        End If
    End Sub
    Private Sub Form1_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
        Debug.WriteLine("Anfang der Funktion: Form1_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop")
        Debug.WriteLine("setze files() als String = e.Data.GetData(DataFormats.FileDrop)")
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        Debug.WriteLine("setze files() als String = e.Data.GetData(DataFormats.FileDrop) abgeschlossen")

        ' Überprüfen, ob mindestens eine Datei vorhanden ist
        If files IsNot Nothing AndAlso files.Length > 0 Then
            Debug.WriteLine("files IsNot Nothing AndAlso files.Length > 0")
            Debug.WriteLine("setze filePath als String = files(0)")
            Dim filePath As String = files(0) ' Wir öffnen nur die erste Datei
            Debug.WriteLine("setze filePath als String = files(0) abgeschlossen")

            Debug.WriteLine("Ausführen der Funktion ÖffneDatei mit Parameter filePath")
            ÖffneDatei(filePath)
            Debug.WriteLine("Ausführen der Funktion ÖffneDatei mit Parameter filePath abgeschlossen")
        End If
    End Sub
    Private Sub ÖffneDatei(filePath As String)
        Debug.WriteLine("Anfang der Funktion: ÖffneDatei(filePath As String)")
        Try
            If File.Exists(filePath) Then
                Debug.WriteLine("File.Exists(filePath) = True")
                Debug.WriteLine("setze fileContent als String = File.ReadAllText(filePath)")
                Dim fileContent As String = File.ReadAllText(filePath)
                Debug.WriteLine("setze fileContent als String = File.ReadAllText(filePath) abgeschlossen")
                Debug.WriteLine("setze Textfeld.Text = fileContent")
                Textfeld.Text = fileContent
                Debug.WriteLine("setze Textfeld.Text = fileContent abgeschlossen")
                Debug.WriteLine("setze isDocumentEdited = False")
                isDocumentEdited = False
                Debug.WriteLine("setze isDocumentEdited = False abgeschlossen")
                Debug.WriteLine("Ausführen der Funktion UpdateFenstertitel")
                UpdateFenstertitel()
                Debug.WriteLine("Ausführen der Funktion UpdateFenstertitel abgeschlossen")
                Debug.WriteLine("Ausführen der Funktion UpdateInfobar")
                UpdateInfobar()
                Debug.WriteLine("Ausführen der Funktion UpdateInfobar abgeschlossen")

            Else
                Debug.WriteLine("Nachricht anzeigen: Text: :-( Dein Dokument kann nicht importiert werden: File not found, Betreff: :-( Ein Fehler ist aufgetreten, MessageBoxButtons.OK, MessageBoxIcon.Error")
                MessageBox.Show(":-( Dein Dokument kann nicht importiert werden: File not found", ":-( Ein Fehler ist aufgetreten", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Debug.WriteLine("Nachricht anzeigen: Text: :-( Dein Dokument kann nicht importiert werden: File not found, Betreff: :-( Ein Fehler ist aufgetreten, MessageBoxButtons.OK, MessageBoxIcon.Error abgeschlossen")

            End If
        Catch ex As FileNotFoundException
            FileNotFound.ShowDialog()

        Catch ex As UnauthorizedAccessException
            UnauthorizedAccess.ShowDialog()
        Catch ex As IOException
            IO.ShowDialog()
        Catch ex As PathTooLongException
            PathTooLong.ShowDialog()
        Catch ex As ArgumentException
            Argument.ShowDialog()
        Catch ex As SecurityException
            Security.ShowDialog()
        Catch ex As OutOfMemoryException
            OutOfMemory.ShowDialog()
        End Try


    End Sub
    'Private Sub Textfeld_KeyDown(sender As Object, e As KeyEventArgs) Handles Textfeld.KeyDown
    'If e.KeyCode = Keys.Enter Then
    ' Verhindere das Standardverhalten der Eingabetaste
    '   e.SuppressKeyPress = True

    ' Ermittle die aktuelle Cursorposition
    '  Dim cursorPosition As Integer = Textfeld.SelectionStart
    ' Dim lineIndex As Integer = Textfeld.GetLineFromCharIndex(cursorPosition)

    ' Überprüfe, ob das Textfeld mindestens eine Zeile enthält und ob der Cursor am Ende der Zeile steht
    'If lineIndex > 0 AndAlso cursorPosition = Textfeld.GetFirstCharIndexFromLine(lineIndex) + Textfeld.Lines(lineIndex).Length Then
    ' Ermittle den Text der vorherigen Zeile
    '   Dim previousLineText As String = Textfeld.Lines(lineIndex - 1)

    ' Überprüfe, ob die vorherige Zeile eine öffnende geschweifte Klammer enthält
    '  If previousLineText.TrimEnd().EndsWith("{") Then
    ' Füge den Tabulator und eine neue Zeile ein
    '     Textfeld.SelectedText = vbTab & Environment.NewLine

    ' Setze den Cursor manuell an das Ende der neuen Zeile
    '    Textfeld.SelectionStart = Textfeld.Text.Length
    '   Textfeld.SelectionLength = 0 ' Stelle sicher, dass keine Auswahl besteht
    'End If
    'End If
    'End If
    ' End Sub


    Private Sub AddContextMenuEntry()
        Debug.WriteLine("Anfang der Funktion AddContextMenuEntry")
        Debug.WriteLine("Setze Titel von Form1 = Einrichten von Registrierungsschlüsseln")

        Me.Text = "Einrichten von Registrierungsschlüsseln"
        Debug.WriteLine("Setze Titel von Form1 = Einrichten von Registrierungsschlüsseln abgeschlossen")

        Try
            Debug.WriteLine("Try: setze Key als Registrierungsschlüssel = Registry.ClassesRoot.OpenSubKey('*\shell', True)")
            Dim key As RegistryKey = Registry.ClassesRoot.OpenSubKey("*\shell", True)
            Debug.WriteLine("Try: setze Key als Registrierungsschlüssel = Registry.ClassesRoot.OpenSubKey('*\shell', True) abgeschlossen")
            Debug.WriteLine("Try: setze appKey als Registrierungsschlüssel = key.CreateSubKey('NotePads')")
            Dim appKey As RegistryKey = key.CreateSubKey("NotePads")
            Debug.WriteLine("Try: setze appKey als Registrierungsschlüssel = key.CreateSubKey('NotePads') abgeschlossen")
            Debug.WriteLine("Try: setze Wert von appKey = '', 'In NotePads importieren'")
            appKey.SetValue("", "In NotePads importieren")
            Debug.WriteLine("Try: setze Wert von appKey = '', 'In NotePads importieren' abgeschlossen")
            Debug.WriteLine("Try: setze importFileKey als Registrierungsschlüssel = appKey.CreateSubKey('importFile')")
            Dim importFileKey As RegistryKey = appKey.CreateSubKey("importFile")
            Debug.WriteLine("Try: setze importFileKey als Registrierungsschlüssel = appKey.CreateSubKey('importFile') abgeschlossen")
            Debug.WriteLine("Try: setze Wert von importFileKey = '', 'C:\Users\phmel\source\repos\NotePads\NotePads\bin\Debug\net8.0-windows\NotePads.exe'")
            importFileKey.SetValue("", "C:\Users\phmel\source\repos\NotePads\NotePads\bin\Debug\net8.0-windows\NotePads.exe")
            Debug.WriteLine("Try: setze Wert von importFileKey = '', 'C:\Users\phmel\source\repos\NotePads\NotePads\bin\Debug\net8.0-windows\NotePads.exe' abgeschlossen")
            Debug.WriteLine("Try: Schließen von importFileKey")
            importFileKey.Close()
            Debug.WriteLine("Try: Schließen von importFileKey abgeschlossen")
            Debug.WriteLine("Try: Schließen von appKey")
            appKey.Close()
            Debug.WriteLine("Try: Schließen von appKey abgeschlossen")
            Debug.WriteLine("Try: Schließen von key")
            key.Close()
            Debug.WriteLine("Try: Schließen von key abgeschlossen")
        Catch ex As UnauthorizedAccessException
            MessageBox.Show("Hey, NotePads kann nicht auf die Registrierung zugreifen! Hast du die nötigen Berechtigungen?", "Zugriffsfehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Debug.WriteLine("UnauthorizedAccessException: " & ex.Message)

        Catch ex As ArgumentException
            MessageBox.Show("Oops! Irgendwas stimmt nicht mit dem angegebenen Schlüssel. Check mal die Eingaben in NotePads!", "Ungültiges Argument", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Debug.WriteLine("ArgumentException: " & ex.Message)

        Catch ex As Exception
            MessageBox.Show("Da ist was schiefgegangen! NotePads konnte den Kontextmenüeintrag nicht hinzufügen. Versuch's später nochmal!", "Allgemeiner Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Debug.WriteLine("Allgemeiner Fehler: " & ex.Message)
        End Try

    End Sub

    Private WithEvents StatusBarLabel As New Label
    Private WithEvents zeileLabel As New Label()
    Private WithEvents zeichenLabel As New Label()
    Private WithEvents zeilenumbruchsmodusLabel As New Label()

    Private isDocumentEdited As Boolean = False
    Private filePath As String = ""

    Private Sub ShowOrHideInfoBar()
        Debug.WriteLine("Anfang der Funktion: ShowOrHideInfoBar()")

    End Sub

    Private Sub NeuesDokumentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeuesDokumentToolStripMenuItem.Click

        Try
            Debug.WriteLine("Anfang der Funktion: NeuesDokumentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeuesDokumentToolStripMenuItem.Click")

            If isDocumentEdited Then
                Debug.WriteLine("isDocumentEdited = True")
                Debug.WriteLine("Setze result als DialogResult = MessageBox.Show('Willst du die Arbeit speichern? PS: Wäre schade wenn's weg ist', 'Speichern?', MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)")

                Dim result As DialogResult = MessageBox.Show("Willst du die Arbeit speichern? PS: Wäre schade wenn's weg ist", "Speichern?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                Debug.WriteLine("Setze result als DialogResult = MessageBox.Show('Willst du die Arbeit speichern? PS: Wäre schade wenn's weg ist', 'Speichern?', MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) abgeschlossen")
                If result = DialogResult.Yes Then
                    Debug.WriteLine("result = DialogResult.Yes")
                    Debug.WriteLine("Ausführen der Funktion Speichern")

                    Speichern()
                    Debug.WriteLine("Ausführen der Funktion Speichern abgeschlossen")
                ElseIf result = DialogResult.Cancel Then
                    Debug.WriteLine("result = DialogResult.Cancel")
                    Debug.WriteLine("Return")
                    Return
                    Debug.WriteLine("Return abgeschlossen")

                End If
            End If
            Debug.WriteLine("setze Textfeld.Text = String.Empty")
            Textfeld.Text = String.Empty
            Debug.WriteLine("setze Textfeld.Text = String.Empty abgeschlossen")
            Debug.WriteLine("setze isDocumentEdited = False")
            isDocumentEdited = False
            Debug.WriteLine("setze isDocumentEdited = False abgeschlossen")
            Debug.WriteLine("leere Variable filePath")
            filePath = ""
            Debug.WriteLine("leere Variable filePath abgeschlossen")
            Debug.WriteLine("Ausführen der Funktion UpdateFenstertitel")
            UpdateFenstertitel()
            Debug.WriteLine("Ausführen der Funktion UpdateFenstertitel abgeschlossen")
            Debug.WriteLine("Ausführen der Funktion UpdateInfobar")
            UpdateInfobar()
            Debug.WriteLine("Ausführen der Funktion UpdateInfobar abgeschlossen")
        Catch ex As IOException
            IO.ShowDialog()
        Catch ex As UnauthorizedAccessException
            UnauthorizedAccess.ShowDialog()
        Catch ex As InvalidOperationException
            InvalidOperation.ShowDialog()
        Catch ex As ArgumentNullException
            ArgumentNull.ShowDialog()
        Catch ex As ObjectDisposedException
            ObjectDisposed.ShowDialog()
        Catch ex As NullReferenceException
            NullReference.ShowDialog()


        End Try

    End Sub

    Private Sub NeuStartenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeuStartenToolStripMenuItem.Click
        Debug.WriteLine("Anfang der Funktion: NeuStartenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeuStartenToolStripMenuItem.Click")
        If isDocumentEdited Then
            Debug.WriteLine("isDocumentEdited = True")
            Debug.WriteLine("Setze result als DialogResult = MessageBox.Show('Willst du die Arbeit speichern? PS: Wäre schade wenn's weg ist', 'Speichern?', MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)")
            Dim result As DialogResult = MessageBox.Show("Willst du die Arbeit speichern? PS: Wäre schade wenn's weg ist", "Speichern?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            Debug.WriteLine("Setze result als DialogResult = MessageBox.Show('Willst du die Arbeit speichern? PS: Wäre schade wenn's weg ist', 'Speichern?', MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) abgeschlossen")
            If result = DialogResult.Yes Then
                Debug.WriteLine("result = DialogResult.Yes")
                Debug.WriteLine("Ausführen der Funktion Speichern")
                Speichern()
                Debug.WriteLine("Ausführen der Funktion Speichern abgeschlossen")
            ElseIf result = DialogResult.Cancel Then
                Debug.WriteLine("result = DialogResult.Cancel")
                Debug.WriteLine("Return")
                Return
                Debug.WriteLine("Return abgeschlossen")
            End If
        End If
        Debug.WriteLine("Rebooting NotePads Application... Wait a moment!!!")
        Application.Restart()
    End Sub

    Private Sub DokumentÖffnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DokumentÖffnenToolStripMenuItem.Click
        Debug.WriteLine("Anfang der Funktion: DokumentÖffnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DokumentÖffnenToolStripMenuItem.Click")
        Debug.WriteLine("Konfigurieren von openFileDialog als neuer OpenFileDialog")
        Dim openFileDialog As New OpenFileDialog()
        Debug.WriteLine("Konfigurieren von openFileDialog als neuer OpenFileDialog abgeschlossen")
        Debug.WriteLine("Dateitypfilter von openFileDialog setzen auf: NotePads-Dokument (*.ntp)|*.ntp|Text (*.txt)|*.txt|Batch-Programm (*.bat)|*.bat|Alle Dateien (*.*)|*.*")
        openFileDialog.Filter = "NotePads-Dokument (*.ntp)|*.ntp|Text (*.txt)|*.txt|Batch-Programm (*.bat)|*.bat|Alle Dateien (*.*)|*.*"
        Debug.WriteLine("Dateitypfilter von openFileDialog setzen auf: NotePads-Dokument (*.ntp)|*.ntp|Text (*.txt)|*.txt|Batch-Programm (*.bat)|*.bat|Alle Dateien (*.*)|*.* abgeschlossen")

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Debug.WriteLine("openFileDialog.ShowDialog() = DialogResult.OK")
            If isDocumentEdited Then
                Debug.WriteLine("isDocumentEdited = True")
                Debug.WriteLine("Setze result als DialogResult = MessageBox.Show('Willst du die Arbeit speichern? PS: Wäre schade wenn's weg ist', 'Speichern?', MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)")
                Dim result As DialogResult = MessageBox.Show("Willst du die Arbeit speichern? PS: Wäre schade wenn's weg ist", "Speichern?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                Debug.WriteLine("Setze result als DialogResult = MessageBox.Show('Willst du die Arbeit speichern? PS: Wäre schade wenn's weg ist', 'Speichern?', MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) abgeschlossen")
                If result = DialogResult.Yes Then
                    Debug.WriteLine("result = DialogResult.Yes")
                    Debug.WriteLine("Ausführen der Funktion Speichern")

                    Speichern()
                    Debug.WriteLine("Ausführen der Funktion Speichern abgeschlossen")
                ElseIf result = DialogResult.Cancel Then
                    Debug.WriteLine("result = DialogResult.Cancel")
                    Debug.WriteLine("Return")

                    Return
                    Debug.WriteLine("Return abgeschlossen")

                End If
            End If
            Debug.WriteLine("Zeigen von Importing")
            Importing.Show()
            Debug.WriteLine("Zeigen von Importing abgeschlossen")
            Debug.WriteLine("setze filePath = openFileDialog.FileName")
            filePath = openFileDialog.FileName
            Debug.WriteLine("setze filePath = openFileDialog.FileName abgeschlossen")
            Try
                Debug.WriteLine("Try: setze fileContent als String = File.ReadAllText(filePath)")
                Dim fileContent As String = File.ReadAllText(filePath)
                Debug.WriteLine("Try: setze fileContent als String = File.ReadAllText(filePath) abgeschlossen")
                Debug.WriteLine("Try: setze Textfeld.Text = fileContent")
                Textfeld.Text = fileContent
                Debug.WriteLine("Try: setze Textfeld.Text = fileContent abgeschlossen")
                Debug.WriteLine("Try: setze isDocumentEdited = False")
                isDocumentEdited = False
                Debug.WriteLine("Try: setze isDocumentEdited = False abgeschlossen")
                Debug.WriteLine("Try: Ausführen der Funktion UpdateFenstertitel")
                UpdateFenstertitel()
                Debug.WriteLine("Try: Ausführen der Funktion UpdateFenstertitel abgeschlossen")
                Debug.WriteLine("Try: Ausführen der Funktion UpdateInfobar")
                UpdateInfobar()
                Debug.WriteLine("Try: Ausführen der Funktion UpdateInfobar abgeschlossen")
                Debug.WriteLine("Try: Schließen von Importing")
                Importing.Hide()
                Debug.WriteLine("Try: Schließen von Importing")
            Catch ex As Exception
                Debug.WriteLine("Exception: Schließen von Importing")
                Importing.Hide()
                Debug.WriteLine("Exception: Schließen von Importing abgeschlossen")
                Debug.WriteLine("Exception: Nachricht anzeigen: Text: :-( Dein Dokument kann nicht gelesen werden: , Betreff: :-( Ein Fehler ist aufgetreten, MessageBoxButtons.OK, MessageBoxIcon.Error")
                MessageBox.Show(":-( Dein Dokument kann nicht gelesen werden: " & ex.Message, ":-( Ein Fehler ist aufgetreten", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Debug.WriteLine("Exception: Nachricht anzeigen: Text: :-( Dein Dokument kann nicht gelesen werden: , Betreff: :-( Ein Fehler ist aufgetreten, MessageBoxButtons.OK, MessageBoxIcon.Error abgeschlossen")
            End Try
        End If
    End Sub

    Private Sub SichernToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SichernToolStripMenuItem.Click
        Debug.WriteLine("Anfang der Funktion: SichernToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SichernToolStripMenuItem.Click")
        Debug.WriteLine("Ausführen der Funktion Speichern")
        Speichern()
        Debug.WriteLine("Ausführen der Funktion Speichern abgeschlossen")
    End Sub

    Private Sub Speichern()
        Debug.WriteLine("Anfang der Funktion Speichern")
        If String.IsNullOrEmpty(filePath) Then
            Debug.WriteLine("String.IsNullOrEmpty(filePath) = True")
            Debug.WriteLine("Ausführen der Funktion SpeichernUnter")
            SpeichernUnter()
            Debug.WriteLine("Ausführen der Funktion SpeichernUnter abgeschlossen")
        Else
            Try
                Debug.WriteLine("Try: Zeige Saving")
                Saving.Show()
                Debug.WriteLine("Try: Zeige Saving abgeschlossen")
                Debug.WriteLine("Try: Schreibe Datei mit Parametern: filePath, Textfeld.Text")
                File.WriteAllText(filePath, Textfeld.Text)
                Debug.WriteLine("Try: Schreibe Datei mit Parametern: filePath, Textfeld.Text abgeschlossen")
                Debug.WriteLine("Try: Setze isDocumentEdited = False")
                isDocumentEdited = False
                Debug.WriteLine("Try: Setze isDocumentEdited = False abgeschlossen")
                Debug.WriteLine("Try: Ausführen der Funktion UpdateFenstertitel")
                UpdateFenstertitel()
                Debug.WriteLine("Try: Ausführen der Funktion UpdateFenstertitel abgeschlossen")
                Debug.WriteLine("Try: Setze Me.Text = 'NotePads | ' & filePath")
                Me.Text = "NotePads | " & filePath
                Debug.WriteLine("Try: Setze Me.Text = 'NotePads | ' & filePath abgeschlossen")
                Debug.WriteLine("Try: Schließen von Saving")
                Saving.Hide()
                Debug.WriteLine("Try: Schließen von Saving abgeschlossen")

            Catch ex As ArgumentException
                Argument.ShowDialog()
            Catch ex As UnauthorizedAccessException
                UnauthorizedAccess.ShowDialog()
            Catch ex As IOException
                IO.ShowDialog()
            Catch ex As PathTooLongException
                PathTooLong.ShowDialog()
            Catch ex As DirectoryNotFoundException
                DirectoryNotFound.ShowDialog()
            Catch ex As NotSupportedException

            End Try

        End If
    End Sub

    Private Sub SichernUnterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SichernUnterToolStripMenuItem.Click
        Debug.WriteLine("Anfang der Funktion: SichernUnterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SichernUnterToolStripMenuItem.Click")
        Debug.WriteLine("Ausführen der Funktion SpeichernUnter")

        SpeichernUnter()
        Debug.WriteLine("Ausführen der Funktion SpeichernUnter abgeschlossen")

    End Sub
    Private Function FirstLineFromTextfield() As String
        Debug.WriteLine("Anfang der Funktion FirstLineFromTextfield() As String")
        Debug.WriteLine("Setze firstLine als String")
        Dim firstLine As String
        Debug.WriteLine("Setze firstLine als String abgeschlossen")
        Try
            Debug.WriteLine("Try: Setze firstLine = Textfeld.Lines.First")
            firstLine = Textfeld.Lines.First
            Debug.WriteLine("Try: Setze firstLine = Textfeld.Lines.First abgeschlossen")
        Catch ex As Exception
            Debug.WriteLine("Exception: Setze firstLine = 'Neues NotePads-Dokument'")
            firstLine = "Neues NotePads-Dokument"
            Debug.WriteLine("Exception: Setze firstLine = 'Neues NotePads-Dokument' abgeschlossen")
        End Try


        ' Überprüfen, ob das Textfeld Text enthält
        If Not String.IsNullOrEmpty(Textfeld.Text) Then
            Debug.WriteLine("Not String.IsNullOrEmpty(Textfeld.Text) = True")
            ' Text in Zeilen aufteilen
            Debug.WriteLine("Setze lines() als String = Textfeld.Text.Split(New String() {Environment.NewLine}, StringSplitOptions.None)")
            Dim lines() As String = Textfeld.Text.Split(New String() {Environment.NewLine}, StringSplitOptions.None)
            Debug.WriteLine("Setze lines() als String = Textfeld.Text.Split(New String() {Environment.NewLine}, StringSplitOptions.None) abgeschlossen")
            ' Überprüfen, ob es mindestens eine Zeile gibt
            If lines.Length > 0 Then
                Debug.WriteLine("lines.Length > 0")

                'firstLine = lines(0).Trim() ' Nur die erste Zeile verwenden und Leerzeichen entfernen
            End If
        End If
        Debug.WriteLine("Gebe firstLine zurück")
        Return firstLine
        Debug.WriteLine("Gebe firstLine zurück abgeschlossen")

    End Function
    Private Sub SpeichernUnter()
        Debug.WriteLine("Anfang der Funktion: SpeichernUnter")
        Debug.WriteLine("Setze saveFileDialog als New SaveFileDialog()")
        Dim saveFileDialog As New SaveFileDialog()
        Debug.WriteLine("Setze saveFileDialog als New SaveFileDialog() abgeschlossen")
        Debug.WriteLine("Setze firstLine als String = FirstLineFromTextfield()")
        Dim firstLine As String = FirstLineFromTextfield()
        Debug.WriteLine("Setze firstLine als String = FirstLineFromTextfield()")

        If String.IsNullOrEmpty(firstLine) Then
            Debug.WriteLine("String.IsNullOrEmpty(firstLine) = True")
            Debug.WriteLine("Setze firstLine = 'Neues NotePads-Dokument'")
            firstLine = "Neues NotePads-Dokument" ' Setze einen Standardnamen, falls die erste Zeile leer ist
            Debug.WriteLine("Setze firstLine = 'Neues NotePads-Dokument' abgeschlossen")
        End If
        Debug.WriteLine("Setze saveFileDialog.FileName = firstLine")
        saveFileDialog.FileName = firstLine
        Debug.WriteLine("Setze saveFileDialog.FileName = firstLine abgeschlossen")
        Debug.WriteLine("Setze saveFileDialog.Filter = 'NotePads-Dokument (*.ntp)|*.ntp|Text (*.txt)|*.txt|Batch-Programm (*.bat)|*.bat|Alle Dateien (*.*)|*.*'")
        saveFileDialog.Filter = "NotePads-Dokument (*.ntp)|*.ntp|Text (*.txt)|*.txt|Batch-Programm (*.bat)|*.bat|Alle Dateien (*.*)|*.*"
        Debug.WriteLine("Setze saveFileDialog.Filter = 'NotePads-Dokument (*.ntp)|*.ntp|Text (*.txt)|*.txt|Batch-Programm (*.bat)|*.bat|Alle Dateien (*.*)|*.*' abgeschlossen")
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Debug.WriteLine("saveFileDialog.ShowDialog() = DialogResult.OK")
            Debug.WriteLine("setze filePath = saveFileDialog.FileName")
            filePath = saveFileDialog.FileName
            Debug.WriteLine("setze filePath = saveFileDialog.FileName abgeschlossen")


            Try
                Debug.WriteLine("Try: Schreibe Datei mit Parametern: filePath, Textfeld.Text")
                File.WriteAllText(filePath, Textfeld.Text)
                Debug.WriteLine("Try: Schreibe Datei mit Parametern: filePath, Textfeld.Text abgeschlossen")
                Debug.WriteLine("Try: setze isDocumentEdited = False")
                isDocumentEdited = False
                Debug.WriteLine("Try: setze isDocumentEdited = False abgeschlossen")
                Debug.WriteLine("Try: Ausführen der Funktion: UpdateFenstertitel")
                UpdateFenstertitel()
                Debug.WriteLine("Try: Ausführen der Funktion: UpdateFenstertitel abgeschlossen")
                Debug.WriteLine("Try: setze Me.Text = 'NotePads | ' & filePath")
                Me.Text = "NotePads | " & filePath
                Debug.WriteLine("Try: setze Me.Text = 'NotePads | ' & filePath abgeschlossen")
            Catch ex As Exception
                Debug.WriteLine("Exception: Nachricht anzeigen: Text: :-( Dein Dokument kann nicht gespeichert werden: ' & ex.Message, Betreff: :-( Ein Fehler ist aufgetreten, MessageBoxButtons.OK, MessageBoxIcon.Error")
                MessageBox.Show(":-( Dein Dokument kann nicht gespeichert werden: " & ex.Message, ":-( Ein Fehler ist aufgetreten", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Debug.WriteLine("Exception: Nachricht anzeigen: Text: :-( Dein Dokument kann nicht gespeichert werden: ' & ex.Message, Betreff: :-( Ein Fehler ist aufgetreten, MessageBoxButtons.OK, MessageBoxIcon.Error abgeschlossen")

            End Try
        End If
    End Sub


    Private Sub UpdateFenstertitel()
        Debug.WriteLine("Anfang der Funktion: UpdateFenstertitel")

        If String.IsNullOrEmpty(filePath) Then
            Debug.WriteLine("String.IsNullOrEmpty(filePath) = True")
            Debug.WriteLine("Setze Me.Text = 'NotePads | Neu'")
            Me.Text = "NotePads | Neu"
            Debug.WriteLine("Setze Me.Text = 'NotePads | Neu' abgeschlossen")
        Else
            Debug.WriteLine("Setze Me.Text = 'NotePads | ' & filePath")
            Me.Text = "NotePads | " & filePath
            Debug.WriteLine("Setze Me.Text = 'NotePads | ' & filePath abgeschlossen")

        End If
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Debug.WriteLine("Anfang der Funktion: BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click")
        If isDocumentEdited Then
            Debug.WriteLine("isDocumentEdited = True")
            Debug.WriteLine("Setze result als DialogResult = MessageBox.Show('Willst du die Arbeit speichern? PS: Wäre schade wenn's weg ist', 'Speichern?', MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)")
            Dim result As DialogResult = MessageBox.Show("Willst du die Arbeit speichern? PS: Wäre schade wenn's weg ist", "Speichern?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            Debug.WriteLine("Setze result als DialogResult = MessageBox.Show('Willst du die Arbeit speichern? PS: Wäre schade wenn's weg ist', 'Speichern?', MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) abgeschlossen")
            If result = DialogResult.Yes Then
                Debug.WriteLine("result = DialogResult.Yes")
                Debug.WriteLine("Ausführen der Funktion Speichern")

                Speichern()
                Debug.WriteLine("Ausführen der Funktion Speichern abgeschlossen")

            ElseIf result = DialogResult.Cancel Then
                Debug.WriteLine("result = DialogResult.Cancel")
                Debug.WriteLine("Return")
                Return
                Debug.WriteLine("Return abgeschlossen")

            End If
        End If
        Debug.WriteLine("Shutting down NotePads application... Wait a moment!!!")
        Application.Exit()
    End Sub

    Private Sub Zeile_Click(sender As Object, e As EventArgs) Handles Zeile.Click

    End Sub

    Private Sub Zeichen_Click(sender As Object, e As EventArgs) Handles Zeichen.Click

    End Sub

    Private Sub Zeilenumbruchmodus_Click(sender As Object, e As EventArgs) Handles Zeilenumbruchmodus.Click

    End Sub

    Private Sub UpdateInfobar()
        Debug.WriteLine("Anfang der Funktion: UpdateInfobar()")

        If InfobarZeigenToolStripMenuItem.Checked Then
            Debug.WriteLine("InfobarZeigenToolStripMenuItem.Checked = True")
            Debug.WriteLine("Setze lines Als Integer = Textfeld.GetLineFromCharIndex(Textfeld.SelectionStart)")
            Dim lines As Integer = Textfeld.GetLineFromCharIndex(Textfeld.SelectionStart)
            Debug.WriteLine("Setze lines Als Integer = Textfeld.GetLineFromCharIndex(Textfeld.SelectionStart) abgeschlossen")
            Debug.WriteLine("Setze characters Als Integer = Textfeld.Text.Length")
            Dim characters As Integer = Textfeld.Text.Length
            Debug.WriteLine("Setze characters Als Integer = Textfeld.Text.Length abgeschlossen")
            Debug.WriteLine("Setze newlineMode Als String = If(Textfeld.Text.Contains(vbCrLf), 'Microsoft Windows (CR+LF)', 'Unix (LF)')")
            Dim newlineMode As String = If(Textfeld.Text.Contains(vbCrLf), "Microsoft Windows (CR+LF)", "Unix (LF)")
            Debug.WriteLine("Setze newlineMode Als String = If(Textfeld.Text.Contains(vbCrLf), 'Microsoft Windows (CR+LF)', 'Unix (LF)') abgeschlossen")
            Debug.WriteLine("Setze Zeilenwert.Visible = True")
            Zeilenwert.Visible = True
            Debug.WriteLine("Setze Zeilenwert.Visible = True abgeschlossen")
            Zeichenwert.Visible = True
            Debug.WriteLine("Setze Zeilenumbruchmoduswert.Visible = True")
            Zeilenumbruchmoduswert.Visible = True
            Debug.WriteLine("Setze Zeilenumbruchmoduswert.Visible = True abgeschlossen")
            Debug.WriteLine("Setze Zeilenwert.Text = $'{lines}'")
            Zeilenwert.Text = $"{lines}"
            Debug.WriteLine("Setze Zeilenwert.Text = $'{lines}' abgeschlossen")
            Debug.WriteLine("Setze Zeichenwert.Text = $'{characters + 1}'")

            Zeichenwert.Text = $"{characters + 1}"
            Debug.WriteLine("Setze Zeichenwert.Text = $'{characters + 1}' abgeschlossen")
            Debug.WriteLine("Setze Zeilenumbruchmoduswert.Text = $'{newlineMode}'")
            Zeilenumbruchmoduswert.Text = $"{newlineMode}"
            Debug.WriteLine("Setze Zeilenumbruchmoduswert.Text = $'{newlineMode}' abgeschlossen")


        End If

    End Sub


    Private Sub Textfeld_TextChanged(sender As Object, e As EventArgs)
        Debug.WriteLine("Anfang der Funktion: Textfeld_TextChanged(sender As Object, e As EventArgs)")
        Debug.WriteLine("Setze isDocumentEdited = True")
        isDocumentEdited = True
        Debug.WriteLine("Setze isDocumentEdited = True abgeschlossen")
        Debug.WriteLine("Ausführen der Funktion UpdateInfoBar")
        UpdateInfobar()
        Debug.WriteLine("Ausführen der Funktion UpdateInfoBar abgeschlossen")
    End Sub
    Private Sub Textfeld_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textfeld.KeyPress
        Debug.WriteLine("Anfang der Funktion: Textfeld_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Textfeld.KeyPress")
        Debug.WriteLine("Ausführen der Funktion UpdateInfoBar")

        UpdateInfobar()
        Debug.WriteLine("Ausführen der Funktion UpdateInfoBar abgeschlossen")

    End Sub

    Private Sub infobar_Paint(sender As Object, e As PaintEventArgs) Handles infobar.Paint

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Debug.WriteLine("Booting NotePads Application... Wait a moment!!!")
        If My.Settings.AutoSave = "TextChanged" Then
            Debug.WriteLine("My.Settings.AutoSave = 'TextChanged'")
            Debug.WriteLine("Setze AutoSave = 'TextChanged'")
            AutoSave = "TextChanged"
            Debug.WriteLine("Setze AutoSave = 'TextChanged' abgeschlossen")
        End If
        If My.Settings.AutoSave = "after10seconds" Then
            Debug.WriteLine("My.Settings.AutoSave = 'after10seconds'")
            Debug.WriteLine("Setze AutoSave = 'after10seconds'")

            AutoSave = "after10seconds"
            Debug.WriteLine("Setze AutoSave = 'after10seconds' abgeschlossen")
        End If
        If My.Settings.AutoSave = "after30seconds" Then
            Debug.WriteLine("My.Settings.AutoSave = 'after30seconds'")
            Debug.WriteLine("Setze AutoSave = 'after30seconds'")
            AutoSave = "after30seconds"
            Debug.WriteLine("Setze AutoSave = 'after30seconds' abgeschlossen")
        End If
    End Sub

    Private Sub RückgängigToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RückgängigToolStripMenuItem.Click
        Debug.WriteLine("Anfang der Funktion: RückgängigToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RückgängigToolStripMenuItem.Click")
        Debug.WriteLine("Ausführen der Funktion Textfeld.Undo()")
        Textfeld.Undo()
        Debug.WriteLine("Ausführen der Funktion Textfeld.Undo() abgeschlossen")
    End Sub

    Private Sub VorgängigToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VorgängigToolStripMenuItem.Click
        Debug.WriteLine("Anfang der Funktion: VorgängigToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VorgängigToolStripMenuItem.Click")
        Debug.WriteLine("Ausführen der Funktion Textfeld.Redo()")
        Textfeld.Redo()
        Debug.WriteLine("Ausführen der Funktion Textfeld.Redo() abgeschlossen")

    End Sub

    Private Sub AusschneidenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AusschneidenToolStripMenuItem.Click
        Debug.WriteLine("Anfang der Funktion: AusschneidenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AusschneidenToolStripMenuItem.Click")
        Debug.WriteLine("Ausführen der Funktion Textfeld.Cut()")
        Textfeld.Cut()
        Debug.WriteLine("Ausführen der Funktion Textfeld.Cut() abgeschlossen")

    End Sub

    Private Sub EinfügenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EinfügenToolStripMenuItem.Click
        Debug.WriteLine("Anfang der Funktion: EinfügenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EinfügenToolStripMenuItem.Click")
        Debug.WriteLine("Ausführen der Funktion Textfeld.Paste()")

        Textfeld.Paste()
        Debug.WriteLine("Ausführen der Funktion Textfeld.Paste() abgeschlossen")

    End Sub

    Private Sub KopierenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KopierenToolStripMenuItem.Click
        Debug.WriteLine("Anfang der Funktion: KopierenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KopierenToolStripMenuItem.Click")
        Debug.WriteLine("Ausführen der Funktion Textfeld.Copy()")

        Textfeld.Copy()
        Debug.WriteLine("Ausführen der Funktion Textfeld.Copy() abgeschlossen")

    End Sub

    Private Sub AllesAuswählenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllesAuswählenToolStripMenuItem.Click
        Debug.WriteLine("Anfang der Funktion: AllesAuswählenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllesAuswählenToolStripMenuItem.Click")
        Debug.WriteLine("Ausführen der Funktion Textfeld.SelectAll()")
        Textfeld.SelectAll()
        Debug.WriteLine("Ausführen der Funktion Textfeld.SelectAll() abgeschlossen")

    End Sub

    Private Sub SuchenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuchenToolStripMenuItem.Click
        Debug.WriteLine("Anfang der Funktion: SuchenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuchenToolStripMenuItem.Click")
        Debug.WriteLine("Setze suche Als New Suche")
        Dim suche As New Suche()
        Debug.WriteLine("Setze suche Als New Suche abgeschlossen")
        If suche.ShowDialog() = DialogResult.OK Then
            Debug.WriteLine("suche.ShowDialog() = DialogResult.OK")



        End If
    End Sub

    Private Sub InfobarZeigenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfobarZeigenToolStripMenuItem.Click
        Debug.WriteLine("Anfang der Funktion: InfobarZeigenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfobarZeigenToolStripMenuItem.Click")
        If InfobarZeigenToolStripMenuItem.Checked = False Then
            Debug.WriteLine("InfobarZeigenToolStripMenuItem.Checked = False")
            Debug.WriteLine("Schließen von infobar")
            infobar.Hide()
            Debug.WriteLine("Schließen von infobar abgeschlossen")
        End If
        If InfobarZeigenToolStripMenuItem.Checked = True Then
            Debug.WriteLine("InfobarZeigenToolStripMenuItem.Checked = True")
            Debug.WriteLine("Zeigen von infobar")
            infobar.Show()
            Debug.WriteLine("Zeigen von infobar abgeschlossen")
        End If
    End Sub

    'Wechsle Titel bei Änderungen zu nicht gesichert
    Private Sub Textfeld_TextChanged_1(sender As Object, e As EventArgs) Handles Textfeld.TextChanged
        Debug.WriteLine("Anfang der Funktion: Textfeld_TextChanged_1(sender As Object, e As EventArgs) Handles Textfeld.TextChanged")
        If AutoSave = "TextChanged" Then
            Debug.WriteLine("AutoSave = 'TextChanged'")
            If Not filePath = "" Then
                Debug.WriteLine("Not filePath = ''")
                Debug.WriteLine("Ausführen der Funktion Speichern()")
                Speichern()
                Debug.WriteLine("Ausführen der Funktion Speichern() abgeschlossen")

            End If
        End If
        Debug.WriteLine("Setze Me.Text = 'NotePads | ' & filePath & ' (Nicht gesichert)'")

        Me.Text = "NotePads | " & filePath & " (Nicht gesichert)"
        Debug.WriteLine("Setze Me.Text = 'NotePads | ' & filePath & ' (Nicht gesichert)' abgeschlossen")
    End Sub

    Private Sub ÜberToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÜberToolStripMenuItem.Click
        Debug.WriteLine("Zeigen von About als Dialog")
        About.ShowDialog()
        Debug.WriteLine("Zeigen von About als Dialog abgeschlossen")
    End Sub

    Private Sub EinstellungenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EinstellungenToolStripMenuItem.Click
        Debug.WriteLine("Zeigen von Settings als Dialog")

        Settings.ShowDialog()
        Debug.WriteLine("Zeigen von Settings als Dialog abgeschlossen")
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub
End Class
