Imports Newtonsoft.Json
Imports WhatsAppBusinessMarketingSoftware.ClsButtonConfig

Public Class FrmAutoReplyButtonConfig

    Public ButtonConfigData As ButtonConfigData
    Public ButtonListData As LabelRootObject
    Public IsRule As Boolean = False

    Private itemCount As Integer = 0
    Private itemControls As New List(Of Tuple(Of TextBox, TextBox, Button))
    Private textBoxCount As Integer = 0
    Private textBoxList As New List(Of TextBox)

    Private Sub rbReplyButtons_CheckedChanged(sender As Object, e As EventArgs) Handles rbReplyButtons.CheckedChanged
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

    Private Sub LoadListBtnData()
        If ButtonListData IsNot Nothing Then
            Dim myObject As LabelRootObject = ButtonListData
            listBtnLabel.Text = If(myObject.buttonText, "")
            listBtnDescription.Text = If(myObject.description, "")
            sectionTitle.Text = If(myObject.sections(0).title, "")
            flowLayoutPanelItems.Controls.Clear()
            itemControls.Clear()

            For Each section In myObject.sections
                sectionTitle.Text = section.title
                For Each row In section.rows
                    AddItemControls(row.title, row.description)
                Next
            Next
        Else
            listBtnLabel.Text = ""
            listBtnDescription.Text = ""
            sectionTitle.Text = ""
            flowLayoutPanelItems.Controls.Clear()
            itemControls.Clear()
        End If
    End Sub

    Private Sub LoadFormData()
        If ButtonConfigData IsNot Nothing Then
            Dim data As ButtonConfigData = ButtonConfigData
            txtTitle.Text = data.title
            txtBody.Text = data.body
            txtFooter.Text = data.footer
            rbReplyButtons.Checked = data.isReply
            rbActionButtons.Checked = Not data.isReply

            If data.isReply Then
                txtReply1.Text = data.buttons.ElementAtOrDefault(0)?.Value
                cmbReply1.SelectedItem = data.buttons.ElementAtOrDefault(0)?.ButtonType
                txtReply2.Text = data.buttons.ElementAtOrDefault(1)?.Value
                cmbReply2.SelectedItem = data.buttons.ElementAtOrDefault(1)?.ButtonType
                txtReply3.Text = data.buttons.ElementAtOrDefault(2)?.Value
                cmbReply3.SelectedItem = data.buttons.ElementAtOrDefault(2)?.ButtonType
                cmbActionType1.SelectedItem = "Phone Number"
                txtActionValue1.Text = ""
                txtActionLabel1.Text = ""
                cmbActionType2.SelectedItem = "Phone Number"
                txtActionValue2.Text = ""
                txtActionLabel2.Text = ""
                cmbActionType3.SelectedItem = "Phone Number"
                txtActionValue3.Text = ""
                txtActionLabel3.Text = ""
            Else
                txtReply1.Text = ""
                cmbReply1.SelectedItem = "Reply"
                txtReply2.Text = ""
                cmbReply2.SelectedItem = "Reply"
                txtReply3.Text = ""
                cmbReply3.SelectedItem = "Reply"
                cmbActionType1.SelectedItem = data.buttons.ElementAtOrDefault(0)?.ButtonType
                txtActionValue1.Text = data.buttons.ElementAtOrDefault(0)?.Value
                txtActionLabel1.Text = data.buttons.ElementAtOrDefault(0)?.Text
                cmbActionType2.SelectedItem = data.buttons.ElementAtOrDefault(1)?.ButtonType
                txtActionValue2.Text = data.buttons.ElementAtOrDefault(1)?.Value
                txtActionLabel2.Text = data.buttons.ElementAtOrDefault(1)?.Text
                cmbActionType3.SelectedItem = data.buttons.ElementAtOrDefault(2)?.ButtonType
                txtActionValue3.Text = data.buttons.ElementAtOrDefault(2)?.Value
                txtActionLabel3.Text = data.buttons.ElementAtOrDefault(2)?.Text
            End If
        Else
            txtTitle.Text = ""
            txtBody.Text = ""
            txtFooter.Text = ""
            rbReplyButtons.Checked = False
            rbActionButtons.Checked = True

            txtReply1.Text = ""
            cmbReply1.SelectedItem = "Reply"
            txtReply2.Text = ""
            cmbReply2.SelectedItem = "Reply"
            txtReply3.Text = ""
            cmbReply3.SelectedItem = "Reply"

            cmbActionType1.SelectedItem = "Phone Number"
            txtActionValue1.Text = ""
            txtActionLabel1.Text = ""
            cmbActionType2.SelectedItem = "Phone Number"
            txtActionValue2.Text = ""
            txtActionLabel2.Text = ""
            cmbActionType3.SelectedItem = "Phone Number"
            txtActionValue3.Text = ""
            txtActionLabel3.Text = ""
        End If
    End Sub

    Private Sub FrmButtonConfig_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        customBtnTab.SelectedIndex = 0
        LoadFormData()
        LoadListBtnData()
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ButtonConfigData = Nothing
        ButtonListData = Nothing
        IsRule = False
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        ' Collect data and close the form
        Dim title As String = txtTitle.Text
        Dim body As String = txtBody.Text
        Dim footer As String = txtFooter.Text

        If Not body <> "" Then
            MsgBox("Please Enter Body", vbCritical, Application.ProductName)
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
        SaveFormData()

        'Dim btnLabel As String = listBtnLabel.Text
        'Dim description As String = listBtnDescription.Text
        'Dim sectionTitleValue As String = sectionTitle.Text

        'If Not btnLabel <> "" Then
        '    MsgBox("Please Enter Button Label", vbCritical, Application.ProductName)
        '    Exit Sub
        'End If
        'If Not description <> "" Then
        '    MsgBox("Please Enter Message", vbCritical, Application.ProductName)
        '    Exit Sub
        'End If
        'If Not sectionTitleValue <> "" Then
        '    MsgBox("Please Enter Section Title", vbCritical, Application.ProductName)
        '    Exit Sub
        'End If
        'Dim allEmpty As Boolean = True
        'If btnLabel.Length > 30 Then
        '    MessageBox.Show("Value in Button Label exceeds 30 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Exit Sub
        'End If
        'If sectionTitleValue.Length > 30 Then
        '    MessageBox.Show("Value in Section Title exceeds 30 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    Exit Sub
        'End If
        'For i As Integer = 1 To 10
        '    Dim textBoxName As String = "btnList" & i.ToString()
        '    Dim textBox As TextBox = Me.Controls.Find(textBoxName, True).FirstOrDefault()

        '    If textBox IsNot Nothing Then
        '        If Not String.IsNullOrWhiteSpace(textBox.Text) Then
        '            allEmpty = False

        '            If textBox.Text.Length > 30 Then
        '                MessageBox.Show($"Value in Item{i} exceeds 30 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '                Exit Sub
        '            End If
        '        End If
        '    End If
        'Next
        'SaveListBtnData()

        ButtonConfigData = Nothing
        ButtonListData = Nothing
        IsRule = False
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub


    Private Sub SaveFormData()
        ' Create a FormData object and populate it with data from form fields
        Dim data As New ButtonConfigData With {
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
        If IsRule Then
            FrmRules.Rule.ButtonConfigData = data
        Else
            FrmAutoReply.AutoReplayData.ButtonConfigData = data
        End If
    End Sub

    Private Sub SaveListBtnData()
        Dim btnLabel As String = listBtnLabel.Text
        Dim description As String = listBtnDescription.Text
        Dim sections As New List(Of LabelSection)

        For Each itemPanel In flowLayoutPanelItems.Controls.OfType(Of FlowLayoutPanel)()
            Dim titleControl As TextBox = itemPanel.Controls.OfType(Of TextBox)().FirstOrDefault()
            Dim descriptionControl As TextBox = itemPanel.Controls.OfType(Of TextBox)().ElementAtOrDefault(1)

            If titleControl IsNot Nothing AndAlso Not String.IsNullOrWhiteSpace(titleControl.Text) Then
                Dim sectionTitleValue As String = sectionTitle.Text
                Dim existingSection = sections.FirstOrDefault(Function(s) s.title = sectionTitleValue)

                If existingSection Is Nothing Then
                    existingSection = New LabelSection With {
                    .title = sectionTitleValue,
                    .rows = New List(Of LabelRow)
                }
                    sections.Add(existingSection)
                End If

                existingSection.rows.Add(New LabelRow With {
                .rowId = "id_" & (existingSection.rows.Count + 1).ToString(),
                .title = titleControl.Text,
                .description = descriptionControl?.Text
            })
            End If
        Next
        Dim rootObject As New LabelRootObject With {
        .buttonText = btnLabel,
        .description = description,
        .sections = sections
        }

        If IsRule Then
            FrmRules.Rule.ButtonListData = rootObject
        Else
            FrmAutoReply.AutoReplayData.ButtonListData = rootObject
        End If
    End Sub

    Private Sub ButtonEmoji_Click(sender As Object, e As EventArgs) Handles ButtonEmoji.Click
        Process.Start("https://www.emojicopy.com/")
    End Sub

    Private Sub BtnBold_Click(sender As Object, e As EventArgs) Handles BtnBold.Click
        TextControl(txtBody, "*")
    End Sub

    Private Sub TextControl(ByRef txt As TextBox, ByVal TxtChar As String)
        On Error Resume Next
        Dim CurrentIndex As Integer = txt.SelectionStart
        Dim CurrentLenght As Integer = txt.SelectionLength
        txt.Text = txt.Text.Insert(CurrentIndex, TxtChar)
        txt.Text = txt.Text.Insert(CurrentIndex + CurrentLenght + 1, TxtChar)
    End Sub

    Private Sub BtnItalic_Click(sender As Object, e As EventArgs) Handles BtnItalic.Click
        TextControl(txtBody, "_")
    End Sub

    Private Sub BtnStrike_Click(sender As Object, e As EventArgs) Handles BtnStrike.Click
        TextControl(txtBody, "~")
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        AddItemControls("", "")
    End Sub

    Private Sub AddItemControls(itemText As String, descriptionText As String)
        Dim itemPanel As New FlowLayoutPanel() With {
        .AutoSize = True,
        .AutoSizeMode = AutoSizeMode.GrowAndShrink,
        .BorderStyle = BorderStyle.FixedSingle,
        .FlowDirection = FlowDirection.TopDown,
        .WrapContents = False,
        .Padding = New Padding(8, 5, 8, 5),
        .Width = 550
    }

        Dim lblItem As New Label() With {
        .Text = "Title:",
        .Width = 170,
        .Margin = New Padding(2, 1, 2, 0)
    }

        Dim txtItem As New TextBox() With {
        .Width = 270,
        .Text = itemText,
        .Margin = New Padding(2, 0, 2, 2)
    }

        Dim lblDescription As New Label() With {
        .Text = "Description:",
        .Width = 70,
        .Margin = New Padding(2, 1, 2, 0)
    }


        Dim txtDescription As New TextBox() With {
        .Width = 270,
        .Multiline = True,
        .Height = 35,
        .Text = descriptionText,
        .Margin = New Padding(4, 0, 2, 2),
        .ScrollBars = ScrollBars.Vertical
    }

        Dim btnDelete As New Button() With {
        .Text = "Delete",
        .Size = New Size(75, 24),
        .Margin = New Padding(2, 0, 2, 2),
        .Anchor = AnchorStyles.Right
    }

        AddHandler btnDelete.Click, Sub(sender As Object, e As EventArgs)
                                        flowLayoutPanelItems.Controls.Remove(itemPanel)
                                        itemControls.Remove(New Tuple(Of TextBox, TextBox, Button)(txtItem, txtDescription, btnDelete))
                                        itemCount -= 1
                                    End Sub

        itemPanel.Controls.Add(lblItem)
        itemPanel.Controls.Add(txtItem)
        itemPanel.Controls.Add(lblDescription)
        itemPanel.Controls.Add(txtDescription)
        itemPanel.Controls.Add(btnDelete)

        flowLayoutPanelItems.Controls.Add(itemPanel)

        itemControls.Add(New Tuple(Of TextBox, TextBox, Button)(txtItem, txtDescription, btnDelete))
        itemCount += 1
    End Sub

    Private Sub okListBtn_Click(sender As Object, e As EventArgs) Handles okListBtn.Click
        Dim btnLabel As String = listBtnLabel.Text
        Dim description As String = listBtnDescription.Text
        Dim sectionTitleValue As String = sectionTitle.Text

        If Not btnLabel <> "" Then
            MsgBox("Please Enter Button Label", vbCritical, Application.ProductName)
            Exit Sub
        End If
        If Not description <> "" Then
            MsgBox("Please Enter Message", vbCritical, Application.ProductName)
            Exit Sub
        End If
        If Not sectionTitleValue <> "" Then
            MsgBox("Please Enter Section Title", vbCritical, Application.ProductName)
            Exit Sub
        End If
        Dim allEmpty As Boolean = True
        If btnLabel.Length > 30 Then
            MessageBox.Show("Value in Button Label exceeds 30 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        If sectionTitleValue.Length > 30 Then
            MessageBox.Show("Value in Section Title exceeds 30 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        For i As Integer = 1 To 10
            Dim textBoxName As String = "btnList" & i.ToString()
            Dim textBox As TextBox = Me.Controls.Find(textBoxName, True).FirstOrDefault()

            If textBox IsNot Nothing Then
                If Not String.IsNullOrWhiteSpace(textBox.Text) Then
                    allEmpty = False

                    If textBox.Text.Length > 30 Then
                        MessageBox.Show($"Value in Item{i} exceeds 30 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                End If
            End If
        Next
        SaveListBtnData()

        ButtonConfigData = Nothing
        ButtonListData = Nothing
        IsRule = False
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub CancelListBtn_Click(sender As Object, e As EventArgs) Handles CancelListBtn.Click
        ButtonConfigData = Nothing
        ButtonListData = Nothing
        IsRule = False
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub
End Class