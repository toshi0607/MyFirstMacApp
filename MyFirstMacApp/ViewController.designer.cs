// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace MyFirstMacApp
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField NameField { get; set; }

		[Action ("ShowGreeting:")]
		partial void ShowGreeting (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (NameField != null) {
				NameField.Dispose ();
				NameField = null;
			}
		}
	}
}
