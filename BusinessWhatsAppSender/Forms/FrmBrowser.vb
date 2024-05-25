Imports System.ComponentModel
Imports System.Threading
Imports Microsoft.Web.WebView2.Core
Imports Newtonsoft.Json

Public Class FrmBrowser
    Public loginResult As String
    Public IsWhatsAppLogginIn As Boolean
    Public IsWAPILoggedIn As Boolean
    Public Structure WAPI
        Public Shared IsWAPILoggedIn As Boolean
        Public Shared IsWAPIConnected As Boolean
    End Structure
    Private SendingThread As Thread
    Private _Destinations As List(Of DestinationModel)
    Private _Messages As List(Of String)
    Private _Attachments As List(Of AttachmentModel)
    Private _SafeMode As Boolean
    Private WebViewIsBusy As Boolean
    Public Sub StartBulk(ByVal Destinations As List(Of DestinationModel),
                         ByVal Messages As List(Of String),
                         ByVal Attachments As List(Of AttachmentModel),
                         ByVal SafeMode As Boolean)

        _Destinations = Destinations
        _Messages = Messages
        _Attachments = Attachments
        _SafeMode = SafeMode

        DoSendBulk()
    End Sub
    Private Async Sub DoSendBulk()
        Try
            BulkIsStarted = True
            BulkIsSending = True
            BulkMAXProgress = _Destinations.Count

            Dim MessageToSend As String = ""
            Dim SendingCounter As Integer = 1
            BulkCurrentProgress = 0
            MessagesSentList.Clear()
            For Each Destination As DestinationModel In _Destinations
                BulkCurrentProgress = BulkCurrentProgress + 1
                '    If MsgBox("OOPS!!! something wrong , whatsapp logged out or blocked check what is the matter and press retry to continue your bulk," & vbNewLine & "Do you want open the browser to check what is going on ? ", vbCritical + vbYesNo, ApplicationTitle) = vbYes Then
                BulkIsLoggedIn = True
                While Not IsWAPILoggedIn
                    BulkIsLoggedIn = False
                    Thread.Sleep(10)
                End While
                '' Select Message to send 
                Randomize()
                If _Messages.Count > 0 Then
                    MessageToSend = _Messages(Int(Rnd() * _Messages.Count))
                Else
                    MessageToSend = ""
                End If
                Dim SendingResult As Boolean = False

                MessageToSend = ApplyVariables(MessageToSend, Destination.Fullname,
                                               Destination.FirstName, Destination.LastName,
                                               Destination.Var1, Destination.Var2, Destination.Var3,
                                               Destination.Var4, Destination.Var5)
                SendingResult = Await SendMessage(Destination.WhatsAppID, MessageToSend, _SafeMode)
                Dim SentMessage As New MessageSentModel
                SentMessage.MessageID = SendingCounter
                SentMessage.BuLkMessageDestination = Destination.Number
                SentMessage.BulkMessageBody = MessageToSend
                SentMessage.BulkMessageName = Destination.Fullname
                SentMessage.BulkMessageType = If(Destination.WhatsAppID.Contains("@c.us"), "Contact", "Group")
                SentMessage.BulkMessageStatus = SendingResult
                SentMessage.BulkMessageDate = Now
                MessagesSentList.Add(SentMessage)
                BulkIsMessageSent = True
                If SendingResult Then
                    If Not IsNothing(_Attachments) Then
                        For Each Attachment As AttachmentModel In _Attachments
                            Dim AttachmentCaption As String = Attachment.Caption
                            AttachmentCaption = ApplyVariables(AttachmentCaption, Destination.Fullname,
                                               Destination.FirstName, Destination.LastName,
                                               Destination.Var1, Destination.Var2, Destination.Var3,
                                               Destination.Var4, Destination.Var5)
                            Await SendFile(Attachment.FileName, Destination.WhatsAppID, AttachmentCaption)
                            Thread.Sleep(100)
                        Next
                    End If
                End If
                Do
                    Thread.Sleep(10)
                Loop While BulkIsPaused
                Thread.Sleep(GetDelay)
                Dim waitspeed = (5 - Val(GetSetting(ApplicationTitle, "SendingConfig", "Speed", "3"))) * 100
                Thread.Sleep(waitspeed)
                If CBool(GetSetting(ApplicationTitle, "SendingConfig", "ActivateSleep", "false")) Then
                    If SendingCounter Mod Val(GetSetting(ApplicationTitle, "SendingConfig", "SleepAfter", 20)) = 0 Then
                        BulkIsResting = True
                        Thread.Sleep(Val(GetSetting(ApplicationTitle, "SendingConfig", "SleepFor", 5)) * 1000)
                        BulkIsResting = False
                    End If
                End If
                If CBool(GetSetting(ApplicationTitle, "SendingConfig", "ActivateDialog", "false")) Then
                    If SendingCounter Mod (Val(GetSetting(ApplicationTitle, "SendingConfig", "DialogAfter", 5)) + 1) = 0 Then
                        Dim FamiliarLimits As Integer = 0
                        Dim FamiliarDestination As String() = IO.File.ReadAllLines(ClsSpecialDirectories.Getdata & "commonList.data")
                        If FamiliarDestination.Count > Val(GetSetting(ApplicationTitle, "SendingConfig", "DialoCount", 15)) Then
                            FamiliarLimits = Val(GetSetting(ApplicationTitle, "SendingConfig", "DialoCount", 15))
                        Else
                            FamiliarLimits = FamiliarDestination.Count
                        End If

                        Dim FamiliarMessages() As String = IO.File.ReadAllLines(ClsSpecialDirectories.Getdata & "commonMessage.data")

                        For i = 0 To FamiliarLimits - 1
                            Randomize()
                            Await SendMessage(FamiliarDestination(i) & "@c.us", FamiliarMessages(Int(Rnd() * FamiliarMessages.Count)), True)
                            Thread.Sleep(Val(GetSetting(ApplicationTitle, "SendingConfig", "DialogWait", 1)) * 1000)
                        Next
                    End If
                End If
                Application.DoEvents()
                SendingCounter += 1
            Next
            SendingCounter = 0
            BulkIsDone = True
            BulkIsSending = False
            BulkIsStarted = False
        Catch ex As Exception

        End Try
    End Sub

    Public Function ApplyVariables(ByVal VariableText As String, Optional fullName As String = "", Optional FirstName As String = "",
            Optional LastName As String = "", Optional Var1 As String = "", Optional Var2 As String = "", Optional Var3 As String = "",
                                  Optional Var4 As String = "", Optional Var5 As String = "") As String

        VariableText = VariableText.Replace("[[fullname]]", fullName)
        VariableText = VariableText.Replace("[[firstname]]", FirstName)
        VariableText = VariableText.Replace("[[lastname]]", LastName)

        VariableText = VariableText.Replace("[[VAR1]]", Var1)
        VariableText = VariableText.Replace("[[VAR2]]", Var2)
        VariableText = VariableText.Replace("[[VAR3]]", Var3)
        VariableText = VariableText.Replace("[[VAR4]]", Var4)
        VariableText = VariableText.Replace("[[VAR5]]", Var5)
        VariableText = VariableText.Replace("[[randomtag]]", "#" & (Int(Rnd() * 1000000) + 1000000))

        VariableText = ApplySpinText(VariableText)

        Return VariableText
    End Function

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

    Private Function GetDelay() As Integer
        Dim Num1 As Integer = Val(GetSetting(ApplicationTitle, "SendingConfig", "DelayStart", "0"))
        Dim Num2 As Integer = Val(GetSetting(ApplicationTitle, "SendingConfig", "DelayEnd", "2"))

        Randomize()
        Dim a As Integer = 10
        If Num2 > 0 Then
            a = (Num1 + (Int(Rnd() * Num2))) * 1000
        Else
            a = 100
        End If
        If a = 0 Then
            a = 100
        End If
        Return a
    End Function
    Public Sub StopBulk()
        Try
            SendingThread.Abort()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FrmBrowser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            WebView2.InitializeLifetimeService()
        Catch ex As Exception
            If MsgBox($"You have to install Edge Runtime to start the application.{vbCrLf} Do you want install it?",
                      vbCritical + vbYesNo, Application.ProductName) = vbYes Then
                Try
                    Process.Start("https://developer.microsoft.com/en-us/microsoft-edge/webview2/")
                Catch

                End Try
            End If
            End
        End Try
        WebViewIsBusy = False
        Dim webView2Environment = Nothing

        Try
            If ProfileName = "" Then
                CurrentWaProfile = ClsSpecialDirectories.GetGetDefaultProfile
                webView2Environment = CoreWebView2Environment.CreateAsync(Nothing, ClsSpecialDirectories.GetGetDefaultProfile).Result
            Else
                CurrentWaProfile = ClsSpecialDirectories.GetProfiles & ProfileName
                webView2Environment = CoreWebView2Environment.CreateAsync(Nothing, ClsSpecialDirectories.GetProfiles & ProfileName).Result
            End If
        Catch ex As Exception

        End Try

        WebView2.EnsureCoreWebView2Async(webView2Environment)
        WebView2.Source = New Uri("https://web.whatsapp.com/")
    End Sub


    Private Sub FrmBrowser_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = True
        Me.Hide()
    End Sub
    Public Async Function IsWPLogin() As Task
        Try
            Dim _WAPILoginResult = CBool(Await WebView2.ExecuteScriptAsync("tlsbot.isLogginDone();"))
            If _WAPILoginResult Then
                Status.IsWAPIConnected = _WAPILoginResult
                IsWAPILoggedIn = _WAPILoginResult
                Status.IsWAPIloggedin = IsWAPILoggedIn
                FrmMain.LabelLoginStatus.BackColor = If(IsWAPILoggedIn, Color.Green, Color.Red)
                FrmMain.LabelLoginStatus.Text = If(IsWAPILoggedIn, "Ready", "Not Ready")
            End If
        Catch ex As Exception
            ' MsgBox(ex.Message)
        End Try
    End Function

    Private Async Sub Timer1_TickAsync(sender As Object, e As EventArgs) Handles TimerIsWhatsAppLoggedIn.Tick
        Try
            Await WebView2.ExecuteScriptAsync(API.IsLoggedInAll)
            Dim iswplogindone = Await WebView2.ExecuteScriptAsync("window.IsLoggedInAll()")
            If iswplogindone Then
                IsWhatsAppLogginIn = True
                If Not IsWAPILoggedIn Then
                    Try
                        Await WebView2.ExecuteScriptAsync(WAPIScript)
                        Await IsWPLogin()
                    Catch ex As Exception
                        MsgBox("Unable To Execute API...")
                    End Try
                Else
                    Await IsWPLogin()
                End If
            Else
                IsWhatsAppLogginIn = False
            End If
            If IsWhatsAppLogginIn = True Then
                If Not TimerReceive.Enabled Then
                    TimerReceive.Enabled = True
                End If

            End If

        Catch ex As Exception
            IsWhatsAppLogginIn = False
            ' MsgBox("aaaa" & ex.Message)
        End Try
    End Sub

    Public Async Function GetAllGroups() As Task(Of Object)
        Try
            Dim ContactResults = """null"""
            Await WebView2.ExecuteScriptAsync("tlsbot.groupList='null'")
            Await WebView2.ExecuteScriptAsync($"tlsbot.getAllGroups().then(e=>tlsbot.groupList=e)")
            Do
                Thread.Sleep(100)
                ContactResults = Await WebView2.ExecuteScriptAsync("tlsbot.groupList")
            Loop While ContactResults.ToString() = """null"""
            Dim ContactResult = JsonConvert.DeserializeObject(ContactResults.ToString())
            Return ContactResult
        Catch ex As Exception
            Console.WriteLine(ex)
            Return New List(Of String)
        End Try
    End Function
    Public Async Function getGroupParticipantIDs(ByVal id As String) As Task(Of String)
        Try
            Dim ContactResults = """null"""
            Await WebView2.ExecuteScriptAsync("tlsbot.groupContactList='null'")
            Await WebView2.ExecuteScriptAsync($"tlsbot.getGroupParticipantList('" & id & "').then(e=>tlsbot.groupContactList=e)")
            Do
                Thread.Sleep(100)
                ContactResults = Await WebView2.ExecuteScriptAsync("tlsbot.groupContactList")
            Loop While ContactResults.ToString() = """null"""
            ContactResults = JsonConvert.DeserializeObject(ContactResults.ToString())
            Return ContactResults
        Catch ex As Exception
            Console.WriteLine(ex)
            Return ""
        End Try
    End Function
    Public Async Function resetNumberStatus() As Task
        Try
            Await WebView2.ExecuteScriptAsync("tlsbot.numberStatus={}")
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
    End Function
    Public Async Function CheckWhatsAppAccount(ByVal WhatsAppAccount As String) As Task
        Try
            Dim status = """null"""
            Try
                Await WebView2.ExecuteScriptAsync("tlsbot.numberStatus['" & WhatsAppAccount & "']='null'")
                Await WebView2.ExecuteScriptAsync($"tlsbot.checkNumberStatus('" & WhatsAppAccount & "').then(e=>tlsbot.numberStatus['" & WhatsAppAccount & "']=e)")
                Do
                    Thread.Sleep(100)
                    status = Await WebView2.ExecuteScriptAsync("tlsbot.numberStatus['" & WhatsAppAccount & "']")
                Loop While status.ToString() = """null"""
                checkNumberStatus(status.ToString())
            Catch ex As Exception
                Console.WriteLine(ex)
            End Try
        Catch ex As Exception

        End Try
    End Function
    Public Sub checkNumberStatus(ByVal e As Object)
        NumberCheckedList = e & "|" & NumberCheckedList
    End Sub

    Public Async Function SendMessage(ByVal WhatsAppAccount As String, ByVal Message As String, ByVal IsSafe As Boolean) As Task(Of String)
        Try
            Dim status = """null"""
            If Message = "" Then
                Message = " "
            End If
            Message = SafeJavaScript(Message)
            Try
                Await WebView2.ExecuteScriptAsync("tlsbot.sendMessageStatus='null'")
                Await WebView2.ExecuteScriptAsync($"tlsbot.sendMessage('{WhatsAppAccount}','{Message}',{IsSafe.ToString.ToLower}).then(e=>tlsbot.sendMessageStatus=e)")
                Do
                    Thread.Sleep(100)
                    status = Await WebView2.ExecuteScriptAsync("tlsbot.sendMessageStatus")
                Loop While status.ToString() = """null"""
            Catch ex As Exception
                Console.WriteLine(ex)
            End Try
            Dim ReceivedStatus = JsonConvert.DeserializeObject(status.ToString())
            Return ReceivedStatus("sentStatus")
        Catch ex As Exception
            Return False
        End Try
    End Function
    Public Async Function GetAllContact() As Task(Of Object)
        Try
            Dim ContactResults = """null"""
            Await WebView2.ExecuteScriptAsync("tlsbot.contactList='null'")
            Await WebView2.ExecuteScriptAsync($"tlsbot.getAllContacts().then(e=>tlsbot.contactList=e)")
            Do
                Thread.Sleep(100)
                ContactResults = Await WebView2.ExecuteScriptAsync("tlsbot.contactList")
            Loop While ContactResults.ToString() = """null"""
            Dim ContactResult = JsonConvert.DeserializeObject(ContactResults.ToString())
            Return ContactResult
        Catch ex As Exception
            Console.WriteLine(ex)
            Return New List(Of String)
        End Try
    End Function
    Public Async Function SendFile(ByVal FileName As String, ByVal WhatsAppAccount As String, ByVal Caption As String) As Task(Of String)
        Try
            Dim Base64converter As New ClsBase64
            Dim Base64File As String = Base64converter.ConvertFileToBase64(FileName)
            Dim a() As String = Split(FileName, "\")
            Caption = SafeJavaScript(Caption)
            Dim _filename As String = a(UBound(a))
            Try
                Await WebView2.ExecuteScriptAsync($"tlsbot.sendFile('" & Base64File & "','" & WhatsAppAccount & "','" & _filename & "','" & Caption & "');")
            Catch ex As Exception
                Console.WriteLine("Catch")
            End Try
            Thread.Sleep(100)
        Catch ex As Exception
            Console.WriteLine("SendFile Catch : ")
            Console.WriteLine(ex)
        End Try
    End Function


    Public Async Sub SendStickers(ByVal FileName As String, ByVal WhatsAppAccount As String)
        Try
            Dim Base64converter As New ClsBase64
            Dim Base64File As String = Base64converter.ConvertFileToBase64(FileName)
            Try
                Await WebView2.ExecuteScriptAsync($"tlsbot.sendImageAsSticker('" & Base64File & "','" & WhatsAppAccount & "');")
            Catch ex As Exception
                Console.WriteLine("Catch")
            End Try
            Thread.Sleep(100)
        Catch ex As Exception
            Console.WriteLine("SendStickers Catch : ")
            Console.WriteLine(ex)
        End Try
    End Sub
    Public ReceivingCounter As Integer
    Public Async Function GetAllUnreadChats() As Task(Of Object)
        Try
            Console.WriteLine("tlsbot.getUnreadChat().then(e=>tlsbot.UnreadChatList=e)")
            Dim ContactResults = """null"""
            Await WebView2.ExecuteScriptAsync("tlsbot.UnreadChatList='null'")
            Await WebView2.ExecuteScriptAsync("tlsbot.getUnreadChat().then(e=>tlsbot.UnreadChatList=e)")
            Dim i = 0
            Do
                Application.DoEvents()
                i = i + 1
                Thread.Sleep(500)
                ContactResults = Await WebView2.ExecuteScriptAsync("tlsbot.UnreadChatList")
                If i > 5 Then
                    Return New List(Of String)
                End If
            Loop While ContactResults.ToString() = """null"""
            Dim ContactResult = JsonConvert.DeserializeObject(ContactResults.ToString())
            Return ContactResult
        Catch ex As Exception
            Console.WriteLine(ex)
            Return New List(Of String)
        End Try
    End Function
    Public Async Function GetUnreadChatById(id) As Task(Of Object)
        Try
            Console.WriteLine("tlsbot.getUnreadChatbyId('" & id & "').then(e=>tlsbot.UnreadChat=e)")
            Dim ContactResults = """null"""
            Await WebView2.ExecuteScriptAsync("tlsbot.UnreadChat='null'")
            Await WebView2.ExecuteScriptAsync("tlsbot.getUnreadChatbyId('" & id & "').then(e=>tlsbot.UnreadChat=e)")
            Dim i = 0
            Do
                Application.DoEvents()
                Thread.Sleep(500)
                ContactResults = Await WebView2.ExecuteScriptAsync("tlsbot.UnreadChat")
                i = i + 1
                If i > 5 Then
                    Return JsonConvert.DeserializeObject("{}")
                End If
            Loop While ContactResults.ToString() = """null"""
            Dim ContactResult = JsonConvert.DeserializeObject(ContactResults.ToString())
            Return ContactResult
        Catch ex As Exception
            Console.WriteLine(ex)
            Return JsonConvert.DeserializeObject("{}")
        End Try
    End Function
    Private Async Sub Receiver(sender As Object, e As EventArgs) Handles TimerReceive.Tick
        Try
            Application.DoEvents()
            If Not AllowAutoReply Then
                Exit Sub
            End If
            If Not IsWAPILoggedIn Then
                Exit Sub
            End If
            If MessageRetriveProgress Then
                Exit Sub
            End If
            MessageRetriveProgress = True

            If Not CBool(GetSetting(ApplicationTitle, "SendingConfig", "UnreadMessage", "false")) Then
                FrmMain.ButtonSwitch.Dock = DockStyle.Left
                Exit Sub
            Else
                FrmMain.ButtonSwitch.Dock = DockStyle.Right
            End If
            If FrmMain.ButtonSwitch.Dock = DockStyle.Left Then
                Exit Sub
            End If

            Dim WhatsAppAccount As String = ""
            Dim Body As String = ""
            Console.WriteLine("1")
            Try
                Dim li As ListViewItem
                Dim li2 As ListViewItem
                Dim a = Await GetAllUnreadChats()
                Console.WriteLine(a)
                Dim t As Object
                If a.Count > 0 Then
                    For Each t In a
                        Application.DoEvents()
                        Console.WriteLine(t)
                        If Not IsReceivedKeyExsist(t("_serialized")) Then
                            Console.WriteLine("1")
                            Try
                                If FrmMain.ButtonSwitch.Dock = DockStyle.Right Then
                                    Console.WriteLine("2")
                                    Dim b = Await GetUnreadChatById(t("_serialized"))
                                    Console.WriteLine(b)
                                    If Not b.Equals(JsonConvert.DeserializeObject("{}")) Then
                                        AddMessageKey(t("_serialized"))
                                        Console.WriteLine("3")
                                        If b("server") = "c.us" Then
                                            If b("type") = "in" Then
                                                Console.WriteLine("4")
                                                allReceivedMessage = allReceivedMessage & Newtonsoft.Json.JsonConvert.SerializeObject(b) & vbNewLine & vbNewLine
                                                li = New ListViewItem
                                                li2 = New ListViewItem
                                                li.Tag = b("_serialized").ToString
                                                li.Text = Now
                                                li.SubItems.Add(b("user").ToString)
                                                If Not IsNothing(b("body")) Then
                                                    li.SubItems.Add(b("body").ToString)
                                                    li2.SubItems.Add(b("body").ToString)
                                                End If
                                                li2.Tag = b("_serialized").ToString
                                                li2.Text = Now
                                                li2.SubItems.Add(b("user").ToString)
                                                li2.SubItems.Add("In")
                                                FrmMain.ListReceivedMessages.Items.Add(li)
                                                FrmReceived.ListView1.Items.Add(li2)
                                                If Not IsNothing(b("body")) Then
                                                    Body = b("body").ToString
                                                End If
                                                WhatsAppAccount = b("_serialized").ToString
                                                Console.WriteLine("5")
                                                Dim _autoReplyObject As ClsAutoReplyMessage
                                                If IO.File.Exists(ClsSpecialDirectories.Getdata & "autoreply.json") Then
                                                    _autoReplyObject = Newtonsoft.Json.JsonConvert.DeserializeObject(Of ClsAutoReplyMessage)(IO.File.ReadAllText(ClsSpecialDirectories.Getdata & "autoreply.json"))
                                                Else
                                                    _autoReplyObject = Nothing
                                                End If
                                                If Not IsNothing(_autoReplyObject) Then
                                                    If Not IsAutoReplied(WhatsAppAccount) Then
                                                        If WhatsAppAccount.ToLower.Contains("@c.us") Then
                                                            AddAutoReplyAccount(WhatsAppAccount)
                                                            Await SendMessage(WhatsAppAccount, _autoReplyObject.Message, False)
                                                            Application.DoEvents()
                                                            If Not IsNothing(_autoReplyObject.Attachment) Then
                                                                For Each attach As ClsAttachment In _autoReplyObject.Attachment
                                                                    Application.DoEvents()
                                                                    If attach.MediaType <> "Sticker" Then
                                                                        SendFile(attach.File, WhatsAppAccount, attach.Caption)
                                                                    Else
                                                                        SendStickers(attach.File, WhatsAppAccount)
                                                                    End If
                                                                Next
                                                            End If
                                                        End If
                                                    End If
                                                End If

                                                Dim lst As List(Of ClsRuleModel)
                                                lst = Newtonsoft.Json.JsonConvert.DeserializeObject(Of List(Of ClsRuleModel))(IO.File.ReadAllText(ClsSpecialDirectories.Getdata & "rules.json"))
                                                If Not IsNothing(lst) Then
                                                    For Each rule As ClsRuleModel In lst
                                                        If WhatsAppAccount.ToLower.Contains("@c.us") Then
                                                            If rule.RuleStatus Then
                                                                Select Case rule.Operand
                                                                    Case "="
                                                                        If rule.RuleKeyword = Body.Trim Then
                                                                            Await SendMessage(WhatsAppAccount, rule.RuleMessage, False)
                                                                            Application.DoEvents()
                                                                            If Not IsNothing(rule.Attachment) Then
                                                                                For Each attach As ClsAttachment In rule.Attachment
                                                                                    Application.DoEvents()
                                                                                    If attach.MediaType <> "Sticker" Then
                                                                                        SendFile(attach.File, WhatsAppAccount, attach.Caption)
                                                                                    Else
                                                                                        SendStickers(attach.File, WhatsAppAccount)
                                                                                    End If
                                                                                Next

                                                                            End If
                                                                        End If
                                                                    Case "Like"
                                                                        If rule.RuleKeyword.ToLower = Body.Trim.ToLower Then
                                                                            Await SendMessage(WhatsAppAccount, rule.RuleMessage, False)
                                                                            Application.DoEvents()
                                                                            If Not IsNothing(rule.Attachment) Then
                                                                                For Each attach As ClsAttachment In rule.Attachment
                                                                                    Application.DoEvents()
                                                                                    If attach.MediaType <> "Sticker" Then
                                                                                        SendFile(attach.File, WhatsAppAccount, attach.Caption)
                                                                                    Else
                                                                                        SendStickers(attach.File, WhatsAppAccount)
                                                                                    End If
                                                                                Next
                                                                            End If
                                                                        End If
                                                                    Case "Start with"
                                                                        If Body.ToLower.StartsWith(rule.RuleKeyword.ToLower.Trim) Then
                                                                            Await SendMessage(WhatsAppAccount, rule.RuleMessage, False)
                                                                            Application.DoEvents()
                                                                            If Not IsNothing(rule.Attachment) Then
                                                                                For Each attach As ClsAttachment In rule.Attachment
                                                                                    Application.DoEvents()
                                                                                    If attach.MediaType <> "Sticker" Then
                                                                                        SendFile(attach.File, WhatsAppAccount, attach.Caption)
                                                                                    Else
                                                                                        SendStickers(attach.File, WhatsAppAccount)
                                                                                    End If
                                                                                Next

                                                                            End If
                                                                        End If
                                                                    Case "End with"
                                                                        If Body.ToLower.EndsWith(rule.RuleKeyword.ToLower.Trim) Then
                                                                            Await SendMessage(WhatsAppAccount, rule.RuleMessage, False)
                                                                            Application.DoEvents()
                                                                            If Not IsNothing(rule.Attachment) Then
                                                                                For Each attach As ClsAttachment In rule.Attachment
                                                                                    Application.DoEvents()
                                                                                    If attach.MediaType <> "Sticker" Then
                                                                                        SendFile(attach.File, WhatsAppAccount, attach.Caption)
                                                                                    Else
                                                                                        SendStickers(attach.File, WhatsAppAccount)
                                                                                    End If
                                                                                Next

                                                                            End If
                                                                        End If
                                                                    Case "Contains"
                                                                        If Body.ToLower.Contains(rule.RuleKeyword.ToLower) Then
                                                                            Await SendMessage(WhatsAppAccount, rule.RuleMessage, False)
                                                                            Application.DoEvents()
                                                                            If Not IsNothing(rule.Attachment) Then
                                                                                For Each attach As ClsAttachment In rule.Attachment
                                                                                    Application.DoEvents()
                                                                                    If attach.MediaType <> "Sticker" Then
                                                                                        SendFile(attach.File, WhatsAppAccount, attach.Caption)
                                                                                    Else
                                                                                        SendStickers(attach.File, WhatsAppAccount)
                                                                                    End If
                                                                                Next

                                                                            End If
                                                                        End If
                                                                End Select
                                                            End If
                                                        End If
                                                    Next
                                                End If




                                            End If
                                        End If
                                    End If
                                End If
                            Catch ex As Exception
                                Console.WriteLine("Catch Called")
                                Console.WriteLine(ex)
                            End Try
                        End If
                    Next
                End If
            Catch ex As Exception
                Console.WriteLine("Catch Called outer")
                Console.WriteLine(ex)
            End Try

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        MessageRetriveProgress = False

    End Sub
    Public Sub AddAutoReplyAccount(ByVal Account As String)
        Dim Sw As New IO.StreamWriter(ClsSpecialDirectories.Getdata & "autoreplyusers.key", True)
        Sw.WriteLine(Account)
        Sw.Close()
        Sw.Dispose()
    End Sub
    Public Function IsAutoReplied(ByVal Account As String) As Boolean
        If IO.File.Exists(ClsSpecialDirectories.Getdata & "autoreplyusers.key") Then
            Return IO.File.ReadAllText(ClsSpecialDirectories.Getdata & "autoreplyusers.key").Contains(Account)
        Else
            Return False
        End If
    End Function

    Public Function IsReceivedKeyExsist(ByVal key As String) As Boolean
        If IO.File.Exists(ClsSpecialDirectories.Getdata & "messageskeys.key") Then
            Dim a As String = IO.File.ReadAllText(ClsSpecialDirectories.Getdata & "messageskeys.key")
            Return a.Contains(key)
        Else
            Return False
        End If

    End Function
    Public Sub AddMessageKey(ByVal key As String)
        Dim sw As New IO.StreamWriter(ClsSpecialDirectories.Getdata & "messageskeys.key", True)
        sw.Write(key & vbNewLine)
        sw.Close()
        sw.Dispose()
    End Sub
End Class

