﻿/*
 * Created by Ranorex
 * User: Matryxsoft
 * Date: 06-11-2019
 * Time: 16:47
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
    /// Description of Fetch_RowsCount.
    /// </summary>
    [TestModule("DDC8374F-FF38-4A64-AE5E-378221D33223", ModuleType.UserCode, 1)]
    public class Fetch_RowCount : ITestModule
    {
    	OrdersAppRepository repo = OrdersAppRepository.Instance;
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Fetch_RowCount()
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
            Report.Log(ReportLevel.Info,"Row Count: "+RowCount.ToString());
            
            
            
            
        }
    }
}
