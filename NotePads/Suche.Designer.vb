<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Suche
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
        SuchenButton = New Label()
        CancelSuche = New Label()
        TextBox1 = New TextBox()
        Label2 = New Label()
        ToolStrip1 = New ToolStrip()
        ToolStripLabel1 = New ToolStripLabel()
        ChangeSize = New ToolStripLabel()
        ToolStripSeparator1 = New ToolStripSeparator()
        ToolStripLabel2 = New ToolStripLabel()
        ToolStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' SuchenButton
        ' 
        SuchenButton.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        SuchenButton.AutoSize = True
        SuchenButton.Location = New Point(425, 320)
        SuchenButton.Margin = New Padding(2, 0, 2, 0)
        SuchenButton.Name = "SuchenButton"
        SuchenButton.Size = New Size(70, 25)
        SuchenButton.TabIndex = 0
        SuchenButton.Text = "Suchen"
        ' 
        ' CancelSuche
        ' 
        CancelSuche.Anchor = AnchorStyles.Bottom Or AnchorStyles.Right
        CancelSuche.AutoSize = True
        CancelSuche.Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CancelSuche.Location = New Point(509, 320)
        CancelSuche.Margin = New Padding(2, 0, 2, 0)
        CancelSuche.Name = "CancelSuche"
        CancelSuche.Size = New Size(99, 25)
        CancelSuche.TabIndex = 1
        CancelSuche.Text = "Abbrechen"
        ' 
        ' TextBox1
        ' 
        TextBox1.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        TextBox1.Location = New Point(119, 116)
        TextBox1.Margin = New Padding(2)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(491, 31)
        TextBox1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(9, 118)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 25)
        Label2.TabIndex = 3
        Label2.Text = "Suche nach"
        ' 
        ' ToolStrip1
        ' 
        ToolStrip1.ImageScalingSize = New Size(24, 24)
        ToolStrip1.Items.AddRange(New ToolStripItem() {ToolStripLabel1, ChangeSize, ToolStripSeparator1, ToolStripLabel2})
        ToolStrip1.Location = New Point(0, 0)
        ToolStrip1.Name = "ToolStrip1"
        ToolStrip1.Size = New Size(615, 30)
        ToolStrip1.TabIndex = 4
        ToolStrip1.Text = "ToolStrip1"
        ' 
        ' ToolStripLabel1
        ' 
        ToolStripLabel1.Name = "ToolStripLabel1"
        ToolStripLabel1.Size = New Size(23, 25)
        ToolStripLabel1.Text = "X"
        ' 
        ' ChangeSize
        ' 
        ChangeSize.Name = "ChangeSize"
        ChangeSize.Size = New Size(26, 25)
        ChangeSize.Text = "O"
        ' 
        ' ToolStripSeparator1
        ' 
        ToolStripSeparator1.Name = "ToolStripSeparator1"
        ToolStripSeparator1.Size = New Size(6, 30)
        ' 
        ' ToolStripLabel2
        ' 
        ToolStripLabel2.Name = "ToolStripLabel2"
        ToolStripLabel2.Size = New Size(59, 25)
        ToolStripLabel2.Text = "Suche"
        ' 
        ' Suche
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(615, 352)
        Controls.Add(ToolStrip1)
        Controls.Add(Label2)
        Controls.Add(TextBox1)
        Controls.Add(CancelSuche)
        Controls.Add(SuchenButton)
        Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FormBorderStyle = FormBorderStyle.None
        KeyPreview = True
        Margin = New Padding(2)
        Name = "Suche"
        Text = "Suche"
        ToolStrip1.ResumeLayout(False)
        ToolStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents SuchenButton As Label
    Friend WithEvents CancelSuche As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ChangeSize As ToolStripLabel
End Class
