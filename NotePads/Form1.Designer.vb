<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Textfeld = New RichTextBox()
        MenuStrip1 = New MenuStrip()
        NotePadsToolStripMenuItem = New ToolStripMenuItem()
        NeuStartenToolStripMenuItem = New ToolStripMenuItem()
        ÜberToolStripMenuItem = New ToolStripMenuItem()
        BeendenToolStripMenuItem = New ToolStripMenuItem()
        DateiToolStripMenuItem = New ToolStripMenuItem()
        NeuesDokumentToolStripMenuItem = New ToolStripMenuItem()
        DokumentÖffnenToolStripMenuItem = New ToolStripMenuItem()
        SichernToolStripMenuItem = New ToolStripMenuItem()
        SichernUnterToolStripMenuItem = New ToolStripMenuItem()
        BearbeitenToolStripMenuItem = New ToolStripMenuItem()
        RückgängigToolStripMenuItem = New ToolStripMenuItem()
        VorgängigToolStripMenuItem = New ToolStripMenuItem()
        AusschneidenToolStripMenuItem = New ToolStripMenuItem()
        EinfügenToolStripMenuItem = New ToolStripMenuItem()
        KopierenToolStripMenuItem = New ToolStripMenuItem()
        AllesAuswählenToolStripMenuItem = New ToolStripMenuItem()
        SuchenToolStripMenuItem = New ToolStripMenuItem()
        EinstellungenToolStripMenuItem = New ToolStripMenuItem()
        AnsichtToolStripMenuItem = New ToolStripMenuItem()
        InfobarZeigenToolStripMenuItem = New ToolStripMenuItem()
        infobar = New Panel()
        Zeilenumbruchmoduswert = New Label()
        Zeichenwert = New Label()
        Zeilenwert = New Label()
        Zeilenumbruchmodus = New Label()
        Zeichen = New Label()
        Zeile = New Label()
        MenuStrip1.SuspendLayout()
        infobar.SuspendLayout()
        SuspendLayout()
        ' 
        ' Textfeld
        ' 
        Textfeld.AcceptsTab = True
        Textfeld.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Textfeld.AutoWordSelection = True
        Textfeld.EnableAutoDragDrop = True
        Textfeld.HideSelection = False
        Textfeld.Location = New Point(9, 34)
        Textfeld.Margin = New Padding(2)
        Textfeld.Name = "Textfeld"
        Textfeld.Size = New Size(664, 438)
        Textfeld.TabIndex = 0
        Textfeld.Text = ""
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.Font = New Font("SamsungOneUILatin 700", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        MenuStrip1.ImageScalingSize = New Size(32, 32)
        MenuStrip1.Items.AddRange(New ToolStripItem() {NotePadsToolStripMenuItem, DateiToolStripMenuItem, BearbeitenToolStripMenuItem, AnsichtToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Padding = New Padding(5, 2, 0, 2)
        MenuStrip1.Size = New Size(682, 33)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' NotePadsToolStripMenuItem
        ' 
        NotePadsToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NeuStartenToolStripMenuItem, ÜberToolStripMenuItem, BeendenToolStripMenuItem})
        NotePadsToolStripMenuItem.Name = "NotePadsToolStripMenuItem"
        NotePadsToolStripMenuItem.Size = New Size(106, 29)
        NotePadsToolStripMenuItem.Text = "NotePads"
        ' 
        ' NeuStartenToolStripMenuItem
        ' 
        NeuStartenToolStripMenuItem.Name = "NeuStartenToolStripMenuItem"
        NeuStartenToolStripMenuItem.Size = New Size(243, 34)
        NeuStartenToolStripMenuItem.Text = "Neu starten"
        ' 
        ' ÜberToolStripMenuItem
        ' 
        ÜberToolStripMenuItem.Name = "ÜberToolStripMenuItem"
        ÜberToolStripMenuItem.Size = New Size(243, 34)
        ÜberToolStripMenuItem.Text = "Über NotePads"
        ' 
        ' BeendenToolStripMenuItem
        ' 
        BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        BeendenToolStripMenuItem.Size = New Size(243, 34)
        BeendenToolStripMenuItem.Text = "Beenden"
        ' 
        ' DateiToolStripMenuItem
        ' 
        DateiToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NeuesDokumentToolStripMenuItem, DokumentÖffnenToolStripMenuItem, SichernToolStripMenuItem, SichernUnterToolStripMenuItem})
        DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        DateiToolStripMenuItem.Size = New Size(71, 29)
        DateiToolStripMenuItem.Text = "Datei"
        ' 
        ' NeuesDokumentToolStripMenuItem
        ' 
        NeuesDokumentToolStripMenuItem.Name = "NeuesDokumentToolStripMenuItem"
        NeuesDokumentToolStripMenuItem.Size = New Size(231, 34)
        NeuesDokumentToolStripMenuItem.Text = "Neu"
        ' 
        ' DokumentÖffnenToolStripMenuItem
        ' 
        DokumentÖffnenToolStripMenuItem.Name = "DokumentÖffnenToolStripMenuItem"
        DokumentÖffnenToolStripMenuItem.Size = New Size(231, 34)
        DokumentÖffnenToolStripMenuItem.Text = "Öffnen"
        ' 
        ' SichernToolStripMenuItem
        ' 
        SichernToolStripMenuItem.Name = "SichernToolStripMenuItem"
        SichernToolStripMenuItem.Size = New Size(231, 34)
        SichernToolStripMenuItem.Text = "Sichern"
        ' 
        ' SichernUnterToolStripMenuItem
        ' 
        SichernUnterToolStripMenuItem.Name = "SichernUnterToolStripMenuItem"
        SichernUnterToolStripMenuItem.Size = New Size(231, 34)
        SichernUnterToolStripMenuItem.Text = "Sichern unter"
        ' 
        ' BearbeitenToolStripMenuItem
        ' 
        BearbeitenToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {RückgängigToolStripMenuItem, VorgängigToolStripMenuItem, AusschneidenToolStripMenuItem, EinfügenToolStripMenuItem, KopierenToolStripMenuItem, AllesAuswählenToolStripMenuItem, SuchenToolStripMenuItem, EinstellungenToolStripMenuItem})
        BearbeitenToolStripMenuItem.Name = "BearbeitenToolStripMenuItem"
        BearbeitenToolStripMenuItem.Size = New Size(117, 29)
        BearbeitenToolStripMenuItem.Text = "Bearbeiten"
        ' 
        ' RückgängigToolStripMenuItem
        ' 
        RückgängigToolStripMenuItem.Name = "RückgängigToolStripMenuItem"
        RückgängigToolStripMenuItem.Size = New Size(255, 34)
        RückgängigToolStripMenuItem.Text = "Rückgängig"
        ' 
        ' VorgängigToolStripMenuItem
        ' 
        VorgängigToolStripMenuItem.Name = "VorgängigToolStripMenuItem"
        VorgängigToolStripMenuItem.Size = New Size(255, 34)
        VorgängigToolStripMenuItem.Text = "Vorgängig"
        ' 
        ' AusschneidenToolStripMenuItem
        ' 
        AusschneidenToolStripMenuItem.Name = "AusschneidenToolStripMenuItem"
        AusschneidenToolStripMenuItem.Size = New Size(255, 34)
        AusschneidenToolStripMenuItem.Text = "Ausschneiden"
        ' 
        ' EinfügenToolStripMenuItem
        ' 
        EinfügenToolStripMenuItem.Name = "EinfügenToolStripMenuItem"
        EinfügenToolStripMenuItem.Size = New Size(255, 34)
        EinfügenToolStripMenuItem.Text = "Einfügen"
        ' 
        ' KopierenToolStripMenuItem
        ' 
        KopierenToolStripMenuItem.Name = "KopierenToolStripMenuItem"
        KopierenToolStripMenuItem.Size = New Size(255, 34)
        KopierenToolStripMenuItem.Text = "Kopieren"
        ' 
        ' AllesAuswählenToolStripMenuItem
        ' 
        AllesAuswählenToolStripMenuItem.Name = "AllesAuswählenToolStripMenuItem"
        AllesAuswählenToolStripMenuItem.Size = New Size(255, 34)
        AllesAuswählenToolStripMenuItem.Text = "Alles auswählen"
        ' 
        ' SuchenToolStripMenuItem
        ' 
        SuchenToolStripMenuItem.Name = "SuchenToolStripMenuItem"
        SuchenToolStripMenuItem.Size = New Size(255, 34)
        SuchenToolStripMenuItem.Text = "Suchen"
        ' 
        ' EinstellungenToolStripMenuItem
        ' 
        EinstellungenToolStripMenuItem.Name = "EinstellungenToolStripMenuItem"
        EinstellungenToolStripMenuItem.Size = New Size(255, 34)
        EinstellungenToolStripMenuItem.Text = "Einstellungen"
        ' 
        ' AnsichtToolStripMenuItem
        ' 
        AnsichtToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {InfobarZeigenToolStripMenuItem})
        AnsichtToolStripMenuItem.Name = "AnsichtToolStripMenuItem"
        AnsichtToolStripMenuItem.Size = New Size(88, 29)
        AnsichtToolStripMenuItem.Text = "Ansicht"
        ' 
        ' InfobarZeigenToolStripMenuItem
        ' 
        InfobarZeigenToolStripMenuItem.Checked = True
        InfobarZeigenToolStripMenuItem.CheckOnClick = True
        InfobarZeigenToolStripMenuItem.CheckState = CheckState.Checked
        InfobarZeigenToolStripMenuItem.Name = "InfobarZeigenToolStripMenuItem"
        InfobarZeigenToolStripMenuItem.Size = New Size(236, 34)
        InfobarZeigenToolStripMenuItem.Text = "Infobar zeigen"
        ' 
        ' infobar
        ' 
        infobar.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        infobar.Controls.Add(Zeilenumbruchmoduswert)
        infobar.Controls.Add(Zeichenwert)
        infobar.Controls.Add(Zeilenwert)
        infobar.Controls.Add(Zeilenumbruchmodus)
        infobar.Controls.Add(Zeichen)
        infobar.Controls.Add(Zeile)
        infobar.Location = New Point(9, 470)
        infobar.Margin = New Padding(2)
        infobar.Name = "infobar"
        infobar.Size = New Size(663, 39)
        infobar.TabIndex = 2
        ' 
        ' Zeilenumbruchmoduswert
        ' 
        Zeilenumbruchmoduswert.AutoSize = True
        Zeilenumbruchmoduswert.Location = New Point(552, 3)
        Zeilenumbruchmoduswert.Margin = New Padding(2, 0, 2, 0)
        Zeilenumbruchmoduswert.Name = "Zeilenumbruchmoduswert"
        Zeilenumbruchmoduswert.Size = New Size(26, 25)
        Zeilenumbruchmoduswert.TabIndex = 5
        Zeilenumbruchmoduswert.Text = "--"
        ' 
        ' Zeichenwert
        ' 
        Zeichenwert.AutoSize = True
        Zeichenwert.Location = New Point(237, 3)
        Zeichenwert.Margin = New Padding(2, 0, 2, 0)
        Zeichenwert.Name = "Zeichenwert"
        Zeichenwert.Size = New Size(26, 25)
        Zeichenwert.TabIndex = 4
        Zeichenwert.Text = "--"
        ' 
        ' Zeilenwert
        ' 
        Zeilenwert.AutoSize = True
        Zeilenwert.Location = New Point(65, 3)
        Zeilenwert.Margin = New Padding(2, 0, 2, 0)
        Zeilenwert.Name = "Zeilenwert"
        Zeilenwert.Size = New Size(26, 25)
        Zeilenwert.TabIndex = 3
        Zeilenwert.Text = "--"
        ' 
        ' Zeilenumbruchmodus
        ' 
        Zeilenumbruchmodus.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Zeilenumbruchmodus.AutoSize = True
        Zeilenumbruchmodus.Location = New Point(352, 3)
        Zeilenumbruchmodus.Margin = New Padding(2, 0, 2, 0)
        Zeilenumbruchmodus.Name = "Zeilenumbruchmodus"
        Zeilenumbruchmodus.Size = New Size(193, 25)
        Zeilenumbruchmodus.TabIndex = 2
        Zeilenumbruchmodus.Text = "Zeilenumbruchmodus:"
        ' 
        ' Zeichen
        ' 
        Zeichen.AutoSize = True
        Zeichen.Location = New Point(152, 3)
        Zeichen.Margin = New Padding(2, 0, 2, 0)
        Zeichen.Name = "Zeichen"
        Zeichen.Size = New Size(80, 25)
        Zeichen.TabIndex = 1
        Zeichen.Text = "Zeichen:"
        ' 
        ' Zeile
        ' 
        Zeile.AutoSize = True
        Zeile.Location = New Point(0, 2)
        Zeile.Margin = New Padding(2, 0, 2, 0)
        Zeile.Name = "Zeile"
        Zeile.Size = New Size(62, 25)
        Zeile.TabIndex = 0
        Zeile.Text = "Zeile: "
        ' 
        ' Form1
        ' 
        AllowDrop = True
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(682, 503)
        Controls.Add(infobar)
        Controls.Add(Textfeld)
        Controls.Add(MenuStrip1)
        Font = New Font("SamsungOneUILatin 700", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        KeyPreview = True
        MainMenuStrip = MenuStrip1
        Margin = New Padding(2)
        Name = "Form1"
        Text = "NotePads | Neu"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        infobar.ResumeLayout(False)
        infobar.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Textfeld As RichTextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents NotePadsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NeuStartenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DateiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NeuesDokumentToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DokumentÖffnenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SichernToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SichernUnterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BearbeitenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RückgängigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VorgängigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AusschneidenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EinfügenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KopierenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AllesAuswählenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuchenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnsichtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InfobarZeigenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Zeilenumbruchmoduswert As Label
    Friend WithEvents Zeichenwert As Label
    Friend WithEvents Zeilenumbruchmodus As Label
    Friend WithEvents Zeichen As Label
    Friend WithEvents Zeile As Label
    Friend WithEvents infobar As Panel
    Friend WithEvents Zeilenwert As Label
    Friend WithEvents ÜberToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EinstellungenToolStripMenuItem As ToolStripMenuItem

End Class
