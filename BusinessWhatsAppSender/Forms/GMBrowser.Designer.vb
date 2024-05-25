<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GMBrowser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GMBrowser))
        Me.WebView22 = New Microsoft.Web.WebView2.WinForms.WebView2()
        CType(Me.WebView22, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'WebView22
        '
        Me.WebView22.CreationProperties = Nothing
        Me.WebView22.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView22.Location = New System.Drawing.Point(-2, 1)
        Me.WebView22.Name = "WebView22"
        Me.WebView22.Size = New System.Drawing.Size(1101, 678)
        Me.WebView22.TabIndex = 0
        Me.WebView22.ZoomFactor = 1.0R
        '
        'GMBrowser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1099, 678)
        Me.Controls.Add(Me.WebView22)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GMBrowser"
        Me.Text = "GMBrowser"
        CType(Me.WebView22, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents WebView22 As Microsoft.Web.WebView2.WinForms.WebView2
End Class
