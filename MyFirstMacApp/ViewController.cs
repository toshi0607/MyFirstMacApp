﻿using System;

using AppKit;
using Foundation;

namespace MyFirstMacApp
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Do any additional setup after loading the view.
        }

        public override void ViewDidAppear()
        {
            View.Window.StyleMask &= ~NSWindowStyle.Resizable;
            base.ViewDidAppear();
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
                // Update the view, if already loaded.
            }
        }

        partial void ShowGreeting(NSObject sender)
        {
            var name = string.IsNullOrEmpty(NameField.StringValue)
                ? "だれか"
                : NameField.StringValue;
            var msg = $"こんにちは、{name}さん！";
            var version = NSProcessInfo.ProcessInfo.OperatingSystemVersionString;
            using (var alert = new NSAlert())
            {
                alert.MessageText = msg;
                alert.InformativeText = version;
                alert.RunSheetModal(View.Window);
            }

        }
    }
}
