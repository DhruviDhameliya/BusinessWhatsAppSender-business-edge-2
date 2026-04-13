<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ButtonForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ButtonForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBody = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFooter = New System.Windows.Forms.TextBox()
        Me.grpButtonType = New System.Windows.Forms.GroupBox()
        Me.txtActionLabel3 = New System.Windows.Forms.TextBox()
        Me.txtActionLabel2 = New System.Windows.Forms.TextBox()
        Me.txtActionLabel1 = New System.Windows.Forms.TextBox()
        Me.txtActionValue3 = New System.Windows.Forms.TextBox()
        Me.txtActionValue2 = New System.Windows.Forms.TextBox()
        Me.txtActionValue1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbActionType3 = New System.Windows.Forms.ComboBox()
        Me.cmbActionType2 = New System.Windows.Forms.ComboBox()
        Me.cmbActionType1 = New System.Windows.Forms.ComboBox()
        Me.txtReply3 = New System.Windows.Forms.TextBox()
        Me.txtReply2 = New System.Windows.Forms.TextBox()
        Me.txtReply1 = New System.Windows.Forms.TextBox()
        Me.cmbReply3 = New System.Windows.Forms.ComboBox()
        Me.cmbReply2 = New System.Windows.Forms.ComboBox()
        Me.rbActionButtons = New System.Windows.Forms.RadioButton()
        Me.rbReplyButtons = New System.Windows.Forms.RadioButton()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.cmbReply1 = New System.Windows.Forms.ComboBox()
        Me.grpButtonType.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 19)
        Me.Label1.TabIndex = 0
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(47, 39)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(322, 20)
        Me.txtTitle.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Body"
        '
        'txtBody
        '
        Me.txtBody.Location = New System.Drawing.Point(47, 94)
        Me.txtBody.Multiline = True
        Me.txtBody.Name = "txtBody"
        Me.txtBody.Size = New System.Drawing.Size(322, 47)
        Me.txtBody.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Footer"
        '
        'txtFooter
        '
        Me.txtFooter.Location = New System.Drawing.Point(47, 170)
        Me.txtFooter.Name = "txtFooter"
        Me.txtFooter.Size = New System.Drawing.Size(322, 20)
        Me.txtFooter.TabIndex = 8
        '
        'grpButtonType
        '
        Me.grpButtonType.Controls.Add(Me.cmbReply1)
        Me.grpButtonType.Controls.Add(Me.txtActionLabel3)
        Me.grpButtonType.Controls.Add(Me.txtActionLabel2)
        Me.grpButtonType.Controls.Add(Me.txtActionLabel1)
        Me.grpButtonType.Controls.Add(Me.txtActionValue3)
        Me.grpButtonType.Controls.Add(Me.txtActionValue2)
        Me.grpButtonType.Controls.Add(Me.txtActionValue1)
        Me.grpButtonType.Controls.Add(Me.Label7)
        Me.grpButtonType.Controls.Add(Me.Label6)
        Me.grpButtonType.Controls.Add(Me.Label5)
        Me.grpButtonType.Controls.Add(Me.cmbActionType3)
        Me.grpButtonType.Controls.Add(Me.cmbActionType2)
        Me.grpButtonType.Controls.Add(Me.cmbActionType1)
        Me.grpButtonType.Controls.Add(Me.txtReply3)
        Me.grpButtonType.Controls.Add(Me.txtReply2)
        Me.grpButtonType.Controls.Add(Me.txtReply1)
        Me.grpButtonType.Controls.Add(Me.cmbReply3)
        Me.grpButtonType.Controls.Add(Me.cmbReply2)
        Me.grpButtonType.Controls.Add(Me.rbActionButtons)
        Me.grpButtonType.Controls.Add(Me.rbReplyButtons)
        Me.grpButtonType.Location = New System.Drawing.Point(44, 196)
        Me.grpButtonType.Name = "grpButtonType"
        Me.grpButtonType.Size = New System.Drawing.Size(322, 306)
        Me.grpButtonType.TabIndex = 9
        Me.grpButtonType.TabStop = False
        '
        'txtActionLabel3
        '
        Me.txtActionLabel3.Location = New System.Drawing.Point(127, 273)
        Me.txtActionLabel3.Name = "txtActionLabel3"
        Me.txtActionLabel3.Size = New System.Drawing.Size(189, 20)
        Me.txtActionLabel3.TabIndex = 19
        '
        'txtActionLabel2
        '
        Me.txtActionLabel2.Location = New System.Drawing.Point(127, 227)
        Me.txtActionLabel2.Name = "txtActionLabel2"
        Me.txtActionLabel2.Size = New System.Drawing.Size(189, 20)
        Me.txtActionLabel2.TabIndex = 18
        '
        'txtActionLabel1
        '
        Me.txtActionLabel1.Location = New System.Drawing.Point(127, 180)
        Me.txtActionLabel1.Name = "txtActionLabel1"
        Me.txtActionLabel1.Size = New System.Drawing.Size(189, 20)
        Me.txtActionLabel1.TabIndex = 17
        '
        'txtActionValue3
        '
        Me.txtActionValue3.Location = New System.Drawing.Point(127, 251)
        Me.txtActionValue3.Name = "txtActionValue3"
        Me.txtActionValue3.Size = New System.Drawing.Size(189, 20)
        Me.txtActionValue3.TabIndex = 16
        '
        'txtActionValue2
        '
        Me.txtActionValue2.Location = New System.Drawing.Point(127, 205)
        Me.txtActionValue2.Name = "txtActionValue2"
        Me.txtActionValue2.Size = New System.Drawing.Size(189, 20)
        Me.txtActionValue2.TabIndex = 15
        '
        'txtActionValue1
        '
        Me.txtActionValue1.Location = New System.Drawing.Point(127, 157)
        Me.txtActionValue1.Name = "txtActionValue1"
        Me.txtActionValue1.Size = New System.Drawing.Size(189, 20)
        Me.txtActionValue1.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(88, 275)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Label"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(88, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Label"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(88, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Label"
        '
        'cmbActionType3
        '
        Me.cmbActionType3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbActionType3.Enabled = False
        Me.cmbActionType3.FormattingEnabled = True
        Me.cmbActionType3.Items.AddRange(New Object() {"Phone Number", "URL"})
        Me.cmbActionType3.Location = New System.Drawing.Point(6, 251)
        Me.cmbActionType3.Name = "cmbActionType3"
        Me.cmbActionType3.Size = New System.Drawing.Size(115, 21)
        Me.cmbActionType3.TabIndex = 10
        Me.cmbActionType3.SelectedItem = "Phone Number"
        '
        'cmbActionType2
        '
        Me.cmbActionType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbActionType2.Enabled = False
        Me.cmbActionType2.FormattingEnabled = True
        Me.cmbActionType2.Items.AddRange(New Object() {"Phone Number", "URL"})
        Me.cmbActionType2.Location = New System.Drawing.Point(6, 205)
        Me.cmbActionType2.Name = "cmbActionType2"
        Me.cmbActionType2.Size = New System.Drawing.Size(115, 21)
        Me.cmbActionType2.TabIndex = 9
        Me.cmbActionType2.SelectedItem = "Phone Number"

        '
        'cmbActionType1
        '
        Me.cmbActionType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbActionType1.Enabled = False
        Me.cmbActionType1.FormattingEnabled = True
        Me.cmbActionType1.Items.AddRange(New Object() {"Phone Number", "URL"})
        Me.cmbActionType1.Location = New System.Drawing.Point(6, 156)
        Me.cmbActionType1.Name = "cmbActionType1"
        Me.cmbActionType1.Size = New System.Drawing.Size(115, 21)
        Me.cmbActionType1.TabIndex = 8
        Me.cmbActionType1.SelectedItem = "Phone Number"

        '
        'txtReply3
        '
        Me.txtReply3.Location = New System.Drawing.Point(127, 98)
        Me.txtReply3.Name = "txtReply3"
        Me.txtReply3.Size = New System.Drawing.Size(189, 20)
        Me.txtReply3.TabIndex = 7
        '
        'txtReply2
        '
        Me.txtReply2.Location = New System.Drawing.Point(127, 72)
        Me.txtReply2.Name = "txtReply2"
        Me.txtReply2.Size = New System.Drawing.Size(189, 20)
        Me.txtReply2.TabIndex = 6
        '
        'txtReply1
        '
        Me.txtReply1.Location = New System.Drawing.Point(127, 43)
        Me.txtReply1.Name = "txtReply1"
        Me.txtReply1.Size = New System.Drawing.Size(189, 20)
        Me.txtReply1.TabIndex = 5
        '
        'cmbReply3
        '
        Me.cmbReply3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReply3.FormattingEnabled = True
        Me.cmbReply3.Items.AddRange(New Object() {"Reply", "Code"})
        Me.cmbReply3.Location = New System.Drawing.Point(6, 97)
        Me.cmbReply3.Name = "cmbReply3"
        Me.cmbReply3.Size = New System.Drawing.Size(115, 21)
        Me.cmbReply3.TabIndex = 4
        Me.cmbReply3.SelectedItem = "Reply"
        '
        'cmbReply2
        '
        Me.cmbReply2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReply2.FormattingEnabled = True
        Me.cmbReply2.Items.AddRange(New Object() {"Reply", "Code"})
        Me.cmbReply2.Location = New System.Drawing.Point(6, 70)
        Me.cmbReply2.Name = "cmbReply2"
        Me.cmbReply2.Size = New System.Drawing.Size(115, 21)
        Me.cmbReply2.TabIndex = 3
        Me.cmbReply2.SelectedItem = "Reply"
        '
        'rbActionButtons
        '
        Me.rbActionButtons.AutoSize = True
        Me.rbActionButtons.Checked = True
        Me.rbActionButtons.Location = New System.Drawing.Point(6, 133)
        Me.rbActionButtons.Name = "rbActionButtons"
        Me.rbActionButtons.Size = New System.Drawing.Size(94, 17)
        Me.rbActionButtons.TabIndex = 1
        Me.rbActionButtons.TabStop = True
        Me.rbActionButtons.Text = "Action Buttons"
        Me.rbActionButtons.UseVisualStyleBackColor = True
        '
        'rbReplyButtons
        '
        Me.rbReplyButtons.AutoSize = True
        Me.rbReplyButtons.Location = New System.Drawing.Point(9, 20)
        Me.rbReplyButtons.Name = "rbReplyButtons"
        Me.rbReplyButtons.Size = New System.Drawing.Size(91, 17)
        Me.rbReplyButtons.TabIndex = 0
        Me.rbReplyButtons.Text = "Reply Buttons"
        Me.rbReplyButtons.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(210, 508)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(294, 508)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 10
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'cmbReply1
        '
        Me.cmbReply1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReply1.FormattingEnabled = True
        Me.cmbReply1.Items.AddRange(New Object() {"Reply", "Code"})
        Me.cmbReply1.Location = New System.Drawing.Point(6, 43)
        Me.cmbReply1.Name = "cmbReply1"
        Me.cmbReply1.Size = New System.Drawing.Size(115, 21)
        Me.cmbReply1.TabIndex = 20
        Me.cmbReply1.SelectedItem = "Reply"
        '
        'ButtonForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(415, 548)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.grpButtonType)
        Me.Controls.Add(Me.txtFooter)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBody)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTitle)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ButtonForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buttons"
        Me.grpButtonType.ResumeLayout(False)
        Me.grpButtonType.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBody As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtFooter As TextBox
    Friend WithEvents grpButtonType As GroupBox
    Friend WithEvents rbActionButtons As RadioButton
    Friend WithEvents rbReplyButtons As RadioButton
    Friend WithEvents cmbReply3 As ComboBox
    Friend WithEvents cmbReply2 As ComboBox
    Friend WithEvents txtReply3 As TextBox
    Friend WithEvents txtReply2 As TextBox
    Friend WithEvents txtReply1 As TextBox
    Friend WithEvents txtActionLabel3 As TextBox
    Friend WithEvents txtActionLabel2 As TextBox
    Friend WithEvents txtActionLabel1 As TextBox
    Friend WithEvents txtActionValue3 As TextBox
    Friend WithEvents txtActionValue2 As TextBox
    Friend WithEvents txtActionValue1 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cmbActionType3 As ComboBox
    Friend WithEvents cmbActionType2 As ComboBox
    Friend WithEvents cmbActionType1 As ComboBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents cmbReply1 As ComboBox
End Class
