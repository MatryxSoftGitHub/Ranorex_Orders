/*
 * Created by Ranorex
 * User: Matryxsoft
 * Date: 31-10-2019
 * Time: 14:55
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
    /// Description of FetchAllRowValues.
    /// </summary>
    [TestModule("7E832124-C7D7-49A3-9066-DB0C9E9FB54B", ModuleType.UserCode, 1)]
    public class Fetch_ParticularRowValue : ITestModule
    {
    	OrdersAppRepository repo = OrdersAppRepository.Instance;
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Fetch_ParticularRowValue()
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
            
            //Fetch all row values
            int select_row = 0;
            int cell_count = RowCnt.Rows[0].Cells.Count;
            for(int i=0; i<=RowCount; i++)
            {
            	for(int j=0; j<cell_count; j++)
            	{
            		if(i == select_row)
            		{
            			String rowvalue = RowCnt.Rows[select_row].Cells[j].Text.ToString();
            			Report.Log(ReportLevel.Info,"Row Value: "+rowvalue);
            		}
            	}
            }
        
        
        }
    }
}
