Imports System.Threading
Imports Microsoft.Web.WebView2.Core
Imports Newtonsoft.Json

Public Class FrmMultiBrowser
    Dim connected = False
    Public Contacts As New List(Of DestinationModel)
    Public Messages As List(Of String)
    Public MediaFiles As New List(Of AttachmentModel)
    Private MainThread As Thread
    Public ThreadNo As String

    Private BrowserProfile As String


    Public Async Sub LoadBrowser(profile As String)
        Try
            Try
                WebView21.InitializeLifetimeService()
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
            Dim webView2Environment = Nothing
            Try
                If profile = "" Then
                    webView2Environment = CoreWebView2Environment.CreateAsync(Nothing, ClsSpecialDirectories.GetGetDefaultProfile).Result
                Else
                    webView2Environment = CoreWebView2Environment.CreateAsync(Nothing, ClsSpecialDirectories.GetProfiles & profile).Result
                End If
            Catch ex As Exception

            End Try

            Await WebView21.EnsureCoreWebView2Async(webView2Environment)
            WebView21.Source = New Uri("https://web.whatsapp.com/")
            Thread.Sleep(10)
            Dim _isLoggedIn = 0
            Do
                Try
                    Await WebView21.ExecuteScriptAsync(API.IsLoggedInAll)
                    Dim iswplogindone = Await WebView21.ExecuteScriptAsync("window.IsLoggedInAll()")
                    If iswplogindone Then
                        _isLoggedIn = 1
                    End If
                Catch ex As Exception
                    _isLoggedIn = 0
                End Try
                Thread.Sleep(300)
                Application.DoEvents()
            Loop Until _isLoggedIn > 0
            MsgBox("WhatsApp Login and ready to be used , please close your browser now...", vbInformation, Application.ProductName)
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
    End Sub
    Public Async Sub LoadBrowserWithWAPI(profile As String)
        Try
            Try
                WebView21.InitializeLifetimeService()
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
            Dim webView2Environment = Nothing
            Try
                If profile = "" Then
                    CurrentWaProfile = ClsSpecialDirectories.GetGetDefaultProfile
                    webView2Environment = CoreWebView2Environment.CreateAsync(Nothing, ClsSpecialDirectories.GetGetDefaultProfile).Result
                Else
                    CurrentWaProfile = ClsSpecialDirectories.GetProfiles & ProfileName
                    webView2Environment = CoreWebView2Environment.CreateAsync(Nothing, ClsSpecialDirectories.GetProfiles & profile).Result
                End If
            Catch ex As Exception

            End Try
            Await WebView21.EnsureCoreWebView2Async(webView2Environment)
            WebView21.Source = New Uri("https://web.whatsapp.com/")
            Thread.Sleep(10)
            Dim _isLoggedIn = 0
            Do
                Try
                    Await WebView21.ExecuteScriptAsync(API.IsLoggedInAll)
                    Dim iswplogindone = Await WebView21.ExecuteScriptAsync("window.IsLoggedInAll()")
                    If iswplogindone Then
                        _isLoggedIn = 1
                    End If
                Catch ex As Exception
                    _isLoggedIn = 0
                End Try
                Thread.Sleep(300)
                Application.DoEvents()
            Loop Until _isLoggedIn > 0
            Await WebView21.ExecuteScriptAsync(WAPIScript)
            Dim _WAPILoginResult = CBool(Await WebView21.ExecuteScriptAsync("WAPI.isLoggedIn();"))
            connected = _WAPILoginResult
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
    End Sub
    Public Sub Send()
        MainThread = New Thread(AddressOf DoSendBulk)
        MainThread.Start()
        'DoSendBulk()
    End Sub
    Public Async Sub DoSendBulk()
        While Not connected
            Thread.Sleep(100)
        End While
        Console.WriteLine("connected" & connected.ToString())
        Try
            Dim MessageToSend As String = ""
            Dim SendingCounter As Integer = 1
            For Each Destination As DestinationModel In Contacts
                BulkCurrentProgress = BulkCurrentProgress + 1

                '' Select Message to send 
                Randomize()
                If Messages.Count > 0 Then
                    MessageToSend = Messages(Int(Rnd() * Messages.Count))
                Else
                    MessageToSend = ""
                End If
                Dim SendingResult As Boolean = False

                MessageToSend = FrmBrowser.ApplyVariables(MessageToSend, Destination.Fullname,
                                               Destination.FirstName, Destination.LastName,
                                               Destination.Var1, Destination.Var2, Destination.Var3,
                                               Destination.Var4, Destination.Var5)
                SendingResult = Await SendMessage(Destination.WhatsAppID, MessageToSend, False)
                Dim SentMessage As New MessageSentModel
                SentMessage.MessageID = ThreadNo & SendingCounter
                SentMessage.BuLkMessageDestination = Destination.Number
                SentMessage.BulkMessageBody = MessageToSend
                SentMessage.BulkMessageName = Destination.Fullname
                SentMessage.BulkMessageType = If(Destination.WhatsAppID.Contains("@c.us"), "Contact", "Group")
                SentMessage.BulkMessageStatus = SendingResult
                SentMessage.BulkMessageDate = Now
                MessagesSentList.Add(SentMessage)
                BulkIsMessageSent = True
                Console.WriteLine(SentMessage.MessageID & " : " & SentMessage.BuLkMessageDestination)

                If SendingResult Then
                    If Not IsNothing(MediaFiles) Then
                        For Each Attachment As AttachmentModel In MediaFiles
                            Dim AttachmentCaption As String = Attachment.Caption
                            AttachmentCaption = FrmBrowser.ApplyVariables(AttachmentCaption, Destination.Fullname,
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
                Thread.Sleep(300)
                If CBool(GetSetting(ApplicationTitle, "SendingConfig", "ActivateSleep", "false")) Then
                    If SendingCounter Mod Val(GetSetting(ApplicationTitle, "SendingConfig", "SleepAfter", 20)) = 0 Then
                        BulkIsResting = True
                        Thread.Sleep(Val(GetSetting(ApplicationTitle, "SendingConfig", "SleepFor", 5)) * 1000)
                        BulkIsResting = False
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
    Public Async Function SendMessage(ByVal WhatsAppAccount As String, ByVal Message As String, ByVal IsSafe As Boolean) As Task(Of String)
        Try
            Dim status = """null"""
            If Message = "" Then
                Message = " "
            End If
            Message = SafeJavaScript(Message)
            Try
                WebView21.BeginInvoke(Sub()
                                          WebView21.ExecuteScriptAsync("tlsbot.status='null'")
                                      End Sub)
                WebView21.BeginInvoke(Sub()
                                          WebView21.ExecuteScriptAsync($"tlsbot.sendMessage('{WhatsAppAccount}','{Message}',{IsSafe.ToString.ToLower}).then(e=>tlsbot.status=e)")
                                      End Sub)
                Do
                    Thread.Sleep(100)
                    WebView21.BeginInvoke(Async Sub()
                                              status = Await WebView21.ExecuteScriptAsync("tlsbot.status")
                                          End Sub)
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
    Public Async Function SendFile(ByVal FileName As String, ByVal WhatsAppAccount As String, ByVal Caption As String) As Task(Of String)
        Try
            Dim Base64converter As New ClsBase64
            Dim Base64File As String = Base64converter.ConvertFileToBase64(FileName)
            Dim a() As String = Split(FileName, "\")
            Caption = SafeJavaScript(Caption)
            Dim _filename As String = a(UBound(a))
            Try
                WebView21.BeginInvoke(Sub()
                                          WebView21.ExecuteScriptAsync($"tlsbot.sendFile('" & Base64File & "','" & WhatsAppAccount & "','" & _filename & "','" & Caption & "');")
                                      End Sub)
            Catch ex As Exception
                Console.WriteLine("Catch")
            End Try
            Thread.Sleep(100)
        Catch ex As Exception
            Console.WriteLine("SendFile Catch : ")
            Console.WriteLine(ex)
        End Try
    End Function

End Class