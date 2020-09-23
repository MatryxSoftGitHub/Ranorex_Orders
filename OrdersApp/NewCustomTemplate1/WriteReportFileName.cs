/*
 * Created by Ranorex
 * User: pavani
 * Date: 1/17/2020
 * Time: 5:38 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
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
    /// Description of WriteReportFileName.
    /// </summary>
    [TestModule("9BEFE177-34E9-4E39-BEC0-1F9FB9C45624", ModuleType.UserCode, 1)]
    public class WriteReportFileName : ITestModule
    {
    	
    string _ReportName = "\\ReportName.txt";
    [TestVariable("fe3525be-22ff-4a0d-a779-e2d68cdf5d56")]
    public string ReportName
    {
    	get { return _ReportName; }
    	set { _ReportName = value; }
    }
    
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public WriteReportFileName()
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
            
            //Write the report file name
            String sFullFilePath = System.Environment.CurrentDirectory;
            String reportName= Ranorex.Core.Reporting.TestReport.ReportEnvironment.ReportName;
            Report.Log(ReportLevel.Info,"Project Directory Path: "+sFullFilePath);
            String sFullFileNameWithPath = sFullFilePath + ReportName;
            Report.Log(ReportLevel.Info,"Project Directory Path: "+sFullFileNameWithPath);
			System.IO.File.WriteAllText(sFullFileNameWithPath, reportName);
        }
    }
}
