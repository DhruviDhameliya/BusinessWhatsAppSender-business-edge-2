Public Class ClsButtonConfig
    Public Class ButtonData
        Public Property ButtonType As String
        Public Property Value As String
        Public Property Text As String
    End Class

    Public Class ButtonConfigData
        Public Property title As String
        Public Property footer As String
        Public Property body As String
        Public Property isReply As Boolean
        Public Property buttons As List(Of ButtonData)
    End Class

    Public Class LabelRootObject
        Public Property buttonText As String
        Public Property description As String
        Public Property sections As List(Of LabelSection)
    End Class

    Public Class LabelSection
        Public Property title As String
        Public Property rows As List(Of LabelRow)
    End Class

    Public Class LabelRow
        Public Property rowId As String
        Public Property title As String
        Public Property description As String
    End Class
End Class
