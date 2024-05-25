Imports System.Threading

Public Class ClsWhatsappChannel
    Public BrowserProfile As String
    Public Contacts As List(Of WhatsAppContact)
    Public Messages As List(Of String)
    Public MediaFiles As List(Of ClsAttachment)
    Public Delay As Integer
    Public RestAfter As Integer
    Public RestFor As Integer


    Private MainThread As System.Threading.Thread
    Public Sub Login()
        ' Dim childForm As New FrmMultiBrowser()
        FrmMultiBrowser.Show()
        FrmMultiBrowser.Activate()
        FrmMultiBrowser.Text = "Multi Channel : " & BrowserProfile
        FrmMultiBrowser.LoadBrowser(BrowserProfile.ToString())
    End Sub


    Private Function ApplySpinText(ByVal Text As String) As String
        Dim _text As String = Text
        Dim dicEntry As DictionaryEntry
        Dim SpinTextDictionary As New List(Of DictionaryEntry)
        _text = _text.Replace("{{", "||{{") : _text = _text.Replace("}}", "}}||")
        Dim SpintextArr() As String = Split(_text, "||")
        For Each Spintext As String In SpintextArr
            If Spintext.Trim.StartsWith("{{") And Spintext.Trim.EndsWith("}}") Then
                Dim cSpin As String = Spintext
                cSpin = cSpin.Replace("{{", "") : cSpin = cSpin.Replace("}}", "")
                Dim rWords() As String = cSpin.Split("|")
                If rWords.Count > 0 Then
                    Randomize()
                    Dim selector As Integer = 0
                    For i As Integer = 0 To 30 : selector = Int(Rnd() * rWords.Count)
                    Next
                    dicEntry = New DictionaryEntry(Spintext, rWords(selector)) : SpinTextDictionary.Add(dicEntry)
                End If
            End If
        Next
        Dim Result As String = Text
        For Each dicEntry In SpinTextDictionary
            Result = Result.Replace(dicEntry.Key, dicEntry.Value)
        Next
        Return Result
    End Function
End Class
