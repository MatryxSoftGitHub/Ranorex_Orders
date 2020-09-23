/*
 * Created by Ranorex
 * User: Matryxsoft
 * Date: 24-10-2019
 * Time: 11:52
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
    /// Description of ListView_RowCount_ColoumnCount.
    /// </summary>
    [TestModule("3BD15FA3-7A33-42CD-9F20-E0183A19CF44", ModuleType.UserCode, 1)]
    
    public class Fetch_AllCellValues : ITestModule
    {
    
    	OrdersAppRepository repo = OrdersAppRepository.Instance;
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Fetch_AllCellValues()
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
		    
           //Get the Row count
           var RowCnt = repo.OrdersApplication.List_View;
           int RowCount = RowCnt.Rows.Count;
           //Report.Log(ReportLevel.Info,"Row Count: "+RowCount.ToString());
           
           
           //Fetch all cell values
           int cellcount = RowCnt.Rows[0].Cells.Count;
           for(int i=0; i<RowCount; i++)
           {
           	for(int j=0; j<cellcount; j++)
           	{
           		String strvalue = RowCnt.Rows[i].Cells[j].Text.ToString();
           		Report.Log(ReportLevel.Info,"Cell values: "+strvalue);
           	}
           }
            
        
        }
    }
}


