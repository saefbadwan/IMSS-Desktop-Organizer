<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainWindow))
        Me._IMSS_FooterPanel = New DevComponents.DotNetBar.PanelEx()
        Me._IMSS_Main_FlowLayout = New System.Windows.Forms.FlowLayoutPanel()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_From_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_SendTo_label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_ProgressBar = New System.Windows.Forms.ProgressBar()
        Me._IMSS_StepIndicator = New DevComponents.DotNetBar.Controls.StepIndicator()
        Me._IMSS_CurrentOutPut_Label = New DevComponents.DotNetBar.LabelX()
        Me._IMSS_MainPanel = New DevComponents.DotNetBar.PanelEx()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me._IMSS_Loading_PictureBox = New System.Windows.Forms.PictureBox()
        Me._IMSS_ClearAll_Button = New DevComponents.DotNetBar.ButtonX()
        Me._IMSS_AddOrganizerButton = New DevComponents.DotNetBar.ButtonX()
        Me._IMSS_Close = New System.Windows.Forms.Button()
        Me._IMSS_Organize = New System.Windows.Forms.Button()
        Me._IMSS_FooterPanel.SuspendLayout()
        Me._IMSS_MainPanel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._IMSS_Loading_PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_IMSS_FooterPanel
        '
        Me._IMSS_FooterPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_FooterPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_FooterPanel.Controls.Add(Me._IMSS_ClearAll_Button)
        Me._IMSS_FooterPanel.Controls.Add(Me._IMSS_AddOrganizerButton)
        Me._IMSS_FooterPanel.Controls.Add(Me._IMSS_Close)
        Me._IMSS_FooterPanel.Controls.Add(Me._IMSS_Organize)
        Me._IMSS_FooterPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me._IMSS_FooterPanel.Location = New System.Drawing.Point(0, 550)
        Me._IMSS_FooterPanel.Name = "_IMSS_FooterPanel"
        Me._IMSS_FooterPanel.Size = New System.Drawing.Size(557, 49)
        Me._IMSS_FooterPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_FooterPanel.Style.BackColor1.Color = System.Drawing.Color.White
        Me._IMSS_FooterPanel.Style.BackColor2.Color = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._IMSS_FooterPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_FooterPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_FooterPanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Top
        Me._IMSS_FooterPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_FooterPanel.Style.GradientAngle = 90
        Me._IMSS_FooterPanel.TabIndex = 0
        '
        '_IMSS_Main_FlowLayout
        '
        Me._IMSS_Main_FlowLayout.AutoScroll = True
        Me._IMSS_Main_FlowLayout.Location = New System.Drawing.Point(535, 534)
        Me._IMSS_Main_FlowLayout.Name = "_IMSS_Main_FlowLayout"
        Me._IMSS_Main_FlowLayout.Size = New System.Drawing.Size(10, 10)
        Me._IMSS_Main_FlowLayout.TabIndex = 1
        '
        'LabelX1
        '
        Me.LabelX1.AutoSize = True
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Location = New System.Drawing.Point(24, 12)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(328, 15)
        Me.LabelX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me.LabelX1.TabIndex = 2
        Me.LabelX1.Text = "Please wait while IMSS Desktop Organizer orgnize your target lists ..."
        '
        '_IMSS_From_Label
        '
        Me._IMSS_From_Label.AutoSize = True
        '
        '
        '
        Me._IMSS_From_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_From_Label.Location = New System.Drawing.Point(46, 76)
        Me._IMSS_From_Label.Name = "_IMSS_From_Label"
        Me._IMSS_From_Label.Size = New System.Drawing.Size(34, 15)
        Me._IMSS_From_Label.TabIndex = 3
        Me._IMSS_From_Label.Text = "From :"
        '
        '_IMSS_SendTo_label
        '
        Me._IMSS_SendTo_label.AutoSize = True
        '
        '
        '
        Me._IMSS_SendTo_label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_SendTo_label.Location = New System.Drawing.Point(269, 76)
        Me._IMSS_SendTo_label.Name = "_IMSS_SendTo_label"
        Me._IMSS_SendTo_label.Size = New System.Drawing.Size(41, 15)
        Me._IMSS_SendTo_label.TabIndex = 4
        Me._IMSS_SendTo_label.Text = "Send To"
        '
        '_IMSS_ProgressBar
        '
        Me._IMSS_ProgressBar.Location = New System.Drawing.Point(24, 97)
        Me._IMSS_ProgressBar.MarqueeAnimationSpeed = 4
        Me._IMSS_ProgressBar.Name = "_IMSS_ProgressBar"
        Me._IMSS_ProgressBar.Size = New System.Drawing.Size(521, 19)
        Me._IMSS_ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me._IMSS_ProgressBar.TabIndex = 5
        '
        '_IMSS_StepIndicator
        '
        Me._IMSS_StepIndicator.CurrentStep = 0
        Me._IMSS_StepIndicator.Location = New System.Drawing.Point(24, 123)
        Me._IMSS_StepIndicator.Name = "_IMSS_StepIndicator"
        Me._IMSS_StepIndicator.Size = New System.Drawing.Size(521, 4)
        Me._IMSS_StepIndicator.TabIndex = 6
        '
        '_IMSS_CurrentOutPut_Label
        '
        '
        '
        '
        Me._IMSS_CurrentOutPut_Label.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me._IMSS_CurrentOutPut_Label.Location = New System.Drawing.Point(46, 133)
        Me._IMSS_CurrentOutPut_Label.Name = "_IMSS_CurrentOutPut_Label"
        Me._IMSS_CurrentOutPut_Label.Size = New System.Drawing.Size(499, 92)
        Me._IMSS_CurrentOutPut_Label.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003
        Me._IMSS_CurrentOutPut_Label.TabIndex = 7
        Me._IMSS_CurrentOutPut_Label.TextLineAlignment = System.Drawing.StringAlignment.Near
        Me._IMSS_CurrentOutPut_Label.WordWrap = True
        '
        '_IMSS_MainPanel
        '
        Me._IMSS_MainPanel.CanvasColor = System.Drawing.SystemColors.Control
        Me._IMSS_MainPanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_MainPanel.Controls.Add(Me.PictureBox2)
        Me._IMSS_MainPanel.Controls.Add(Me.PictureBox1)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_Loading_PictureBox)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_CurrentOutPut_Label)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_StepIndicator)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_ProgressBar)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_SendTo_label)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_From_Label)
        Me._IMSS_MainPanel.Controls.Add(Me.LabelX1)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_Main_FlowLayout)
        Me._IMSS_MainPanel.Controls.Add(Me._IMSS_FooterPanel)
        Me._IMSS_MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me._IMSS_MainPanel.Location = New System.Drawing.Point(0, 0)
        Me._IMSS_MainPanel.Name = "_IMSS_MainPanel"
        Me._IMSS_MainPanel.Size = New System.Drawing.Size(557, 599)
        Me._IMSS_MainPanel.Style.Alignment = System.Drawing.StringAlignment.Center
        Me._IMSS_MainPanel.Style.BackColor1.Color = System.Drawing.Color.White
        Me._IMSS_MainPanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me._IMSS_MainPanel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me._IMSS_MainPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me._IMSS_MainPanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.None
        Me._IMSS_MainPanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me._IMSS_MainPanel.Style.GradientAngle = 90
        Me._IMSS_MainPanel.TabIndex = 0
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.IMSS_Desktop_Organizer.My.Resources.Resources._IMSS_SendTo_Icon_16x16
        Me.PictureBox2.Location = New System.Drawing.Point(247, 76)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.IMSS_Desktop_Organizer.My.Resources.Resources._IMSS_From_Icon_16x16
        Me.PictureBox1.Location = New System.Drawing.Point(24, 76)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        '_IMSS_Loading_PictureBox
        '
        Me._IMSS_Loading_PictureBox.Image = Global.IMSS_Desktop_Organizer.My.Resources.Resources._IMSS_LoadimgGif_Icon
        Me._IMSS_Loading_PictureBox.Location = New System.Drawing.Point(24, 133)
        Me._IMSS_Loading_PictureBox.Name = "_IMSS_Loading_PictureBox"
        Me._IMSS_Loading_PictureBox.Size = New System.Drawing.Size(16, 16)
        Me._IMSS_Loading_PictureBox.TabIndex = 8
        Me._IMSS_Loading_PictureBox.TabStop = False
        '
        '_IMSS_ClearAll_Button
        '
        Me._IMSS_ClearAll_Button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_ClearAll_Button.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_ClearAll_Button.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!)
        Me._IMSS_ClearAll_Button.Image = Global.IMSS_Desktop_Organizer.My.Resources.Resources._IMSS_Refresh_Icon_16x16
        Me._IMSS_ClearAll_Button.Location = New System.Drawing.Point(129, 10)
        Me._IMSS_ClearAll_Button.Name = "_IMSS_ClearAll_Button"
        Me._IMSS_ClearAll_Button.Size = New System.Drawing.Size(79, 32)
        Me._IMSS_ClearAll_Button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_ClearAll_Button.TabIndex = 3
        Me._IMSS_ClearAll_Button.Text = "Clear All"
        '
        '_IMSS_AddOrganizerButton
        '
        Me._IMSS_AddOrganizerButton.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me._IMSS_AddOrganizerButton.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me._IMSS_AddOrganizerButton.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!)
        Me._IMSS_AddOrganizerButton.Image = Global.IMSS_Desktop_Organizer.My.Resources.Resources._IMSS_RegeditAdd_MainIcon_16x16
        Me._IMSS_AddOrganizerButton.Location = New System.Drawing.Point(12, 10)
        Me._IMSS_AddOrganizerButton.Name = "_IMSS_AddOrganizerButton"
        Me._IMSS_AddOrganizerButton.Size = New System.Drawing.Size(111, 32)
        Me._IMSS_AddOrganizerButton.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me._IMSS_AddOrganizerButton.TabIndex = 2
        Me._IMSS_AddOrganizerButton.Text = "Add Organizer"
        '
        '_IMSS_Close
        '
        Me._IMSS_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_Close.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!)
        Me._IMSS_Close.Image = Global.IMSS_Desktop_Organizer.My.Resources.Resources._IMSS_DeleteButton_Icon_16x16
        Me._IMSS_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._IMSS_Close.Location = New System.Drawing.Point(324, 10)
        Me._IMSS_Close.Name = "_IMSS_Close"
        Me._IMSS_Close.Size = New System.Drawing.Size(88, 32)
        Me._IMSS_Close.TabIndex = 1
        Me._IMSS_Close.Text = "Close"
        Me._IMSS_Close.UseVisualStyleBackColor = True
        '
        '_IMSS_Organize
        '
        Me._IMSS_Organize.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._IMSS_Organize.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._IMSS_Organize.Image = Global.IMSS_Desktop_Organizer.My.Resources.Resources._IMSS_Run
        Me._IMSS_Organize.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me._IMSS_Organize.Location = New System.Drawing.Point(418, 10)
        Me._IMSS_Organize.Name = "_IMSS_Organize"
        Me._IMSS_Organize.Size = New System.Drawing.Size(127, 32)
        Me._IMSS_Organize.TabIndex = 0
        Me._IMSS_Organize.Text = "Start Organizer"
        Me._IMSS_Organize.UseVisualStyleBackColor = True
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(557, 599)
        Me.Controls.Add(Me._IMSS_MainPanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(573, 637)
        Me.Name = "MainWindow"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "IMSS Desktop Organizer"
        Me.TopMost = True
        Me._IMSS_FooterPanel.ResumeLayout(False)
        Me._IMSS_MainPanel.ResumeLayout(False)
        Me._IMSS_MainPanel.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._IMSS_Loading_PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents _IMSS_FooterPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents _IMSS_ClearAll_Button As DevComponents.DotNetBar.ButtonX
    Friend WithEvents _IMSS_AddOrganizerButton As DevComponents.DotNetBar.ButtonX
    Friend WithEvents _IMSS_Close As System.Windows.Forms.Button
    Friend WithEvents _IMSS_Organize As System.Windows.Forms.Button
    Friend WithEvents _IMSS_Main_FlowLayout As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_From_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_SendTo_label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_ProgressBar As System.Windows.Forms.ProgressBar
    Friend WithEvents _IMSS_StepIndicator As DevComponents.DotNetBar.Controls.StepIndicator
    Friend WithEvents _IMSS_CurrentOutPut_Label As DevComponents.DotNetBar.LabelX
    Friend WithEvents _IMSS_Loading_PictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents _IMSS_MainPanel As DevComponents.DotNetBar.PanelEx
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
