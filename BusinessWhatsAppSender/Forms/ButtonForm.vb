Imports Newtonsoft.Json
Imports System.IO

Public Class ButtonForm

    Public Class ButtonData
        Public Property ButtonType As String
        Public Property Value As String
        Public Property Text As String
    End Class

    Public Class FormData
        Public Property title As String
        Public Property footer As String
        Public Property body As String
        Public Property isReply As Boolean
        Public Property buttons As List(Of ButtonData)
    End Class
    Private Sub rbReplyButtons_CheckedChanged(sender As Object, e As EventArgs) Handles rbReplyButtons.CheckedChanged
        ' Enable Reply Buttons and disable Action Buttons
        cmbReply1.Enabled = rbReplyButtons.Checked
        cmbReply2.Enabled = rbReplyButtons.Checked
        cmbReply3.Enabled = rbReplyButtons.Checked
        txtReply1.Enabled = rbReplyButtons.Checked
        txtReply2.Enabled = rbReplyButtons.Checked
        txtReply3.Enabled = rbReplyButtons.Checked

        cmbActionType1.Enabled = Not rbReplyButtons.Checked
        txtActionValue1.Enabled = Not rbReplyButtons.Checked
        txtActionLabel1.Enabled = Not rbReplyButtons.Checked
        cmbActionType2.Enabled = Not rbReplyButtons.Checked
        txtActionValue2.Enabled = Not rbReplyButtons.Checked
        txtActionLabel2.Enabled = Not rbReplyButtons.Checked
        cmbActionType3.Enabled = Not rbReplyButtons.Checked
        txtActionValue3.Enabled = Not rbReplyButtons.Checked
        txtActionLabel3.Enabled = Not rbReplyButtons.Checked
    End Sub

    Private Sub rbActionButtons_CheckedChanged(sender As Object, e As EventArgs) Handles rbActionButtons.CheckedChanged
        ' Enable Action Buttons and disable Reply Buttons
        cmbReply1.Enabled = Not rbActionButtons.Checked
        cmbReply2.Enabled = Not rbActionButtons.Checked
        cmbReply3.Enabled = Not rbActionButtons.Checked
        txtReply1.Enabled = Not rbActionButtons.Checked
        txtReply2.Enabled = Not rbActionButtons.Checked
        txtReply3.Enabled = Not rbActionButtons.Checked

        cmbActionType1.Enabled = rbActionButtons.Checked
        txtActionValue1.Enabled = rbActionButtons.Checked
        txtActionLabel1.Enabled = rbActionButtons.Checked
        cmbActionType2.Enabled = rbActionButtons.Checked
        txtActionValue2.Enabled = rbActionButtons.Checked
        txtActionLabel2.Enabled = rbActionButtons.Checked
        cmbActionType3.Enabled = rbActionButtons.Checked
        txtActionValue3.Enabled = rbActionButtons.Checked
        txtActionLabel3.Enabled = rbActionButtons.Checked
    End Sub
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        ' Collect data and close the form
        Dim title As String = txtTitle.Text
        Dim body As String = txtBody.Text
        Dim footer As String = txtFooter.Text

        If Not title <> "" Then
            MsgBox("Please Enter Title", vbCritical, Application.ProductName)
            Exit Sub
        End If
        If Not footer <> "" Then
            MsgBox("Please Enter Footer", vbCritical, Application.ProductName)
            Exit Sub
        End If
        If rbReplyButtons.Checked AndAlso
        (String.IsNullOrWhiteSpace(txtReply1.Text) AndAlso String.IsNullOrWhiteSpace(txtReply2.Text) AndAlso String.IsNullOrWhiteSpace(txtReply3.Text)) Then
            MsgBox("Please Enter atleast one Reply", vbCritical, Application.ProductName)
            Exit Sub
        End If
        If rbActionButtons.Checked AndAlso
        (String.IsNullOrWhiteSpace(txtActionValue1.Text) AndAlso String.IsNullOrWhiteSpace(txtActionValue2.Text) AndAlso String.IsNullOrWhiteSpace(txtActionValue3.Text)) Then
            MsgBox("Please Enter atleast one Action", vbCritical, Application.ProductName)
            Exit Sub
        End If

        ' Handle the button values based on the selected options
        SaveFormData()


        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub SaveFormData()
        ' Create a FormData object and populate it with data from form fields
        Dim data As New FormData With {
            .title = txtTitle.Text,
            .footer = txtFooter.Text,
            .body = txtBody.Text,
            .isReply = rbReplyButtons.Checked,
            .buttons = New List(Of ButtonData)()
        }

        ' Add button data based on selection
        If rbReplyButtons.Checked Then
            data.buttons.Add(New ButtonData With {.ButtonType = cmbReply1.Text, .Value = txtReply1.Text, .Text = txtReply1.Text})
            data.buttons.Add(New ButtonData With {.ButtonType = cmbReply2.Text, .Value = txtReply2.Text, .Text = txtReply2.Text})
            data.buttons.Add(New ButtonData With {.ButtonType = cmbReply3.Text, .Value = txtReply3.Text, .Text = txtReply3.Text})
        Else
            data.buttons.Add(New ButtonData With {.ButtonType = cmbActionType1.Text, .Value = txtActionValue1.Text, .Text = txtActionLabel1.Text})
            data.buttons.Add(New ButtonData With {.ButtonType = cmbActionType2.Text, .Value = txtActionValue2.Text, .Text = txtActionLabel2.Text})
            data.buttons.Add(New ButtonData With {.ButtonType = cmbActionType3.Text, .Value = txtActionValue3.Text, .Text = txtActionLabel3.Text})
        End If

        ' Serialize the data to JSON and save to file
        Dim json As String = JsonConvert.SerializeObject(data, Formatting.Indented)
        File.WriteAllText(ClsSpecialDirectories.ButtonsFolder & "buttonDataTest.json", json)
    End Sub

    Private Sub LoadFormData()
        If File.Exists(ClsSpecialDirectories.ButtonsFolder & "buttonDataTest.json") Then
            Dim json As String = File.ReadAllText(ClsSpecialDirectories.ButtonsFolder & "buttonDataTest.json")
            Dim data As FormData = JsonConvert.DeserializeObject(Of FormData)(json)

            txtTitle.Text = data.title
            txtBody.Text = data.body
            txtFooter.Text = data.footer
            rbReplyButtons.Checked = data.isReply
            rbActionButtons.Checked = Not data.isReply

            ' Load button data
            If data.isReply Then
                txtReply1.Text = data.buttons.ElementAtOrDefault(0)?.Value
                cmbReply1.Text = data.buttons.ElementAtOrDefault(0)?.Text
                txtReply2.Text = data.buttons.ElementAtOrDefault(1)?.Value
                cmbReply2.Text = data.buttons.ElementAtOrDefault(1)?.Text
                txtReply3.Text = data.buttons.ElementAtOrDefault(2)?.Value
                cmbReply3.Text = data.buttons.ElementAtOrDefault(2)?.Text
            Else
                cmbActionType1.Text = data.buttons.ElementAtOrDefault(0)?.ButtonType
                txtActionValue1.Text = data.buttons.ElementAtOrDefault(0)?.Value
                txtActionLabel1.Text = data.buttons.ElementAtOrDefault(0)?.Text
                cmbActionType2.Text = data.buttons.ElementAtOrDefault(1)?.ButtonType
                txtActionValue2.Text = data.buttons.ElementAtOrDefault(1)?.Value
                txtActionLabel2.Text = data.buttons.ElementAtOrDefault(1)?.Text
                cmbActionType3.Text = data.buttons.ElementAtOrDefault(2)?.ButtonType
                txtActionValue3.Text = data.buttons.ElementAtOrDefault(2)?.Value
                txtActionLabel3.Text = data.buttons.ElementAtOrDefault(2)?.Text
            End If
        End If
    End Sub

    Private Sub ButtonForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data from JSON file on form load
        LoadFormData()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class

