Imports WhatsAppBusinessMarketingSoftware.ClsButtonConfig

Public Class ClsRuleModel
    Public RuleName As String
    Public Operand As String
    Public RuleKeyword As String
    Public RuleMessage As String
    Public Attachment As List(Of ClsAttachment)
    Public RuleStatus As Boolean
    Public ButtonInclude As Boolean
    Public IncludeListButton As Boolean
    Public ButtonConfigData As ButtonConfigData
    Public ButtonListData As LabelRootObject

End Class
