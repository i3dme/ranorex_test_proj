﻿/*
 * Created by Ranorex
 * User: automation
 * Date: 2/13/2016
 * Time: 5:18 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
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

namespace Test_Proj_2
{
    /// <summary>
    /// Description of OpenFireFox.
    /// </summary>
    [TestModule("787747DE-D4BE-4B00-AF30-8CECBF73577A", ModuleType.UserCode, 1)]
    public class OpenChrome : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public OpenChrome()
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
            
            ///Open the browser and website
            Host.Local.OpenBrowser("www.americanairlines.com","chrome");
            
        }
    }
}
