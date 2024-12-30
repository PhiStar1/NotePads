<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Security
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        ToolStrip1 = New ToolStrip()
        ToolStripLabel1 = New ToolStripLabel()
        ToolStripSeparator1 = New ToolStripSeparator()
        ToolStripLabel2 = New ToolStripLabel()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(0, 28)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(100, 100)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(106, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(653, 50)
        Label1.TabIndex = 1
        Label1.Text = "NotePads sagt: " & vbCrLf & "Keine Berechtigung! Ohne die richtigen Rechte kommst du hier leider nicht weiter."
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(734, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 25)
        Label2.TabIndex = 2
        Label2.Text = "Schließen"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.BackColor = SystemColors.Control
        ToolStrip1.ImageScalingSize = New Size(24, 24)
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripLabel1, ToolStripSeparator1, ToolStripLabel2})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(823, 30)
        ToolStrip1.TabIndex = 3
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripLabel1
        ' 
        ToolStripLabel1.Name = "ToolStripLabel1"
        ToolStripLabel1.Size = New Size(23, 25)
        ToolStripLabel1.Text = "X"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 30)
        ' 
        ' ToolStripLabel2
        ' 
        ToolStripLabel2.Name = "ToolStripLabel2"
        ToolStripLabel2.Size = New Size(206, 25)
        ToolStripLabel2.Text = "Rechte nicht ausreichend"
        ' 
        ' Security
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(823, 129)
        ControlBox = False
        Controls.Add(ToolStrip1)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.None
        MinimizeBox = False
        Name = "Security"
        Text = "Notepads kann min. ein angegebenes Element nicht finden"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
End Class
