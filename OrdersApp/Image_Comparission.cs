/*
 * Created by Ranorex
 * User: Matryxsoft
 * Date: 08-11-2019
 * Time: 17:19
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
    /// Description of Image_Comparission.
    /// </summary>
    [TestModule("E5BDA8DD-46AB-46C1-946D-7F57CCD22CAD", ModuleType.UserCode, 1)]
    public class Image_Comparission : ITestModule
    {
    	OrdersAppRepository repo = OrdersAppRepository.Instance;
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Image_Comparission()
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
            
            //To Open New order
            repo.OrdersApplication.Btn_Maximize.Click();
			repo.OrdersApplication.Orders.Click();
			repo.Orders.New_Order.Click();
            
            //Capture the image
            
            Bitmap bmp = Ranorex.Imaging.CaptureDesktopImage(repo.NewOrder.Rbtn_MasterCard);
            CompressedImage image = Ranorex.Imaging.CaptureCompressedImage(repo.NewOrder.Rbtn_MasterCard);
            image.Store(@"D:\cmd_img.jpg");
            
	
            //Image Comparision
            
            if (Ranorex.Imaging.Contains(repo.NewOrder.Rbtn_MasterCard,image) == true)
            {
            	Report.Log(ReportLevel.Info,("Image found within Orders application"));
            }
            
           
            
        } 
    }
}
