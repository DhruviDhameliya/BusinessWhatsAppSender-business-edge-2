Public Class ClsSpecialDirectories

    Public Shared Function GetGetDefaultProfile()
        Dim Result As String = ""
        If Not IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName) Then
            Try
                IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName)
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, Application.ProductName)
                End
            End Try
        End If

        If Not IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & "\DefaultProfile\") Then
            Try
                IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & "\DefaultProfiles\")
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, Application.ProductName)
                End
            End Try
        End If
        Return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & "\DefaultProfiles\"
    End Function
    Public Shared Function GetProfiles()
        Dim Result As String = ""
        If Not IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName) Then
            Try
                IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName)
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, Application.ProductName)
                End
            End Try
        End If

        If Not IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & "\Profiles\") Then
            Try
                IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & "\Profiles\")
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, Application.ProductName)
                End
            End Try
        End If
        Return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & "\Profiles\"
    End Function
    Public Shared Function GetProfilesEngager()
        Dim Result As String = ""
        If Not IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName) Then
            Try
                IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName)
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, Application.ProductName)
                End
            End Try
        End If

        If Not IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & "\EngagerProfiles\") Then
            Try
                IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & "\EngagerProfiles\")
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, Application.ProductName)
                End
            End Try
        End If
        Return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & "\EngagerProfiles\"
    End Function
    Public Shared Function GetAccountFolder() As String
        Dim Result As String = ""
        If Not IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName) Then
            Try
                IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName)
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, Application.ProductName)
                End
            End Try
        End If

        If Not IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & "\accounts\") Then
            Try
                IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & "\accounts\")
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, Application.ProductName)
                End
            End Try
        End If
        Return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & "\accounts\"
    End Function
    Public Shared Function GetCatalog() As String
        Dim Result As String = ""
        If Not IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName) Then
            Try
                IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName)
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, Application.ProductName)
                End
            End Try
        End If

        If Not IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & "\catalogs\") Then
            Try
                IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & "\catalogs\")
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, Application.ProductName)
                End
            End Try
        End If
        Return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & "\catalogs\"
    End Function
    Public Shared Function GetReport()
        Dim Result As String = ""
        If Not IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName) Then
            Try
                IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName)
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, Application.ProductName)
                End
            End Try
        End If

        If Not IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & $"\Reports{ProfileName}\") Then
            Try
                IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & $"\Reports{ProfileName}\")
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, Application.ProductName)
                End
            End Try
        End If

        Return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & $"\Reports{ProfileName}\"
    End Function
    Public Shared Function ButtonsFolder() As String
        Dim Result As String = ""
        If Not IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName) Then
            Try
                IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName)
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, Application.ProductName)
                End
            End Try
        End If

        If Not IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & $"\Buttons\") Then
            Try
                IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & $"\Buttons\")
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, Application.ProductName)
                End
            End Try
        End If

        Return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & $"\buttons\"
    End Function

    Public Shared Function Getdata()
        Dim Result As String = ""
        If Not IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName) Then
            Try
                IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName)
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, Application.ProductName)
                End
            End Try
        End If

        If Not IO.Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & $"\Data{ProfileName}\") Then
            Try
                IO.Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & $"\Data{ProfileName}\")
            Catch ex As Exception
                MsgBox(ex.Message, vbCritical, Application.ProductName)
                End
            End Try
        End If
        Return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\" & Application.ProductName & $"\Data{ProfileName}\"
    End Function
End Class
