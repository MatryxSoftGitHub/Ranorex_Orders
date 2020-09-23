/*
 * Created by Ranorex
 * User: Matryxsoft
 * Date: 11/29/2019
 * Time: 12:27 PM
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
    /// Description of Random_RowValue.
    /// </summary>
    [TestModule("8311CA9C-C7BB-4F8D-A8C4-261905F16CCA", ModuleType.UserCode, 1)]
    public class Fetch_RandomRowValue : ITestModule
    {
    	OrdersAppRepository repo = OrdersAppRepository.Instance;
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Fetch_RandomRowValue()
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
            
            //Get Row Count
            var RowCnt = repo.OrdersApplication.List_View;
            int RowCount = RowCnt.Rows.Count;
            
            //Get Random Row Value
            Random rnd = new Random();
            int Random_Value = rnd.Next(0,RowCount);
            int cell_count = RowCnt.Rows[0].Cells.Count;
            for(int j=0; j<cell_count; j++)
            {
            	String R_Value = RowCnt.Rows[Random_Value].Cells[j].Text.ToString();
            	Report.Log(ReportLevel.Info,"Random row value: " +R_Value);
            }
            
        }
    }
}
