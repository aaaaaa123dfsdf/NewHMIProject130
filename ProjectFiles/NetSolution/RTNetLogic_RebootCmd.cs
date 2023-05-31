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

public class RTNetLogic_RebootCmd : BaseNetLogic
{
[ExportMethod]  
   public void RebootNet()
    {
        var system1 = Project.Current.FindObject("System1") as FTOptix.System.System;
        Log.Info("Reboot called using .net module");
        system1.Reboot();
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }
}
