﻿// ------------------------------------------------------------------------------
// <auto-generated>
// 此代码由工具生成。
// 运行时版本:4.0.30319.42000
// 
// 对此文件的更改可能会导致不正确的行为，并且如果
// 重新生成代码，这些更改将会丢失。
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace SPY.My
{
    [System.Runtime.CompilerServices.CompilerGenerated()]
    [System.CodeDom.Compiler.GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.0.1.0")]
    [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    internal sealed partial class MySettings : System.Configuration.ApplicationSettingsBase
    {
        private static MySettings defaultInstance = (MySettings)Synchronized(new MySettings());

        /* TODO ERROR: Skipped RegionDirectiveTrivia *//* TODO ERROR: Skipped IfDirectiveTrivia */
        private static bool addedHandler;
        private static object addedHandlerLockObject = new object();

        [DebuggerNonUserCode()]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        private static void AutoSaveSettings(object sender, EventArgs e)
        {
            if (MyProject.Application.SaveMySettingsOnExit)
            {
                MySettingsProperty.Settings.Save();
            }
        }
        /* TODO ERROR: Skipped EndIfDirectiveTrivia *//* TODO ERROR: Skipped EndRegionDirectiveTrivia */
        public static MySettings Default
        {
            get
            {

                /* TODO ERROR: Skipped IfDirectiveTrivia */
                if (!addedHandler)
                {
                    lock (addedHandlerLockObject)
                    {
                        if (!addedHandler)
                        {
                            MyProject.Application.Shutdown += AutoSaveSettings;
                            addedHandler = true;
                        }
                    }
                }
                /* TODO ERROR: Skipped EndIfDirectiveTrivia */
                return defaultInstance;
            }
        }
    }
}

namespace SPY.My
{
    [HideModuleName()]
    [DebuggerNonUserCode()]
    [System.Runtime.CompilerServices.CompilerGenerated()]
    internal static class MySettingsProperty
    {
        [System.ComponentModel.Design.HelpKeyword("My.Settings")]
        internal static MySettings Settings
        {
            get
            {
                return MySettings.Default;
            }
        }
    }
}