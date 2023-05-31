#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.NetLogic;
using FTOptix.NativeUI;
using FTOptix.System;
using FTOptix.UI;
using FTOptix.WebUI;
using FTOptix.Retentivity;
using FTOptix.CoreBase;
using FTOptix.Core;
#endregion

public class RTNetLogic_Display : BaseNetLogic
{

[ExportMethod]
   public void Read_DisplayVariables()
    {
        Log.Info("Reading Values From Netlogic" );
		
		var system1 = Project.Current.FindObject("System1") as FTOptix.System.System;
        Log.Info("system1 = " + system1);

        var brightness = system1.Display.Brightness;
        Log.Info("Brightness = " + brightness);

        var scale = system1.Display.Scale;
        Log.Info("Scale = " + scale);

        var orientation = system1.Display.Orientation;
        Log.Info("Orientation = " + orientation);

        var resolutionVertical = system1.Display.VerticalResolution;
        Log.Info("Vertical Resolution = " + resolutionVertical);

        var resolutionHorizontal = system1.Display.HorizontalResolution;
        Log.Info("Horizontal Resolution = " + resolutionHorizontal);

        var blinkFast = system1.Application.FastBlink;
        Log.Info("Fast Blink = " + blinkFast);

        var blinkMedium = system1.Application.MediumBlink;
        Log.Info("Medium Blink = " + blinkMedium);

        var blinkSlow = system1.Application.SlowBlink;
        Log.Info("Slow Blink = " + blinkSlow);
    }

[ExportMethod]
   public void Write_Brightness()
    {
		var system1 = Project.Current.FindObject("System1") as FTOptix.System.System;
        system1.Display.Brightness = 8;
    }

[ExportMethod]
   public void Write_Orientation()
    {
		var system1 = Project.Current.FindObject("System1") as FTOptix.System.System;
        system1.Display.Orientation = DisplayOrientation.PortraitFlipped;
        //system1.Display.Orientation = DisplayOrientation.Portrait;
    }

[ExportMethod]
   public void Write_Scale()
    {
        
		var system1 = Project.Current.FindObject("System1") as FTOptix.System.System;
        system1.Display.Scale = 75;
    }



    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }
}
