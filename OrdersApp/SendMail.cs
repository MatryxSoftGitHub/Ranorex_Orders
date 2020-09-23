/*
 * Created by Ranorex
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Net.Mail;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace Ranorex.Modules
{
	/// <summary>
	/// Use this module at any position of your test suite to get informed about test runs by email.
	/// This is especially useful for overnight test executions on runtime machines.
	/// </summary>
	
	[TestModule("EEE7C8D8-D950-40EF-B24A-1A9A87C0DA21", ModuleType.UserCode, 1)]
	public class SendMailModule : ITestModule
	{
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public SendMailModule()
		{
			// Do not delete - a parameterless constructor is required!
		}

		#region Variables

		string _to = "pavani@matryxsoft.com";
		
		[TestVariable("D089186D-7919-4023-8165-B68F9151C6A7")]
		public string To
		{
			get { return _to; }
			set { _to = value; }
		}
		
		string _from = "regression@matryxsoft.com";
		
		[TestVariable("BDB3FC8C-1E51-448F-9049-AEF0B247DBDB")]
		public string From
		{
			get { return _from; }
			set { _from = value; }
		}

		string _subject = "Ranorex Module Report";

		[TestVariable("398FF772-C15C-4b91-954B-34CC636DEDC9")]
		public string Subject
		{
			get { return _subject; }
			set { _subject = value; }
		}
		
		string _serverHostName = "matryxsoft.com";
		
		[TestVariable("0EE4CB1E-D738-4DE8-B122-92B3CCE6F70C")]
		public string ServerHostname
		{
			get { return _serverHostName; }
			set { _serverHostName = value; }
		}
		
		string _serverPort = "25";
		
		[TestVariable("4C6A889D-BACE-4AE1-9EEF-40EA26775574")]
		public string ServerPort
		{
			get { return _serverPort; }
			set { _serverPort = value; }
		}
		
		string _message = "Hi PFA of the Test report";
		
		[TestVariable("D49672F4-3021-4460-96DA-2EC11AE318A8")]
		public string Message
		{
			get { return _message; }
			set { _message = value; }
		}

		string _ReportName = "\\ReportName.txt";
		[TestVariable("21674412-6dc0-468e-a0b7-4fe014b841c2")]
		public string ReportName
		{
			get { return _ReportName; }
			set { _ReportName = value; }
		}

		#endregion
		
		
		void ITestModule.Run()
		{
			System.Threading.Thread.Sleep(70000);
			
			SendMail();
		}


		void SendMail()
		{
			
			try
			{
				MailMessage mail = new MailMessage(From, To, Subject, Message);
				
				String FileName = Ranorex.Core.Reporting.TestReport.ReportEnvironment.ReportFileDirectory;
				Report.Log(ReportLevel.Info,"FileName: "+FileName);
				
				//Read the full report path with report file name
				String sFullFilePath = System.Environment.CurrentDirectory;
				String sFullFileNameWithPath = sFullFilePath + ReportName;
				String reportName = System.IO.File.ReadAllText(sFullFileNameWithPath);
				Report.Log(ReportLevel.Info,"ReportName: "+reportName);
				
				
				//adds the zipped report to the mail
				while (!System.IO.File.Exists(FileName+"\\"+reportName+".pdf"))
				{
					Report.Log(ReportLevel.Info,"not exist: ");
					
					System.Threading.Thread.Sleep(1000);
				}
				System.Net.Mail.Attachment MyReport = new System.Net.Mail.Attachment(FileName+"\\"+reportName+".pdf");
				Report.Log(ReportLevel.Info,"myreport: "+MyReport);
				
				mail.Attachments.Add (MyReport);
				
				SmtpClient smtp = new SmtpClient(ServerHostname, int.Parse(ServerPort));
				smtp.Credentials = new System.Net.NetworkCredential("regression@matryxsoft.com", "Matryx@2020");

				
				//add the following line before Send()
				smtp.Timeout = 50000;
				smtp.Send(mail);
				Report.Success("Email has been sent to '" + To + "'.");
			}
			
			
			catch(Exception ex)
			{
				Report.Failure("Mail Error: " + ex.ToString());
			}
		}
	}
}

