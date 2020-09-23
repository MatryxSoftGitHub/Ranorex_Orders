/*
 * Created by Ranorex
 * User: Matryxsoft
 * Date: 31-10-2019
 * Time: 14:57
 * Author:Pavani G K
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
	/// Description of FetchAllColumnValues.
	/// </summary>
	[TestModule("FC05E156-F538-4DCF-B2A8-5232EC16D5A0", ModuleType.UserCode, 1)]
	public class Fetch_ParticularColumnValue : ITestModule
	{
		OrdersAppRepository repo = OrdersAppRepository.Instance;
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public Fetch_ParticularColumnValue()
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
			
			// Get the Column count
			
			var ColCnt = repo.OrdersApplication.List_View;
			int ColumnsCount = ColCnt.Columns.Count;
			
			//Get the Row count
			var RowCnt = repo.OrdersApplication.List_View;
			int RowCount = RowCnt.Rows.Count;
			
			//Fetch all column values
			int select_col = 2;
			for(int i=0; i<=ColumnsCount; i++)
			{
				for(int j=0; j<=RowCount;j++)
				{
					if(select_col==i)
					{
						String colvalue = ColCnt.Columns[select_col].Cells[j].Text.ToString();
						Report.Log(ReportLevel.Info,"Coloumn: "+colvalue);
						
						
					}
				}
			}
			
		}
	}
}
