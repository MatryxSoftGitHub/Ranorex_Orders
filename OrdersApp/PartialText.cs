/*
 * Created by Ranorex
 * User: Matryxsoft
 * Date: 31-10-2019
 * Time: 16:48
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

namespace OrdersApp
{
    /// <summary>
    /// Description of PartialText.
    /// </summary>
    [TestModule("EC3995EF-4067-4292-81F8-8C344C951DC8", ModuleType.UserCode, 1)]
    public class PartialText : ITestModule
    {
    	OrdersAppRepository repo = OrdersAppRepository.Instance;
    	
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PartialText()
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
            
            String strvalue;
            Boolean bFound = false;
            //List<string> lsValues;
            string sValue = "Mat";
            int RowCount;
            //Get the Row count
            var RowCnt = repo.OrdersApplication.List_View;
            RowCount = RowCnt.Rows.Count;
            Report.Log(ReportLevel.Info,RowCount.ToString());
            
            int cellcount = RowCnt.Rows[0].Cells.Count;
            for(int i=0; i<RowCount; i++)
            {
            	for(int j=0; j<cellcount; j++)
            	{
            		strvalue = RowCnt.Rows[i].Cells[j].Text.ToString();
            		
            		if (strvalue.Contains (sValue))
            		 {   
            			bFound = true;
            		 }
            		//lsValues.Add(strvalue);
            		Report.Log(ReportLevel.Info,strvalue);
            	}
            } 
            if (bFound == true)
            {
            	Report.Log(ReportLevel.Info, "Searched PartialText Text is Found");
            		
            }
            else
            {
            	Report.Log(ReportLevel.Info,"Searched PartialText is not found");
            }
        }
    }
}
