Public Class _IMSS_Organizer
    Public _IMSS_ControlKey As Boolean = False
#Region "IMSS GUI Handels Uint"
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Dispose()
    End Sub

    Private Sub ButtonX1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX1.Click
        If _IMSS_SelectPath.ShowDialog() = DialogResult.OK Then
            _IMSS_GetTextBox.Text = _IMSS_SelectPath.SelectedPath
        End If
    End Sub

    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX2.Click
        If _IMSS_SelectPath.ShowDialog() = DialogResult.OK Then
            _IMSS_ToTextBox.Text = _IMSS_SelectPath.SelectedPath
        End If
    End Sub

    Private Sub ButtonX3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonX3.Click
        Me.Height += 131
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Height = 100
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If _IMSS_CheckLine(Me.TextBoxX1) = True Then
            _IMSS_ExtntionComboBox.Items.Clear()
            Me.TextBoxX1.Text = _IMSS_ClearString(Me.TextBoxX1.Text).Replace(" ", "")
            _IMSS_ExtntionComboBox.Items.AddRange(TextBoxX1.Lines)
            _IMSS_ExtntionComboBox.SelectedIndex = 0
            Me.Height = 100
        End If
    End Sub
    Private Function _IMSS_CheckLine(ByRef _IMSS_TextBox As TextBox) As Boolean
        If _IMSS_TextBox.Text.Length > 0 Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function _IMSS_ClearString(ByVal _IMSS_VALUE As String) As String
        Try
            Dim illegalChars As Char() = "!@#$%^&*(){}[]''""+<>?\/".ToCharArray()
            Dim sb As New System.Text.StringBuilder
            For Each ch As Char In _IMSS_VALUE
                If Array.IndexOf(illegalChars, ch) = -1 Then
                    sb.Append(ch)
                End If
            Next
            If sb(sb.Length - 1) = "," Then
                If Not sb.ToString().Remove(sb.ToString().Length - 1).ToUpper().Contains(",") Then
                    Return "," & sb.ToString().Remove(sb.ToString().Length - 1).ToUpper()
                Else
                    Return sb.ToString().Remove(sb.ToString().Length - 1).ToUpper()
                End If
            Else
                If Not sb.ToString().ToUpper().Contains(",") Then
                    Return "," & sb.ToString().ToUpper()
                Else
                    Return sb.ToString().ToUpper()
                End If
            End If
        Catch : Return _IMSS_VALUE : End Try
    End Function

    Private Sub TextBoxX1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBoxX1.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub
#End Region

#Region "IMSS Read Controls"

    Public ReadOnly Property _IMSS_CheckControReady As String
        Get
            If _IMSS_CheckControl() = True Then
                Return True
            Else
                Return False
            End If
        End Get
    End Property
    Private Function _IMSS_CheckControl() As Boolean
        Try
            ' If Not IO.Directory.Exists(_IMSS_ToTextBox.Text) Then IO.Directory.CreateDirectory(_IMSS_ToTextBox.Text)
            If IO.Directory.Exists(_IMSS_GetTextBox.Text) And Not _IMSS_ExtntionComboBox.SelectionLength > 0 Then
                Return True
            Else
                Return False
            End If
        Catch : Return False : End Try
    End Function
    Public ReadOnly Property _IMSS_GetTextFrom As String
        Get
            Return _IMSS_GetTextBox.Text
        End Get
    End Property
    Public ReadOnly Property _IMSS_GetTextSendTo As String
        Get
            Return _IMSS_ToTextBox.Text
        End Get
    End Property
    Private _IMSS_SelctedvalueText As String
    Public ReadOnly Property _IMSS_GetSelectedExtntion As String
        Get
            Return _IMSS_SelctedvalueText
        End Get
    End Property

#End Region

End Class
