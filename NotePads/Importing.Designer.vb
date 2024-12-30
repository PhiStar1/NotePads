<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Importing
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        ProgressBar1 = New ProgressBar()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(188, 50)
        Label1.TabIndex = 0
        Label1.Text = "Datei wird importiert..." & vbCrLf & vbCrLf
        ' 
        ' ProgressBar1
        ' 
        ProgressBar1.Cursor = Cursors.WaitCursor
        ProgressBar1.Location = New Point(12, 43)
        ProgressBar1.Name = "ProgressBar1"
        ProgressBar1.Size = New Size(636, 28)
        ProgressBar1.TabIndex = 1
        ProgressBar1.Value = 99
        ' 
        ' Importing
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(660, 0)
        Controls.Add(ProgressBar1)
        Controls.Add(Label1)
        Name = "Importing"
        Text = "Importieren"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
