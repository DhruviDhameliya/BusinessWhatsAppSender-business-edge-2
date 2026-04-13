<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAutoReplyButtonConfig
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAutoReplyButtonConfig))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBody = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFooter = New System.Windows.Forms.TextBox()
        Me.grpButtonType = New System.Windows.Forms.GroupBox()
        Me.cmbReply1 = New System.Windows.Forms.ComboBox()
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
        Me.customBtnTab = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ButtonEmoji = New System.Windows.Forms.Button()
        Me.BtnStrike = New System.Windows.Forms.Button()
        Me.BtnItalic = New System.Windows.Forms.Button()
        Me.BtnBold = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.flowLayoutPanelItems = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.sectionTitle = New System.Windows.Forms.TextBox()
        Me.sectionTitleLabel = New System.Windows.Forms.Label()
        Me.listBtnDescription = New System.Windows.Forms.TextBox()
        Me.descriptionLabel = New System.Windows.Forms.Label()
        Me.listBtnLabel = New System.Windows.Forms.TextBox()
        Me.btnLabel = New System.Windows.Forms.Label()
        Me.okListBtn = New System.Windows.Forms.Button()
        Me.CancelListBtn = New System.Windows.Forms.Button()
        Me.grpButtonType.SuspendLayout()
        Me.customBtnTab.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
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
        Me.txtTitle.Location = New System.Drawing.Point(30, 32)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(322, 20)
        Me.txtTitle.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Body"
        '
        'txtBody
        '
        Me.txtBody.Location = New System.Drawing.Point(30, 87)
        Me.txtBody.Multiline = True
        Me.txtBody.Name = "txtBody"
        Me.txtBody.Size = New System.Drawing.Size(322, 47)
        Me.txtBody.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Footer"
        '
        'txtFooter
        '
        Me.txtFooter.Location = New System.Drawing.Point(30, 178)
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
        Me.grpButtonType.Location = New System.Drawing.Point(30, 219)
        Me.grpButtonType.Name = "grpButtonType"
        Me.grpButtonType.Size = New System.Drawing.Size(322, 306)
        Me.grpButtonType.TabIndex = 9
        Me.grpButtonType.TabStop = False
        '
        'cmbReply1
        '
        Me.cmbReply1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReply1.FormattingEnabled = True
        Me.cmbReply1.Items.AddRange(New Object() {"Reply", "Code"})
        Me.cmbReply1.Location = New System.Drawing.Point(7, 43)
        Me.cmbReply1.Name = "cmbReply1"
        Me.cmbReply1.Size = New System.Drawing.Size(115, 21)
        Me.cmbReply1.TabIndex = 20
        '
        'txtActionLabel3
        '
        Me.txtActionLabel3.Location = New System.Drawing.Point(128, 273)
        Me.txtActionLabel3.Name = "txtActionLabel3"
        Me.txtActionLabel3.Size = New System.Drawing.Size(189, 20)
        Me.txtActionLabel3.TabIndex = 19
        '
        'txtActionLabel2
        '
        Me.txtActionLabel2.Location = New System.Drawing.Point(128, 227)
        Me.txtActionLabel2.Name = "txtActionLabel2"
        Me.txtActionLabel2.Size = New System.Drawing.Size(189, 20)
        Me.txtActionLabel2.TabIndex = 18
        '
        'txtActionLabel1
        '
        Me.txtActionLabel1.Location = New System.Drawing.Point(128, 180)
        Me.txtActionLabel1.Name = "txtActionLabel1"
        Me.txtActionLabel1.Size = New System.Drawing.Size(189, 20)
        Me.txtActionLabel1.TabIndex = 17
        '
        'txtActionValue3
        '
        Me.txtActionValue3.Location = New System.Drawing.Point(128, 251)
        Me.txtActionValue3.Name = "txtActionValue3"
        Me.txtActionValue3.Size = New System.Drawing.Size(189, 20)
        Me.txtActionValue3.TabIndex = 16
        '
        'txtActionValue2
        '
        Me.txtActionValue2.Location = New System.Drawing.Point(128, 205)
        Me.txtActionValue2.Name = "txtActionValue2"
        Me.txtActionValue2.Size = New System.Drawing.Size(189, 20)
        Me.txtActionValue2.TabIndex = 15
        '
        'txtActionValue1
        '
        Me.txtActionValue1.Location = New System.Drawing.Point(128, 157)
        Me.txtActionValue1.Name = "txtActionValue1"
        Me.txtActionValue1.Size = New System.Drawing.Size(189, 20)
        Me.txtActionValue1.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(89, 275)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(33, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Label"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(89, 230)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Label"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(89, 182)
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
        Me.cmbActionType3.Items.AddRange(New Object() {"Phone Number", "URL", "Code"})
        Me.cmbActionType3.Location = New System.Drawing.Point(7, 251)
        Me.cmbActionType3.Name = "cmbActionType3"
        Me.cmbActionType3.Size = New System.Drawing.Size(115, 21)
        Me.cmbActionType3.TabIndex = 10
        '
        'cmbActionType2
        '
        Me.cmbActionType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbActionType2.Enabled = False
        Me.cmbActionType2.FormattingEnabled = True
        Me.cmbActionType2.Items.AddRange(New Object() {"Phone Number", "URL", "Code"})
        Me.cmbActionType2.Location = New System.Drawing.Point(7, 205)
        Me.cmbActionType2.Name = "cmbActionType2"
        Me.cmbActionType2.Size = New System.Drawing.Size(115, 21)
        Me.cmbActionType2.TabIndex = 9
        '
        'cmbActionType1
        '
        Me.cmbActionType1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbActionType1.Enabled = False
        Me.cmbActionType1.FormattingEnabled = True
        Me.cmbActionType1.Items.AddRange(New Object() {"Phone Number", "URL", "Code"})
        Me.cmbActionType1.Location = New System.Drawing.Point(7, 156)
        Me.cmbActionType1.Name = "cmbActionType1"
        Me.cmbActionType1.Size = New System.Drawing.Size(115, 21)
        Me.cmbActionType1.TabIndex = 8
        '
        'txtReply3
        '
        Me.txtReply3.Location = New System.Drawing.Point(128, 98)
        Me.txtReply3.Name = "txtReply3"
        Me.txtReply3.Size = New System.Drawing.Size(189, 20)
        Me.txtReply3.TabIndex = 7
        '
        'txtReply2
        '
        Me.txtReply2.Location = New System.Drawing.Point(128, 72)
        Me.txtReply2.Name = "txtReply2"
        Me.txtReply2.Size = New System.Drawing.Size(189, 20)
        Me.txtReply2.TabIndex = 6
        '
        'txtReply1
        '
        Me.txtReply1.Location = New System.Drawing.Point(128, 43)
        Me.txtReply1.Name = "txtReply1"
        Me.txtReply1.Size = New System.Drawing.Size(189, 20)
        Me.txtReply1.TabIndex = 5
        '
        'cmbReply3
        '
        Me.cmbReply3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReply3.FormattingEnabled = True
        Me.cmbReply3.Items.AddRange(New Object() {"Reply", "Code"})
        Me.cmbReply3.Location = New System.Drawing.Point(7, 97)
        Me.cmbReply3.Name = "cmbReply3"
        Me.cmbReply3.Size = New System.Drawing.Size(115, 21)
        Me.cmbReply3.TabIndex = 4
        '
        'cmbReply2
        '
        Me.cmbReply2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReply2.FormattingEnabled = True
        Me.cmbReply2.Items.AddRange(New Object() {"Reply", "Code"})
        Me.cmbReply2.Location = New System.Drawing.Point(7, 70)
        Me.cmbReply2.Name = "cmbReply2"
        Me.cmbReply2.Size = New System.Drawing.Size(115, 21)
        Me.cmbReply2.TabIndex = 3
        '
        'rbActionButtons
        '
        Me.rbActionButtons.AutoSize = True
        Me.rbActionButtons.Checked = True
        Me.rbActionButtons.Location = New System.Drawing.Point(7, 133)
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
        Me.rbReplyButtons.Location = New System.Drawing.Point(10, 20)
        Me.rbReplyButtons.Name = "rbReplyButtons"
        Me.rbReplyButtons.Size = New System.Drawing.Size(91, 17)
        Me.rbReplyButtons.TabIndex = 0
        Me.rbReplyButtons.Text = "Reply Buttons"
        Me.rbReplyButtons.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(196, 547)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(277, 547)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 10
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'customBtnTab
        '
        Me.customBtnTab.Controls.Add(Me.TabPage1)
        Me.customBtnTab.Controls.Add(Me.TabPage2)
        Me.customBtnTab.Location = New System.Drawing.Point(34, 12)
        Me.customBtnTab.Name = "customBtnTab"
        Me.customBtnTab.SelectedIndex = 0
        Me.customBtnTab.Size = New System.Drawing.Size(386, 602)
        Me.customBtnTab.TabIndex = 12
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ButtonEmoji)
        Me.TabPage1.Controls.Add(Me.BtnStrike)
        Me.TabPage1.Controls.Add(Me.BtnItalic)
        Me.TabPage1.Controls.Add(Me.BtnBold)
        Me.TabPage1.Controls.Add(Me.txtBody)
        Me.TabPage1.Controls.Add(Me.btnOK)
        Me.TabPage1.Controls.Add(Me.btnCancel)
        Me.TabPage1.Controls.Add(Me.txtTitle)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.grpButtonType)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.txtFooter)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(378, 576)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Custom Buttom"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ButtonEmoji
        '
        Me.ButtonEmoji.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.ButtonEmoji.FlatAppearance.BorderSize = 0
        Me.ButtonEmoji.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ButtonEmoji.Font = New System.Drawing.Font("Wingdings", 12.0!)
        Me.ButtonEmoji.ForeColor = System.Drawing.Color.Black
        Me.ButtonEmoji.Location = New System.Drawing.Point(234, 139)
        Me.ButtonEmoji.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ButtonEmoji.Name = "ButtonEmoji"
        Me.ButtonEmoji.Size = New System.Drawing.Size(29, 25)
        Me.ButtonEmoji.TabIndex = 117
        Me.ButtonEmoji.Text = "J"
        Me.ButtonEmoji.UseVisualStyleBackColor = False
        '
        'BtnStrike
        '
        Me.BtnStrike.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BtnStrike.FlatAppearance.BorderSize = 0
        Me.BtnStrike.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnStrike.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStrike.ForeColor = System.Drawing.Color.Black
        Me.BtnStrike.Location = New System.Drawing.Point(323, 139)
        Me.BtnStrike.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnStrike.Name = "BtnStrike"
        Me.BtnStrike.Size = New System.Drawing.Size(29, 25)
        Me.BtnStrike.TabIndex = 116
        Me.BtnStrike.Text = "S "
        Me.BtnStrike.UseVisualStyleBackColor = False
        '
        'BtnItalic
        '
        Me.BtnItalic.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BtnItalic.FlatAppearance.BorderSize = 0
        Me.BtnItalic.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnItalic.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnItalic.ForeColor = System.Drawing.Color.Black
        Me.BtnItalic.Location = New System.Drawing.Point(292, 139)
        Me.BtnItalic.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnItalic.Name = "BtnItalic"
        Me.BtnItalic.Size = New System.Drawing.Size(29, 25)
        Me.BtnItalic.TabIndex = 115
        Me.BtnItalic.Text = "I"
        Me.BtnItalic.UseVisualStyleBackColor = False
        '
        'BtnBold
        '
        Me.BtnBold.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.BtnBold.FlatAppearance.BorderSize = 0
        Me.BtnBold.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnBold.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBold.ForeColor = System.Drawing.Color.Black
        Me.BtnBold.Location = New System.Drawing.Point(263, 139)
        Me.BtnBold.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.BtnBold.Name = "BtnBold"
        Me.BtnBold.Size = New System.Drawing.Size(29, 25)
        Me.BtnBold.TabIndex = 114
        Me.BtnBold.Text = "B"
        Me.BtnBold.UseVisualStyleBackColor = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.flowLayoutPanelItems)
        Me.TabPage2.Controls.Add(Me.btnAddItem)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.sectionTitle)
        Me.TabPage2.Controls.Add(Me.sectionTitleLabel)
        Me.TabPage2.Controls.Add(Me.listBtnDescription)
        Me.TabPage2.Controls.Add(Me.descriptionLabel)
        Me.TabPage2.Controls.Add(Me.listBtnLabel)
        Me.TabPage2.Controls.Add(Me.btnLabel)
        Me.TabPage2.Controls.Add(Me.okListBtn)
        Me.TabPage2.Controls.Add(Me.CancelListBtn)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(378, 576)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "List Button"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'flowLayoutPanelItems
        '
        Me.flowLayoutPanelItems.AutoScroll = True
        Me.flowLayoutPanelItems.Location = New System.Drawing.Point(28, 220)
        Me.flowLayoutPanelItems.Name = "flowLayoutPanelItems"
        Me.flowLayoutPanelItems.Size = New System.Drawing.Size(322, 320)
        Me.flowLayoutPanelItems.TabIndex = 56
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(28, 163)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(101, 23)
        Me.btnAddItem.TabIndex = 55
        Me.btnAddItem.Text = "Add Item List"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 204)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 34
        Me.Label9.Text = "Item List"
        '
        'sectionTitle
        '
        Me.sectionTitle.Location = New System.Drawing.Point(28, 137)
        Me.sectionTitle.Name = "sectionTitle"
        Me.sectionTitle.Size = New System.Drawing.Size(322, 20)
        Me.sectionTitle.TabIndex = 9
        '
        'sectionTitleLabel
        '
        Me.sectionTitleLabel.AutoSize = True
        Me.sectionTitleLabel.Location = New System.Drawing.Point(25, 121)
        Me.sectionTitleLabel.Name = "sectionTitleLabel"
        Me.sectionTitleLabel.Size = New System.Drawing.Size(66, 13)
        Me.sectionTitleLabel.TabIndex = 10
        Me.sectionTitleLabel.Text = "Section Title"
        '
        'listBtnDescription
        '
        Me.listBtnDescription.Location = New System.Drawing.Point(28, 71)
        Me.listBtnDescription.Multiline = True
        Me.listBtnDescription.Name = "listBtnDescription"
        Me.listBtnDescription.Size = New System.Drawing.Size(322, 47)
        Me.listBtnDescription.TabIndex = 8
        '
        'descriptionLabel
        '
        Me.descriptionLabel.AutoSize = True
        Me.descriptionLabel.Location = New System.Drawing.Point(25, 55)
        Me.descriptionLabel.Name = "descriptionLabel"
        Me.descriptionLabel.Size = New System.Drawing.Size(60, 13)
        Me.descriptionLabel.TabIndex = 7
        Me.descriptionLabel.Text = "Description"
        '
        'listBtnLabel
        '
        Me.listBtnLabel.Location = New System.Drawing.Point(28, 32)
        Me.listBtnLabel.Name = "listBtnLabel"
        Me.listBtnLabel.Size = New System.Drawing.Size(322, 20)
        Me.listBtnLabel.TabIndex = 5
        '
        'btnLabel
        '
        Me.btnLabel.AutoSize = True
        Me.btnLabel.Location = New System.Drawing.Point(25, 16)
        Me.btnLabel.Name = "btnLabel"
        Me.btnLabel.Size = New System.Drawing.Size(67, 13)
        Me.btnLabel.TabIndex = 6
        Me.btnLabel.Text = "Button Label"
        '
        'okListBtn
        '
        Me.okListBtn.Location = New System.Drawing.Point(275, 546)
        Me.okListBtn.Name = "okListBtn"
        Me.okListBtn.Size = New System.Drawing.Size(75, 23)
        Me.okListBtn.TabIndex = 22
        Me.okListBtn.Text = "OK"
        Me.okListBtn.UseVisualStyleBackColor = True
        '
        'CancelListBtn
        '
        Me.CancelListBtn.Location = New System.Drawing.Point(190, 546)
        Me.CancelListBtn.Name = "CancelListBtn"
        Me.CancelListBtn.Size = New System.Drawing.Size(75, 23)
        Me.CancelListBtn.TabIndex = 23
        Me.CancelListBtn.Text = "Cancel"
        Me.CancelListBtn.UseVisualStyleBackColor = True
        '
        'FrmAutoReplyButtonConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 619)
        Me.Controls.Add(Me.customBtnTab)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmAutoReplyButtonConfig"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buttons"
        Me.grpButtonType.ResumeLayout(False)
        Me.grpButtonType.PerformLayout()
        Me.customBtnTab.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
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
    Friend WithEvents customBtnTab As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents listBtnDescription As TextBox
    Friend WithEvents descriptionLabel As Label
    Friend WithEvents listBtnLabel As TextBox
    Friend WithEvents btnLabel As Label
    Friend WithEvents sectionTitle As TextBox
    Friend WithEvents sectionTitleLabel As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnAddItem As Button
    Friend WithEvents flowLayoutPanelItems As FlowLayoutPanel
    Friend WithEvents ButtonEmoji As Button
    Friend WithEvents BtnStrike As Button
    Friend WithEvents BtnItalic As Button
    Friend WithEvents BtnBold As Button
    Friend WithEvents okListBtn As Button
    Friend WithEvents CancelListBtn As Button
End Class
