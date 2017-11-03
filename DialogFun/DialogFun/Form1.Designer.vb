<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnShowMessage = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSaveFile = New System.Windows.Forms.Button()
        Me.txtSaveFile = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnFileToOpen = New System.Windows.Forms.Button()
        Me.txtFileToOpen = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ofdData = New System.Windows.Forms.OpenFileDialog()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.sfdData = New System.Windows.Forms.SaveFileDialog()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pColorFontDialog = New System.Windows.Forms.Panel()
        Me.txtSampleText = New System.Windows.Forms.TextBox()
        Me.btnSetFont = New System.Windows.Forms.Button()
        Me.btnSetColor = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ColorSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ForgroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cdSetColor = New System.Windows.Forms.ColorDialog()
        Me.fdSetFont = New System.Windows.Forms.FontDialog()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.ButtonColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cdButtonColor = New System.Windows.Forms.ColorDialog()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pColorFontDialog.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnShowMessage
        '
        Me.btnShowMessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowMessage.Location = New System.Drawing.Point(103, 57)
        Me.btnShowMessage.Name = "btnShowMessage"
        Me.btnShowMessage.Size = New System.Drawing.Size(216, 23)
        Me.btnShowMessage.TabIndex = 0
        Me.btnShowMessage.Text = "Show Message"
        Me.btnShowMessage.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Location = New System.Drawing.Point(346, 107)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnShowMessage)
        Me.Panel1.Location = New System.Drawing.Point(12, 79)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(426, 135)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(290, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Message Box Botton Example"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.btnSaveFile)
        Me.Panel2.Controls.Add(Me.txtSaveFile)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.btnFileToOpen)
        Me.Panel2.Controls.Add(Me.txtFileToOpen)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Location = New System.Drawing.Point(12, 243)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(424, 170)
        Me.Panel2.TabIndex = 3
        '
        'btnSaveFile
        '
        Me.btnSaveFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveFile.Location = New System.Drawing.Point(339, 100)
        Me.btnSaveFile.Name = "btnSaveFile"
        Me.btnSaveFile.Size = New System.Drawing.Size(60, 23)
        Me.btnSaveFile.TabIndex = 9
        Me.btnSaveFile.Text = "&Save"
        Me.btnSaveFile.UseVisualStyleBackColor = True
        '
        'txtSaveFile
        '
        Me.txtSaveFile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSaveFile.Location = New System.Drawing.Point(110, 100)
        Me.txtSaveFile.Name = "txtSaveFile"
        Me.txtSaveFile.Size = New System.Drawing.Size(219, 20)
        Me.txtSaveFile.TabIndex = 8
        Me.txtSaveFile.Text = "SaveMe.txt"
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 18)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "File to Save"
        '
        'btnFileToOpen
        '
        Me.btnFileToOpen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFileToOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFileToOpen.Location = New System.Drawing.Point(339, 71)
        Me.btnFileToOpen.Name = "btnFileToOpen"
        Me.btnFileToOpen.Size = New System.Drawing.Size(60, 23)
        Me.btnFileToOpen.TabIndex = 6
        Me.btnFileToOpen.Text = "&Open"
        Me.btnFileToOpen.UseVisualStyleBackColor = True
        '
        'txtFileToOpen
        '
        Me.txtFileToOpen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFileToOpen.Location = New System.Drawing.Point(110, 71)
        Me.txtFileToOpen.Name = "txtFileToOpen"
        Me.txtFileToOpen.Size = New System.Drawing.Size(219, 20)
        Me.txtFileToOpen.TabIndex = 5
        Me.txtFileToOpen.Text = "OpenMe.txt"
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "File to Open"
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(84, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(267, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Dialog File Control Example"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(422, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.OpenToolStripMenuItem.Text = "&Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.SaveToolStripMenuItem.Text = "&Save"
        '
        'ofdData
        '
        Me.ofdData.FileName = "OpenFileDialog1"
        Me.ofdData.Filter = "Text Files | *.txt| Word Files | *.doc | Word Files | *.docx |  All Files |*.*"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'sfdData
        '
        Me.sfdData.Filter = "Text Files | *.txt| Word Files | *.doc | Word Files | *.docx |  All Files |*.*"
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(58, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(349, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Playing around with different Dialogs"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'pColorFontDialog
        '
        Me.pColorFontDialog.Controls.Add(Me.txtSampleText)
        Me.pColorFontDialog.Controls.Add(Me.btnSetFont)
        Me.pColorFontDialog.Controls.Add(Me.btnSetColor)
        Me.pColorFontDialog.Controls.Add(Me.Label6)
        Me.pColorFontDialog.Controls.Add(Me.MenuStrip2)
        Me.pColorFontDialog.Location = New System.Drawing.Point(13, 434)
        Me.pColorFontDialog.Name = "pColorFontDialog"
        Me.pColorFontDialog.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.pColorFontDialog.Size = New System.Drawing.Size(424, 312)
        Me.pColorFontDialog.TabIndex = 5
        '
        'txtSampleText
        '
        Me.txtSampleText.BackColor = System.Drawing.SystemColors.Control
        Me.txtSampleText.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSampleText.Location = New System.Drawing.Point(0, 144)
        Me.txtSampleText.Multiline = True
        Me.txtSampleText.Name = "txtSampleText"
        Me.txtSampleText.Size = New System.Drawing.Size(418, 101)
        Me.txtSampleText.TabIndex = 5
        Me.txtSampleText.Text = "My Sample Text"
        Me.txtSampleText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSetFont
        '
        Me.btnSetFont.Location = New System.Drawing.Point(262, 95)
        Me.btnSetFont.Name = "btnSetFont"
        Me.btnSetFont.Size = New System.Drawing.Size(75, 23)
        Me.btnSetFont.TabIndex = 3
        Me.btnSetFont.Text = "Set Font"
        Me.btnSetFont.UseVisualStyleBackColor = True
        '
        'btnSetColor
        '
        Me.btnSetColor.Location = New System.Drawing.Point(82, 95)
        Me.btnSetColor.Name = "btnSetColor"
        Me.btnSetColor.Size = New System.Drawing.Size(75, 23)
        Me.btnSetColor.TabIndex = 2
        Me.btnSetColor.Text = "Set Color"
        Me.btnSetColor.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(61, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(298, 24)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Color and Font Dialog Example"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorSettingsToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(101, 24)
        Me.MenuStrip2.TabIndex = 6
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ColorSettingsToolStripMenuItem
        '
        Me.ColorSettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ForgroundColorToolStripMenuItem, Me.BackgroundColorToolStripMenuItem, Me.ButtonColorToolStripMenuItem})
        Me.ColorSettingsToolStripMenuItem.Name = "ColorSettingsToolStripMenuItem"
        Me.ColorSettingsToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ColorSettingsToolStripMenuItem.Size = New System.Drawing.Size(93, 20)
        Me.ColorSettingsToolStripMenuItem.Text = "Color Settings"
        '
        'ForgroundColorToolStripMenuItem
        '
        Me.ForgroundColorToolStripMenuItem.Name = "ForgroundColorToolStripMenuItem"
        Me.ForgroundColorToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ForgroundColorToolStripMenuItem.Text = "Forground Color"
        '
        'BackgroundColorToolStripMenuItem
        '
        Me.BackgroundColorToolStripMenuItem.Name = "BackgroundColorToolStripMenuItem"
        Me.BackgroundColorToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.BackgroundColorToolStripMenuItem.Text = "Background Color"
        '
        'ButtonColorToolStripMenuItem
        '
        Me.ButtonColorToolStripMenuItem.Name = "ButtonColorToolStripMenuItem"
        Me.ButtonColorToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ButtonColorToolStripMenuItem.Text = "Button Color"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 951)
        Me.Controls.Add(Me.pColorFontDialog)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pColorFontDialog.ResumeLayout(False)
        Me.pColorFontDialog.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnShowMessage As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnFileToOpen As Button
    Friend WithEvents txtFileToOpen As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents ofdData As OpenFileDialog
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents btnSaveFile As Button
    Friend WithEvents txtSaveFile As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents sfdData As SaveFileDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label5 As Label
    Friend WithEvents pColorFontDialog As Panel
    Friend WithEvents btnSetFont As Button
    Friend WithEvents btnSetColor As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents cdSetColor As ColorDialog
    Friend WithEvents fdSetFont As FontDialog
    Friend WithEvents txtSampleText As TextBox
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents ColorSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ForgroundColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents ButtonColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cdButtonColor As ColorDialog
End Class
