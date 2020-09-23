/*
 * Created by Ranorex
 * User: pavani
 * Date: 1/17/2020
 * Time: 5:06 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;

namespace OrdersApp.NewCustomTemplate1
{
	/// <summary>
	/// Description of GetReportName.
	/// </summary>
	[TestModule("E40616F4-20D3-4790-AF11-815A157F8D1D", ModuleType.UserCode, 1)]
	public class GetReportName : ITestModule
	{
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public GetReportName()
		{
			// Do not delete - a parameterless constructor is required!
		}

		/// <summary>
		/// Performs the playback of actions in this module.
		/// </summary>
		/// <remarks>You should not call this method directly, instead pass the module
		/// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
		/// that will in turn invoke this method.</remarks>
		void ITestModule.Run()
		{
			Mouse.DefaultMoveTime = 300;
			Keyboard.DefaultKeyPressTime = 100;
			Delay.SpeedFactor = 1.0;
			String reportName= Ranorex.Core.Reporting.TestReport.ReportEnvironment.ReportName;
			String sFullFilePath = System.Environment.CurrentDirectory;
			Report.Log(ReportLevel.Info,"writeReportName: "+reportName);	
			
			Report.Log(ReportLevel.Info,"Project Directory Path: "+sFullFilePath);
			System.IO.File.WriteAllText("C:\\Temp\\ReportName.txt", reportName);
			String sReportFileName = System.IO.File.ReadAllText("C:\\Temp\\ReportName.txt");
			Report.Log(ReportLevel.Info,"Get project name: "+sReportFileName);
		}
	}
}
