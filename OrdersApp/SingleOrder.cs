/*
 * Created by Ranorex
 * User: Matryxsoft
 * Date: 22-10-2019
 * Time: 11:46
 * 
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
	/// Description of CodeModule_Orders.
	/// </summary>
	[TestModule("9C7EB5B7-FA41-4B25-BAF9-8B04E0A9FAE6", ModuleType.UserCode, 1)]
	public class SingleOrder : ITestModule
	{
		OrdersAppRepository repo = OrdersAppRepository.Instance;
		
		#region Variables
		
		string _CustomerName = "Matryx";
		[TestVariable("4fbe9dc4-9292-4cd4-b2b3-e1f53b2851d8")]
		public string CustomerName
		{
			get { return _CustomerName; }
			set { _CustomerName = value; }
		}
		
		
		string _Street = "hebbal";
		[TestVariable("4a5300c0-eb8c-4950-8b93-82e72470c7c3")]
		public string Street
		{
			get { return _Street; }
			set { _Street = value; }
		}
		
		string _City = "Bnglr";
		[TestVariable("9b5888c7-69bc-49d2-b89c-a5404c25924b")]
		public string City
		{
			get { return _City; }
			set { _City = value; }
		}
		
		string _State = "kar";
		[TestVariable("b89aa0f1-5e9d-47b4-ac09-3d30b866281e")]
		public string State
		{
			get { return _State; }
			set { _State = value; }
		}
		string _Zip = "560045";
		[TestVariable("be565369-e2b5-4ea3-bd34-d3ac387d0b71")]
		public string Zip
		{
			get { return _Zip; }
			set { _Zip = value; }
		}
		
		
		
		string _Card = "Master Card";
		[TestVariable("94f444ff-05d2-4550-a0c5-1595d84d1873")]
		public string Card
		{
			get { return _Card; }
			set { _Card = value; }
		}
		
		
		
		string _CardNum = "65378456398432";
		[TestVariable("a61c7f50-1f4e-492c-bf97-b6b63a00c71f")]
		public string CardNum
		{
			get { return _CardNum; }
			set { _CardNum = value; }
		}
		
		
		
		
		string _Product = "FamilyAlbum";
		[TestVariable("98414687-6957-438a-9cca-b16ea2c669bc")]
		public string Product
		{
			get { return _Product; }
			set { _Product = value; }
		}
		
		
		
		string _Start_Date = "25";
		[TestVariable("65714178-5ccc-4173-9c88-3190224e9962")]
		public string Start_Date
		{
			get { return _Start_Date; }
			set { _Start_Date = value; }
		}
		
		
		string _Start_Month = "10";
		[TestVariable("d3b42009-4d33-4bbe-ad02-59d883bbc301")]
		public string Start_Month
		{
			get { return _Start_Month; }
			set { _Start_Month = value; }
		}
		
		string _Start_Year = "2019";
		[TestVariable("e48e0796-92d8-4f1b-a874-99f399b2577a")]
		public string Start_Year
		{
			get { return _Start_Year; }
			set { _Start_Year = value; }
		}
		
		
		string _Expiration_Date = "31";
		[TestVariable("b2c5888e-b057-4064-b80f-6e52fd1f8747")]
		public string Expiration_Date
		{
			get { return _Expiration_Date; }
			set { _Expiration_Date = value; }
		}
		
		
		string _Expiration_Month = "11";
		[TestVariable("e40d95c9-54eb-4ddf-ab81-545a30fc13f3")]
		public string Expiration_Month
		{
			get { return _Expiration_Month; }
			set { _Expiration_Month = value; }
		}
		
		string _Expiration_Year = "2021";
		[TestVariable("b9f0e6b0-ec18-4b5e-953d-8bfc3cd5ee5a")]
		public string Expiration_Year
		{
			get { return _Expiration_Year; }
			set { _Expiration_Year = value; }
		}
		
        #endregion
        
        
		/// <summary>
		/// Constructs a new instance.
		/// </summary>
		public SingleOrder()
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
			try
			{
			repo.OrdersApplication.Btn_Maximize.Click();
			repo.OrdersApplication.Orders.Click();
			repo.Orders.New_Order.Click();
			
			//To select the product
			repo.NewOrder.Cbo_ProductType.Click();
			for (int i =0; i<repo.NewOrder.Cbo_ProductType.Items.Count;i++)
				if(Product.Equals(repo.NewOrder.Cbo_ProductType.Items[i].Text))
					repo.NewOrder.Cbo_ProductType.Items[i].Click();
			
			repo.NewOrder.sStartDate_Month.Click();
			repo.NewOrder.sStartDate_Month.PressKeys(Start_Month);
			repo.NewOrder.sStartDate_Date.Click();
			repo.NewOrder.sStartDate_Date.PressKeys(Start_Date);
			repo.NewOrder.sStartDate_Year.Click();
			repo.NewOrder.sStartDate_Year.PressKeys(Start_Year);
			repo.NewOrder.sCustomerName.TextValue = CustomerName;
			repo.NewOrder.sStreet.TextValue = Street;
			repo.NewOrder.sCity.TextValue = City;
			
			// Text based validation
			if (repo.NewOrder.sCity.TextValue.Equals(City))
			    {
			    	Report.Log(ReportLevel.Info,("Verified Succesfully :" +City.ToString()));
			    }
			    
			repo.NewOrder.sState.TextValue = State;
			repo.NewOrder.sZip.TextValue = Zip;
			repo.NewOrder.sExpirationDate_Month.Click();
			repo.NewOrder.sExpirationDate_Month.PressKeys(Expiration_Month);
			repo.NewOrder.sExpirationDate_Date.Click();
			repo.NewOrder.sExpirationDate_Date.PressKeys(Expiration_Date);
			repo.NewOrder.sExpirationDate_Year.Click();
			repo.NewOrder.sExpirationDate_Year.PressKeys(Expiration_Year);
			
			//To select the card
			switch(Card)
			{
				case "VISA":
					repo.NewOrder.Rbtn_VISA.Select();
					repo.NewOrder.Rbtn_VISA.Click();
					break;
				case "Master Card":
					repo.NewOrder.Rbtn_MasterCard.Select();
					repo.NewOrder.Rbtn_MasterCard.Click();
					break;
				case "American Express":
					repo.NewOrder.Rbtn_AmericanExpress.Select();
					repo.NewOrder.Rbtn_AmericanExpress.Click();
					break;
			}
		
			repo.NewOrder.sCardNum.TextValue = CardNum;
			repo.NewOrder.Btn_OK.Click();
			Report.Log(ReportLevel.Info, "Details added to New Order successsfully");
			}
			
			catch(Exception e)
			{
				Report.Log(ReportLevel.Info, "Not found:",e.Message);
			}
			 
		}
	}
}
