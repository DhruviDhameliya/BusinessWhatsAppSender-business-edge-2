Public Class GMB
    Public totalcontact = 0
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Getdata()
    End Sub
    Private Sub Getdata()
        Application.DoEvents()
        Button1.Visible = True
        Button2.Visible = False
        Button3.Visible = False
        Button11.Visible = False
        Button12.Visible = False
        Dim query = TextBox1.Text
        GMBrowser.Show()
        GMBrowser.Text = query
        GMBrowser.LoadGMBBrowser("https://www.google.com/maps/search/" + query + "?hl=en")




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        extractEnd()
    End Sub

    Public Sub extractEnd()
        Button1.Visible = False
        Button2.Visible = True
        Button3.Visible = True
        Button11.Visible = True
        Button12.Visible = True
        ' GMBrowser.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As ListViewItem
        Dim li As ListViewItem
        FrmMain.LstNumbers.Visible = False
        For Each a In LstNumbers.Items
            li = New ListViewItem
            li.Tag = TxtID()
            li.Text = a.SubItems.Item(0).Text
            li.SubItems.Add(a.SubItems.Item(1).Text)
            li.SubItems.Add("Pending")
            li.ImageIndex = 0
            FrmMain.LstNumbers.Items.Add(li)
        Next
        FrmMain.LstNumbers.Visible = True
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        If LstNumbers.Items.Count > 0 Then
            SaveFileDialog1.Filter = "*.csv|*.csv"
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                Dim li As ListViewItem
                Dim t As String = ""
                For Each li In LstNumbers.Items
                    t = t & li.SubItems(0).Text.Replace(",", "-") & "," & li.SubItems(1).Text & "," & li.SubItems(2).Text & vbNewLine
                Next
                Dim sw As New IO.StreamWriter(SaveFileDialog1.FileName)
                sw.Write(t)
                sw.Close()
                sw.Dispose()
            End If

        End If
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        LstNumbers.Items.Clear()
        Label3.Text = "0"
    End Sub
End Class