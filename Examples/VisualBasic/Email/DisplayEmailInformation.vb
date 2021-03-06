﻿' ///////////////////////////////////////////////////////////////////////
' Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Email. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
' ///////////////////////////////////////////////////////////////////////

Imports System.IO
Imports Aspose.Email.Mail
Imports Aspose.Email.Outlook
Imports Aspose.Email.Pop3
Imports Aspose.Email
Imports Aspose.Email.Mime
Imports Aspose.Email.Imap
Imports System.Configuration
Imports System.Data
Imports Aspose.Email.Mail.Bounce

Public Class DisplayEmailInformation
    Public Shared Sub Run()
        ' The path to the documents directory.
        Dim dataDir As String = RunExamples.GetDataDir_Email()
        Dim dstEmail As String = dataDir & Convert.ToString("test.eml")

        Dim message As MailMessage

        'Create MailMessage instance by loading an Eml file
        message = MailMessage.Load(dataDir & Convert.ToString("test.eml"), MailMessageLoadOptions.DefaultEml)

        System.Console.Write("From:")

        'Gets the sender info
        System.Console.WriteLine(message.From)
        System.Console.Write("To:")

        'Gets the recipient info
        System.Console.WriteLine(message.[To])
        System.Console.Write("Subject:")

        'Gets the subject
        System.Console.WriteLine(message.Subject)
        System.Console.WriteLine("HtmlBody:")

        'Gets the htmlbody 
        System.Console.WriteLine(message.HtmlBody)
        System.Console.WriteLine("TextBody")

        'Gets the textbody
        System.Console.WriteLine(message.Body)

        Console.WriteLine(Environment.NewLine + "Displayed email information from " & dstEmail)
    End Sub
End Class
