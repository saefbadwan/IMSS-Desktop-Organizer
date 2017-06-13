Imports DevComponents.DotNetBar
Imports DevComponents.DotNetBar.Controls

Public Class MainWindow
    Private _IMSS_TotalMoveFiles As Integer = 0
#Region "IMSS Main start GUI"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _IMSS_Main_FlowLayout.Size = New Size(551, 541)
        _IMSS_Main_FlowLayout.Location = New Point(3, 3)
        _IMSS_Main_FlowLayout.BringToFront()
        _IMSS_SetupFirstRun()
        _IMSS_checkControls()
    End Sub
    Private Sub _IMSS_SetupFirstRun()
        For i As Integer = 1 To 4 Step 1
            Dim _IMSS_NewOrginazer As New _IMSS_Organizer
            Select Case i
                Case 1
                    _IMSS_NewOrginazer._IMSS_GetTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                    _IMSS_NewOrginazer._IMSS_ToTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Pictures Folder"
                    _IMSS_NewOrginazer._IMSS_ExtntionComboBox.SelectedIndex = 0
                    Exit Select
                Case 2
                    _IMSS_NewOrginazer._IMSS_GetTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                    _IMSS_NewOrginazer._IMSS_ToTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Videos Folder"
                    _IMSS_NewOrginazer._IMSS_ExtntionComboBox.SelectedIndex = 1
                    Exit Select
                Case 3
                    _IMSS_NewOrginazer._IMSS_GetTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                    _IMSS_NewOrginazer._IMSS_ToTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Music Folder"
                    _IMSS_NewOrginazer._IMSS_ExtntionComboBox.SelectedIndex = 2
                    Exit Select
                Case 4
                    _IMSS_NewOrginazer._IMSS_GetTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                    _IMSS_NewOrginazer._IMSS_ToTextBox.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Executable Folder"
                    _IMSS_NewOrginazer._IMSS_ExtntionComboBox.SelectedIndex = 3
                Case Else
                    Exit Select
            End Select
            _IMSS_Main_FlowLayout.Controls.Add(_IMSS_NewOrginazer)
        Next i
    End Sub
    Private Sub _IMSS_checkControls()
        If _IMSS_Main_FlowLayout.Controls.Count() > 0 Then
            _IMSS_Organize.Enabled = True
        Else
            _IMSS_Organize.Enabled = False
        End If
    End Sub
    Private Sub _IMSS_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Close.Click
        Try : If _IMSS_MainThread.IsAlive = True Then _IMSS_MainThread.Abort()
        Catch : End Try
        Application.Exit()
    End Sub

    Private Sub _IMSS_AddOrganizerButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_AddOrganizerButton.Click
        Dim _IMSS_NewOrginazer As New _IMSS_Organizer
        _IMSS_Main_FlowLayout.Controls.Add(_IMSS_NewOrginazer)
        _IMSS_checkControls()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_ClearAll_Button.Click
        _IMSS_Main_FlowLayout.Controls.Clear()
        _IMSS_checkControls()
    End Sub
    Private Sub _IMSS_SetupFormAndPanelAndButtons()
        _IMSS_Main_FlowLayout.Visible = False
        _IMSS_MainPanel.BringToFront()
        _IMSS_AddOrganizerButton.Visible = False
        _IMSS_ClearAll_Button.Visible = False
        _IMSS_Close.Text = "Cancel"
        _IMSS_StepIndicator.StepCount = _IMSS_Main_FlowLayout.Controls.Count()
        _IMSS_Organize.Visible = False
        _IMSS_Close.Location = New Point(457, 10)
        Me.Height = Me.Height / 2
        Me.MaximumSize = Me.Size
    End Sub
    Private _IMSS_MainThread As New Threading.Thread(AddressOf _IMSS_MainStart)
    Private Sub _IMSS_Organize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles _IMSS_Organize.Click
        _IMSS_SetupFormAndPanelAndButtons()
        For Each _IMSS_OrgnizerUint As _IMSS_Organizer In _IMSS_Main_FlowLayout.Controls
            If _IMSS_OrgnizerUint._IMSS_CheckControReady() = True Then
                _IMSS_OrgnizerUint._IMSS_ControlKey = True
            Else
                _IMSS_OrgnizerUint._IMSS_ControlKey = False
            End If
        Next _IMSS_OrgnizerUint
        ' IMSS Start background Thraed Worker
        _IMSS_MainThread.Priority = Threading.ThreadPriority.Highest
        _IMSS_MainThread.Start()
    End Sub
#End Region

#Region "IMSS Start Orgnizer Uint"
    Private _IMSS_TextCatgory As String = String.Empty
    Private Sub _IMSS_MainStart()
        For Each _IMSS_OrgnizerUint As _IMSS_Organizer In _IMSS_Main_FlowLayout.Controls
            _IMSS_StepIndicator.CurrentStep += 1
            If _IMSS_OrgnizerUint._IMSS_ControlKey = True Then
                _IMSS_ChecngeLabelText(Me._IMSS_From_Label, _IMSS_OrgnizerUint._IMSS_GetTextFrom())
                _IMSS_ChecngeLabelText(Me._IMSS_SendTo_label, _IMSS_OrgnizerUint._IMSS_GetTextSendTo())
                _IMSS_SetSelectedValue(_IMSS_OrgnizerUint._IMSS_ExtntionComboBox)
                If _IMSS_TextCatgory.Contains("|") Then
                    Dim _IMSS_ListArry() As String = _IMSS_TextCatgory.Split("|")
                    _IMSS_ProcessDirectorys(_IMSS_OrgnizerUint._IMSS_GetTextFrom(), _IMSS_ListArry(1).Split(","), _IMSS_OrgnizerUint._IMSS_GetTextSendTo(), _IMSS_CheckIncludeSubdirectories(_IMSS_OrgnizerUint._IMSS_IncludeSubdirectories_CheckBox), False)
                ElseIf _IMSS_TextCatgory.Contains("^") Then
                    _IMSS_ProcessDirectorys(_IMSS_OrgnizerUint._IMSS_GetTextFrom(), _IMSS_TextCatgory.Split(","), _IMSS_OrgnizerUint._IMSS_GetTextSendTo(), _IMSS_CheckIncludeSubdirectories(_IMSS_OrgnizerUint._IMSS_IncludeSubdirectories_CheckBox), True)
                Else
                    _IMSS_ProcessDirectorys(_IMSS_OrgnizerUint._IMSS_GetTextFrom(), _IMSS_TextCatgory.Split(","), _IMSS_OrgnizerUint._IMSS_GetTextSendTo(), _IMSS_CheckIncludeSubdirectories(_IMSS_OrgnizerUint._IMSS_IncludeSubdirectories_CheckBox), False)
                End If
            End If
        Next _IMSS_OrgnizerUint
        ' IMSS On Complete Items
        _IMSS_ChangeFormStatus()
        MessageBox.Show(_IMSS_TotalMoveFiles & " has been moved to their target", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Application.Exit()
    End Sub
    Private Function _IMSS_CheckIncludeSubdirectories(ByRef _IMSS_CheckBox As CheckBoxX) As Boolean
        If _IMSS_CheckBox.Checked = True Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub _IMSS_ProcessDirectorys(ByVal targetDirectory As String, ByVal _IMSS_Extntions As String(), _
                                        ByVal _IMSS_MoveTo As String, ByVal _IMSS_IncludeSubdirectoriesVar As Boolean, ByVal _IMSS_AllFile As Boolean)
        Try
            Dim fileEntries As String() = IO.Directory.GetFiles(targetDirectory, "*.*")
            ' Process the list of files found in the directory. 
            Dim fileName As String
            For Each fileName In fileEntries
                For Each _IMSS_Extntion In _IMSS_Extntions
                    If Not _IMSS_AllFile = True Then
                        Dim _IMSS_ExtntionVar As String = IO.Path.GetExtension(fileName)
                        If Not _IMSS_ExtntionVar.Length = 0 Then
                            If _IMSS_ExtntionVar.Replace(".", "").ToUpper() = _IMSS_Extntion Then
                                _IMSS_ProcessFile(fileName, _IMSS_MoveTo)
                            End If
                        End If
                    Else
                        _IMSS_ProcessFile(fileName, _IMSS_MoveTo)
                    End If
                Next _IMSS_Extntion
            Next fileName
        Catch
            Exit Sub
        End Try
        If _IMSS_IncludeSubdirectoriesVar = True Then
            Dim subdirectoryEntries As String() = IO.Directory.GetDirectories(targetDirectory)
            ' Recurse into subdirectories of this directory. 
            Dim subdirectory As String
            For Each subdirectory In subdirectoryEntries
                _IMSS_ProcessDirectorys(subdirectory, _IMSS_Extntions, _IMSS_MoveTo, _IMSS_IncludeSubdirectoriesVar, _IMSS_AllFile)
            Next subdirectory
        End If
    End Sub 'ProcessDirectory

    Private Sub _IMSS_ProcessFile(ByVal _IMSS_FileName As String, ByVal _IMSS_MoveFileTo As String)
        _IMSS_ChecngeLabelText(_IMSS_CurrentOutPut_Label, _IMSS_FileName)
        Dim _IMSS_FileInfo As New IO.FileInfo(_IMSS_FileName)
        If Not IO.Directory.Exists(_IMSS_MoveFileTo) Then IO.Directory.CreateDirectory(_IMSS_MoveFileTo)
        Try
            _IMSS_FileInfo.MoveTo(IO.Path.Combine(_IMSS_MoveFileTo, _IMSS_FileInfo.Name))
            _IMSS_TotalMoveFiles += 1
        Catch : End Try
    End Sub
#Region "IMSS Delgates Controls Uint"
    Private Delegate Sub _IMSS_ChecngeLabelTextDelegate(ByRef _IMSS_LABEl As LabelX, ByVal _IMSS_Text As String)
    Private Sub _IMSS_ChecngeLabelText(ByRef _IMSS_LABEl As LabelX, ByVal _IMSS_Text As String)
        If _IMSS_LABEl.InvokeRequired = True Then
            _IMSS_LABEl.Invoke(New _IMSS_ChecngeLabelTextDelegate(AddressOf _IMSS_ChecngeLabelText), _IMSS_LABEl, _IMSS_Text)
        Else
            _IMSS_LABEl.Text = _IMSS_Text
        End If
    End Sub
    Private Delegate Sub _IMSS_ReturnSelectedValueDelegate(ByRef _IMSS_ExtntionComboBox As ComboBox)
    Private Sub _IMSS_SetSelectedValue(ByRef _IMSS_ExtntionComboBox As ComboBox)
        If _IMSS_ExtntionComboBox.InvokeRequired = True Then
            _IMSS_ExtntionComboBox.Invoke(New _IMSS_ReturnSelectedValueDelegate(AddressOf _IMSS_SetSelectedValue), _IMSS_ExtntionComboBox)
        Else
            _IMSS_TextCatgory = _IMSS_ExtntionComboBox.SelectedItem
        End If
    End Sub
    Private Delegate Sub _IMSS_ChangeFormStatusDelegate()
    Private Sub _IMSS_ChangeFormStatus()
        If Me.InvokeRequired = True Then
            Me.Invoke(New _IMSS_ChangeFormStatusDelegate(AddressOf _IMSS_ChangeFormStatus))
        Else
            Me.WindowState = FormWindowState.Minimized
        End If
    End Sub
#End Region
#End Region

End Class
