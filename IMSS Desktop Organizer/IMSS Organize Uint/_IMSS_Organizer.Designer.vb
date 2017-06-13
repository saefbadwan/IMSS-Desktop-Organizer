<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class _IMSS_Organizer
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(_IMSS_Organizer))
        Me._IMSS_From_label = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me._IMSS_ExtntionComboBox = New System.Windows.Forms.ComboBox()
        Me.ButtonX1 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX()
        Me.ButtonX3 = New DevComponents.DotNetBar.ButtonX()
        Me._IMSS_GetTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me._IMSS_ToTextBox = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me._IMSS_SelectPath = New System.Windows.Forms.FolderBrowserDialog()
        Me._IMSS_MainPanel = New DevComponents.DotNetBar.PanelEx()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LabelX2 = New DevComponents.DotNetBar.LabelX()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX()
        Me._IMSS_IncludeSubdirectories_CheckBox = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me._IMSS_ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me._IMSS_MainPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        '_IMSS_From_label
        '
        Me._IMSS_From_label.AutoSize = True
        Me._IMSS_From_label.Location = New System.Drawing.Point(8, 36)
        Me._IMSS_From_label.Name = "_IMSS_From_label"
        Me._IMSS_From_label.Size = New System.Drawing.Size(56, 13)
        Me._IMSS_From_label.TabIndex = 0
        Me._IMSS_From_label.Text = "Get from :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(260, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Send to :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Only with extension : "
        '
        '_IMSS_ExtntionComboBox
        '
        Me._IMSS_ExtntionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me._IMSS_ExtntionComboBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_ExtntionComboBox.FormattingEnabled = True
        Me._IMSS_ExtntionComboBox.Items.AddRange(New Object() {"Image Files |JPEG,JPG,JPE,JFIF,DIB,PPM,PGM,PBM,PNM,PFM,PNG,BMP,GIF,RGBE,TIFF,TIF", "Video Files |3GP,AVI,BDVM,DAT,DVR,FLV,IFO,M2TS,M4V,MKV,MOV,MP4,MPEG,MPG,MTS,OGM,O" & _
                        "GV,QT,RM,SBE,TS,WMV,WTV", "Audio Files |MP3,WMA,WAV,RA,RAM,RM,MIDI,OGG,M4P,M4A,3GP", "Executable Files |BAT,BIN,CMD,COM,CPL,EXE,GADGET,INF1,INS,INX,ISU,JOB,JSE,LNK,MSC" & _
                        ",MSI,MSP,MST,PAF,PIF,PS1,REG,RGS,SCT,SHB,SHS,U3P,VB,VBE,VBS,VBSCRIPT,WS,WSF", "Compressed Files |RAR,ZIP,7Z,TAR,TAR.GZ,TGZ,TAR.Z,TAR.BZ2", "Microsoft Word Files |DOC,DOT,DOCX,DOCM,DOTX,DOTM", "Microsoft  Excel Files |XLSX,XLSM,XLTX,XLTM,XLSB,XLA,XLAM,XLL,XLW", "Microsoft PowerPoint Files |PPT,PPS,PPTX,PPTM,POTX,POTM,PPAM,PPSX,PPSM,SLDX,SLDM", "Microsoft Access Files |ACCDB,ACCDE,ACCDT,ACCDR", "All Microsoft Office Files |DOC,DOT,DOCX,DOCM,DOTX,DOTM,XLSX,XLSM,XLTX,XLTM,XLSB," & _
                        "XLA,XLAM,XLL,XLW,PPT,PPS,PPTX,PPTM,POTX,POTM,PPAM,PPSX,PPSM,SLDX,SLDM,ACCDB,ACCD" & _
                        "E,ACCDT,ACCDR", "Shortcut Files |,lnk", "All Files Without Directories^"})
        Me._IMSS_ExtntionComboBox.Location = New System.Drawing.Point(112, 67)
        Me._IMSS_ExtntionComboBox.Name = "_IMSS_ExtntionComboBox"
        Me._IMSS_ExtntionComboBox.Size = New System.Drawing.Size(338, 23)
        Me._IMSS_ExtntionComboBox.TabIndex = 4
        '
        'ButtonX1
        '
        Me.ButtonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX1.Location = New System.Drawing.Point(186, 31)
        Me.ButtonX1.Name = "ButtonX1"
        Me.ButtonX1.Size = New System.Drawing.Size(68, 23)
        Me.ButtonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX1.TabIndex = 10
        Me.ButtonX1.Text = "Browse"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Location = New System.Drawing.Point(454, 31)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(68, 23)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 11
        Me.ButtonX2.Text = "Browse"
        '
        'ButtonX3
        '
        Me.ButtonX3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX3.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX3.Location = New System.Drawing.Point(454, 66)
        Me.ButtonX3.Name = "ButtonX3"
        Me.ButtonX3.Size = New System.Drawing.Size(68, 23)
        Me.ButtonX3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX3.TabIndex = 12
        Me.ButtonX3.Text = "New..."
        '
        '_IMSS_GetTextBox
        '
        '
        '
        '
        Me._IMSS_GetTextBox.Border.Class = "TextBoxBorder"
        Me._IMSS_GetTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_GetTextBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_GetTextBox.Location = New System.Drawing.Point(66, 32)
        Me._IMSS_GetTextBox.Name = "_IMSS_GetTextBox"
        Me._IMSS_GetTextBox.ReadOnly = True
        Me._IMSS_GetTextBox.Size = New System.Drawing.Size(116, 21)
        Me._IMSS_GetTextBox.TabIndex = 13
        '
        '_IMSS_ToTextBox
        '
        '
        '
        '
        Me._IMSS_ToTextBox.Border.Class = "TextBoxBorder"
        Me._IMSS_ToTextBox.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_ToTextBox.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_ToTextBox.Location = New System.Drawing.Point(318, 32)
        Me._IMSS_ToTextBox.Name = "_IMSS_ToTextBox"
        Me._IMSS_ToTextBox.ReadOnly = True
        Me._IMSS_ToTextBox.Size = New System.Drawing.Size(132, 21)
        Me._IMSS_ToTextBox.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(510, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        '_IMSS_MainPanel
        '
        Me._IMSS_MainPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MainPanel.Controls.Add(Me.Button1)
        Me._IMSS_MainPanel.Controls.Add(Me.Button2)
        Me._IMSS_MainPanel.Controls.Add(Me.LabelX2)
        Me._IMSS_MainPanel.Controls.Add(Me.LabelX1)
        Me._IMSS_MainPanel.Controls.Add(Me.TextBoxX1)
        Me._IMSS_MainPanel.Location = New System.Drawing.Point(0, 106)
        Me._IMSS_MainPanel.Name = "_IMSS_MainPanel"
        Me._IMSS_MainPanel.Size = New System.Drawing.Size(527, 125)
        Me._IMSS_MainPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_MainPanel.Style.BackColor1.Color = System.Drawing.Color.White
        Me._IMSS_MainPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me._IMSS_MainPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_MainPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_MainPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_MainPanel.Style.GradientAngle = 90
        Me._IMSS_MainPanel.TabIndex = 16
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(447, 95)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Complete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(366, 95)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'LabelX2
        '
        Me.LabelX2.AutoSize = True
        '
        '
        '
        Me.LabelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX2.Location = New System.Drawing.Point(228, 4)
        Me.LabelX2.Name = "LabelX2"
        Me.LabelX2.Size = New System.Drawing.Size(91, 15)
        Me.LabelX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.LabelX2.TabIndex = 2
        Me.LabelX2.Text = "exe,gpj,gif,wav,rar"
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(4, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(223, 15)
        Me.LabelX1.TabIndex = 1
        Me.LabelX1.Text = "Write your new files extensions in this format :"
        '
        'TextBoxX1
        '
        '
        '
        '
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX1.Location = New System.Drawing.Point(3, 25)
        Me.TextBoxX1.Multiline = True
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.Size = New System.Drawing.Size(519, 64)
        Me.TextBoxX1.TabIndex = 0
        '
        '_IMSS_IncludeSubdirectories_CheckBox
        '
        Me._IMSS_IncludeSubdirectories_CheckBox.AutoSize = True
        '
        '
        '
        Me._IMSS_IncludeSubdirectories_CheckBox.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_IncludeSubdirectories_CheckBox.Location = New System.Drawing.Point(379, 2)
        Me._IMSS_IncludeSubdirectories_CheckBox.Name = "_IMSS_IncludeSubdirectories_CheckBox"
        Me._IMSS_IncludeSubdirectories_CheckBox.Size = New System.Drawing.Size(127, 15)
        Me._IMSS_IncludeSubdirectories_CheckBox.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_IncludeSubdirectories_CheckBox.TabIndex = 17
        Me._IMSS_IncludeSubdirectories_CheckBox.Text = "Include Subdirectories"
        Me._IMSS_ToolTip.SetToolTip(Me._IMSS_IncludeSubdirectories_CheckBox, "Include all directories in target path")
        '
        '_IMSS_ToolTip
        '
        Me._IMSS_ToolTip.IsBalloon = True
        '
        '_IMSS_Organizer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.IMSS_Desktop_Organizer.My.Resources.Resources._IMSS_Orgniaer_background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Controls.Add(Me._IMSS_IncludeSubdirectories_CheckBox)
        Me.Controls.Add(Me._IMSS_MainPanel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me._IMSS_ToTextBox)
        Me.Controls.Add(Me._IMSS_GetTextBox)
        Me.Controls.Add(Me.ButtonX3)
        Me.Controls.Add(Me.ButtonX2)
        Me.Controls.Add(Me.ButtonX1)
        Me.Controls.Add(Me._IMSS_ExtntionComboBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me._IMSS_From_label)
        Me.Name = "_IMSS_Organizer"
        Me.Size = New System.Drawing.Size(527, 100)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me._IMSS_MainPanel.ResumeLayout(False)
        Me._IMSS_MainPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _IMSS_From_label As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents _IMSS_ExtntionComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ButtonX1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents ButtonX3 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents _IMSS_GetTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents _IMSS_ToTextBox As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_SelectPath As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents _IMSS_MainPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LabelX2 As DevComponents.DotNetBar.LabelX
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents _IMSS_IncludeSubdirectories_CheckBox As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents _IMSS_ToolTip As System.Windows.Forms.ToolTip

End Class
