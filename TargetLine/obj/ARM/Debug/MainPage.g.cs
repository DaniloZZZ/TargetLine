﻿#pragma checksum "C:\Users\pc\Source\Workspaces\Рабочая область\TargetLine\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "FCBDA2E116B9ABF01367BC07A1FB6803"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TargetLine
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.page = (global::Windows.UI.Xaml.Controls.Page)(target);
                }
                break;
            case 2:
                {
                    this.grid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 3:
                {
                    this.VisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 4:
                {
                    this.BigState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5:
                {
                    this.MiddleState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 6:
                {
                    this.NarrowState = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 7:
                {
                    this.topRow = (global::Windows.UI.Xaml.Controls.RowDefinition)(target);
                }
                break;
            case 8:
                {
                    this.tskCol = (global::Windows.UI.Xaml.Controls.ColumnDefinition)(target);
                }
                break;
            case 9:
                {
                    this.plnCol = (global::Windows.UI.Xaml.Controls.ColumnDefinition)(target);
                }
                break;
            case 10:
                {
                    this.weekDays = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 11:
                {
                    this.TaskList = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 12:
                {
                    this.AddGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 13:
                {
                    this.Menu = (global::Windows.UI.Xaml.Controls.ListView)(target);
                    #line 142 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.Menu).PointerEntered += this.Menu_PointerEntered;
                    #line 142 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListView)this.Menu).PointerExited += this.Menu_PointerExited;
                    #line default
                }
                break;
            case 14:
                {
                    this.TasksADay = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 15:
                {
                    this.TimeGrid = (global::Windows.UI.Xaml.Controls.Grid)(target);
                }
                break;
            case 16:
                {
                    this.OpenMenu = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 17:
                {
                    this.CloseMenu = (global::Windows.UI.Xaml.Media.Animation.Storyboard)(target);
                }
                break;
            case 18:
                {
                    this.AddLabel = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 19:
                {
                    this.CreateTask = (global::Windows.UI.Xaml.Controls.TextBox)(target);
                }
                break;
            case 20:
                {
                    this.AddButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 136 "..\..\..\MainPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.AddButton).Click += this.button_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

