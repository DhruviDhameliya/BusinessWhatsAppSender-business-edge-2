Imports System.Threading
Imports Microsoft.Web.WebView2.Core
Imports Newtonsoft.Json

Public Class GMBrowser
    Public Async Sub LoadGMBBrowser(url As String)
        Try
            Try
                WebView22.InitializeLifetimeService()
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
                webView2Environment = CoreWebView2Environment.CreateAsync(Nothing, ClsSpecialDirectories.GetGetDefaultProfile).Result
            Catch ex As Exception

            End Try

            Await WebView22.EnsureCoreWebView2Async(webView2Environment)
            WebView22.Source = New Uri(url)
            Thread.Sleep(10)
            Dim _isLoggedIn = 0
            Do
                Try
                    _isLoggedIn = Await WebView22.ExecuteScriptAsync("document.getElementsByClassName('id-app-container').length;")
                Catch ex As Exception
                    _isLoggedIn = 0
                End Try
                Thread.Sleep(100)
                Application.DoEvents()
            Loop Until _isLoggedIn > 0
            Await WebView22.ExecuteScriptAsync(API.GMBScroll)
            System.Threading.Thread.Sleep(2000)
            WebView22.ExecuteScriptAsync(API.GMBScript)
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
    End Sub
    Private Async Sub WebView2_WebMessageReceived(sender As Object, e As CoreWebView2WebMessageReceivedEventArgs) Handles WebView22.WebMessageReceived

        If (e.WebMessageAsJson.ToString().Contains("BulkExtractorStoped")) Then
            GMB.extractEnd()
        Else
            Dim ContactResult = JsonConvert.DeserializeObject(e.WebMessageAsJson.ToString())
            GMB.totalcontact = GMB.totalcontact + 1
            GMB.Label3.Text = GMB.totalcontact.ToString
            GMB.LstNumbers.Items.Add(New ListViewItem(New String() {ContactResult("name"), ContactResult("number"), ContactResult("website")}))
            Application.DoEvents()
        End If
    End Sub
End Class
