﻿//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2015 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.Email. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////

using System.IO;
using System;
using Aspose.Email.Mail;
using Aspose.Email.Outlook;
using Aspose.Email.Pop3;
using Aspose.Email;
using Aspose.Email.Mime;
using Aspose.Email.Imap;

namespace CSharp.IMAP
{
    class SSLEnabledIMAPServer
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_IMAP();
            string dstEmail = dataDir + "1234.eml";

            //Create an instance of the ImapClient class
            ImapClient client = new ImapClient();

            //Specify host, username and password for your client
            client.Host = "imap.gmail.com";

            // Set username
            client.Username = "your.username@gmail.com";

            // Set password
            client.Password = "your.password";

            // Set the port to 993. This is the SSL port of IMAP server
            client.Port = 993;

            // Enable SSL
            client.SecurityOptions = SecurityOptions.Auto;

            try
            {
                System.Console.WriteLine("Logged in to the IMAP server");

                //Disconnect to the remote IMAP server
                client.Disconnect();
                System.Console.WriteLine("Disconnected from the IMAP server");

            }
            catch (Exception ex)
            {
                System.Console.Write(Environment.NewLine + ex.ToString());
            }

            Console.WriteLine(Environment.NewLine + "Connected to IMAP server with SSL.");
        }
    }
}
