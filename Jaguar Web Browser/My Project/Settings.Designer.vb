﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace My
    
    <Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.0.1.0"),  _
     Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
    Partial Friend NotInheritable Class MySettings
        Inherits Global.System.Configuration.ApplicationSettingsBase
        
        Private Shared defaultInstance As MySettings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New MySettings()),MySettings)
        
#Region "My.Settings Auto-Save Functionality"
#If _MyType = "WindowsForms" Then
    Private Shared addedHandler As Boolean

    Private Shared addedHandlerLockObject As New Object

    <Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Private Shared Sub AutoSaveSettings(sender As Global.System.Object, e As Global.System.EventArgs)
        If My.Application.SaveMySettingsOnExit Then
            My.Settings.Save()
        End If
    End Sub
#End If
#End Region
        
        Public Shared ReadOnly Property [Default]() As MySettings
            Get
                
#If _MyType = "WindowsForms" Then
               If Not addedHandler Then
                    SyncLock addedHandlerLockObject
                        If Not addedHandler Then
                            AddHandler My.Application.Shutdown, AddressOf AutoSaveSettings
                            addedHandler = True
                        End If
                    End SyncLock
                End If
#End If
                Return defaultInstance
            End Get
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("3")>  _
        Public Property Theme() As Short
            Get
                Try
                    Return CType(Me("Theme"), Short)
                Catch ex As Exception

                End Try

            End Get
            Set
                Try
                    Me("Theme") = Value
                Catch ex As Exception

                End Try
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property SearchEngine() As String
            Get
                Return CType(Me("SearchEngine"),String)
            End Get
            Set
                Try
                    Me("SearchEngine") = Value
                Catch ex As Exception

                End Try
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property IncognitoSearchEngine() As Short
            Get
                Return CType(Me("IncognitoSearchEngine"),Short)
            End Get
            Set
                Me("IncognitoSearchEngine") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Startup() As String
            Get
                Return CType(Me("Startup"),String)
            End Get
            Set
                Me("Startup") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("<?xml version=""1.0"" encoding=""utf-16""?>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<ArrayOfString xmlns:xsi=""http://www.w3."& _ 
            "org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" />")>  _
        Public Property History() As Global.System.Collections.Specialized.StringCollection
            Get
                Try
                    Return CType(Me("History"), Global.System.Collections.Specialized.StringCollection)
                Catch ex As Exception

                End Try
            End Get
            Set
                Me("History") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property Homepage() As String
            Get
                Try
                    Return CType(Me("Homepage"), String)
                Catch ex As Exception

                End Try
            End Get
            Set
                Me("Homepage") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property HomeURL() As String
            Get
                Return CType(Me("HomeURL"),String)
            End Get
            Set
                Me("HomeURL") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property SpecificURL() As String
            Get
                Try
                    Return CType(Me("SpecificURL"), String)
                Catch ex As Exception

                End Try
            End Get
            Set
                Me("SpecificURL") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property StartupLOAD() As Short
            Get
                Try
                    Return CType(Me("StartupLOAD"), Short)
                Catch ex As Exception

                End Try
            End Get
            Set
                Try
                    Me("StartupLOAD") = Value
                Catch ex As Exception

                End Try
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property HistoryCOUNT() As Integer
            Get
                Return CType(Me("HistoryCOUNT"),Integer)
            End Get
            Set
                Me("HistoryCOUNT") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property SearchEngineINDEX() As Short
            Get
                Try
                    Return CType(Me("SearchEngineINDEX"), Short)
                Catch ex As Exception

                End Try
            End Get
            Set
                Try
                    Me("SearchEngineINDEX") = Value
                Catch ex As Exception

                End Try
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property BookmarksCOUNT() As Integer
            Get
                Return CType(Me("BookmarksCOUNT"),Integer)
            End Get
            Set
                Me("BookmarksCOUNT") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("<?xml version=""1.0"" encoding=""utf-16""?>"&Global.Microsoft.VisualBasic.ChrW(13)&Global.Microsoft.VisualBasic.ChrW(10)&"<ArrayOfString xmlns:xsi=""http://www.w3."& _ 
            "org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"" />")>  _
        Public Property Bookmarks() As Global.System.Collections.Specialized.StringCollection
            Get
                Return CType(Me("Bookmarks"),Global.System.Collections.Specialized.StringCollection)
            End Get
            Set
                Me("Bookmarks") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property Language() As Short
            Get
                Try
                    Return CType(Me("Language"), Short)
                Catch ex As Exception

                End Try

            End Get
            Set
                Try
                    Me("Language") = Value
                Catch ex As Exception

                End Try
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property BookmarkBarVisibility() As Boolean
            Get
                Try
                    Return CType(Me("BookmarkBarVisibility"), Boolean)
                Catch ex As Exception

                End Try
            End Get
            Set
                Me("BookmarkBarVisibility") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property DownloadPath() As String
            Get
                Return CType(Me("DownloadPath"),String)
            End Get
            Set
                Me("DownloadPath") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("False")>  _
        Public Property DownloadOptionSaveToLocation() As Boolean
            Get
                Return CType(Me("DownloadOptionSaveToLocation"),Boolean)
            End Get
            Set
                Me("DownloadOptionSaveToLocation") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property DownloadOptionLemmeSave() As Boolean
            Get
                Return CType(Me("DownloadOptionLemmeSave"),Boolean)
            End Get
            Set
                Me("DownloadOptionLemmeSave") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("True")>  _
        Public Property FirstRun() As Boolean
            Get
                Try
                    Return CType(Me("FirstRun"), Boolean)
                Catch ex As Exception

                End Try

            End Get
            Set
                Me("FirstRun") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property MHPBackground() As String
            Get
                Return CType(Me("MHPBackground"),String)
            End Get
            Set
                Me("MHPBackground") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property MHPSound() As String
            Get
                Return CType(Me("MHPSound"),String)
            End Get
            Set
                Me("MHPSound") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("")>  _
        Public Property MHPVideoBackground() As String
            Get
                Return CType(Me("MHPVideoBackground"),String)
            End Get
            Set
                Me("MHPVideoBackground") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property MHPSearchFieldX() As Integer
            Get
                Return CType(Me("MHPSearchFieldX"),Integer)
            End Get
            Set
                Me("MHPSearchFieldX") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property MHPSearchFieldY() As Integer
            Get
                Return CType(Me("MHPSearchFieldY"),Integer)
            End Get
            Set
                Me("MHPSearchFieldY") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property MHPSearchButtonX() As Integer
            Get
                Return CType(Me("MHPSearchButtonX"),Integer)
            End Get
            Set
                Me("MHPSearchButtonX") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
         Global.System.Configuration.DefaultSettingValueAttribute("0")>  _
        Public Property MHPSearchButtonY() As Integer
            Get
                Return CType(Me("MHPSearchButtonY"),Integer)
            End Get
            Set
                Me("MHPSearchButtonY") = value
            End Set
        End Property
        
        <Global.System.Configuration.UserScopedSettingAttribute(),  _
         Global.System.Diagnostics.DebuggerNonUserCodeAttribute()>  _
        Public Property MHPColor() As Global.System.Drawing.Color
            Get
                Return CType(Me("MHPColor"),Global.System.Drawing.Color)
            End Get
            Set
                Me("MHPColor") = value
            End Set
        End Property
    End Class
End Namespace

Namespace My
    
    <Global.Microsoft.VisualBasic.HideModuleNameAttribute(),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Module MySettingsProperty
        
        <Global.System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")>  _
        Friend ReadOnly Property Settings() As Global.WindowsApplication1.My.MySettings
            Get
                Return Global.WindowsApplication1.My.MySettings.Default
            End Get
        End Property
    End Module
End Namespace
