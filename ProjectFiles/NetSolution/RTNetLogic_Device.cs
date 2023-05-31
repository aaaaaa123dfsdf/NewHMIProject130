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
using FTOptix.RAEtherNetIP;
using FTOptix.Retentivity;
using FTOptix.CommunicationDriver;
using FTOptix.CoreBase;
using FTOptix.Core;
#endregion

public class RTNetLogic_Device : BaseNetLogic
{
[ExportMethod]
   public void Read_DeviceVariables()
    {
        Log.Info("Reading Values From Netlogic" );
		
		var system1 = Project.Current.FindObject("System1") as FTOptix.System.System;
        Log.Info("system1 = " + system1);

        var cpuTemp2 = system1.Device.CPUTemperature;
        Log.Info("CPU Temp - from Object =" + cpuTemp2);

		var cpuFrequency2 = system1.Device.CPUFrequency;
        Log.Info("CPU Frequency - from Object =" + cpuFrequency2);

		var cpuUtilization2 = system1.Device.CPUUtilization;
        Log.Info("CPU Utilization - from Object =" + cpuUtilization2);

		var productName2 = system1.Device.ProductName;
        Log.Info("Product Name -from Object =" + productName2);
		
		var catalogNumber2 = system1.Device.CatalogNumber;
        Log.Info("Catalog Number - from Object =" + catalogNumber2);

		var hwProductCode2 = system1.Device.HardwareProductCode;
        Log.Info("HW Product Code - from Object = " + hwProductCode2);

		var hwProductType2 = system1.Device.HardwareProductType;
        Log.Info("Hardware Product Type - from Object = " + hwProductType2);

		var hwSeries2 = system1.Device.HardwareSeries;
        Log.Info("Hardware Series - from Object = " + hwSeries2);

		var hwVersion2 = system1.Device.HardwareVersion;
        Log.Info("Hardware Version - from Object = " + hwVersion2);

		var osVersion2 = system1.Device.OSVersion;
        Log.Info("O/S Version - from Object = " + osVersion2);

		var systemManagerVersion2 = system1.Device.SystemManagerVersion;
        Log.Info("SM Version - from Object = " + systemManagerVersion2);

		var firmwareVersion2 = system1.Device.FirmwareVersion;
        Log.Info("FMW Version - from Object = " + firmwareVersion2);

		var firmwareDate2 = system1.Device.FirmwareDate;
        Log.Info("FMW Date - from Object = " + firmwareDate2);
		
		var lastBootTime2 = system1.Device.LastBootupTime;
        Log.Info("Last Boot time - from Object = " + lastBootTime2);

		var lastAppUpdate2 = system1.Device.LastApplicationUpdateTime;
        Log.Info("Last App update time - from Object = " + lastAppUpdate2);
		
		var totalOnTime2 = system1.Device.TotalOnTime;
        Log.Info("Total on Time - from Object = " + totalOnTime2);
		
		var totalMemory2 = system1.Device.TotalMemory;
        Log.Info("Total Memory - from Object = " + totalMemory2);

		var usedMemory2 = system1.Device.UsedMemory;
        Log.Info("Total Memory - from Object = " + usedMemory2);

		var freeMemory2 = system1.Device.FreeMemory;
        Log.Info("Free Memory - from Object = " + freeMemory2);

		var totalStorage2 = system1.Device.TotalStorage;
        Log.Info("Total Storage - from Object = " + totalStorage2);

		var usedStorage2 = system1.Device.UsedStorage;
        Log.Info("Used Storage - from Object = " + usedStorage2);

		var freeStorage2 = system1.Device.FreeStorage;
        Log.Info("Free Storage - from Object = " + freeStorage2);

		var enetPortCount2 = system1.Device.EthernetPortCount;
        Log.Info("Enet Port Count - from Object = " + enetPortCount2);

		var enetNetworkCount2 = system1.Device.EthernetNetworkCount;
        Log.Info("Enet Network Count - from Object = " + enetNetworkCount2);
		
		var hostName2 = system1.Device.Hostname;
        Log.Info("Host Name - from Object = " + hostName2);
		//system1.Device.Hostname = "Term4RonAA";
		//Log.Info("Host Name written to - from Object = " + hostName2);

		var protectionMode2 = system1.Device.ProtectionModeEnabled;
        Log.Info("Protection Mode Enabled - from Object = " + protectionMode2);
		//system1.Device.ProtectionModeEnabled = true;
		//Log.Info("Protection Mode Written to - from Object = " + protectionMode2);
		
		Log.Info("Completed Reading Values From Netlogic" );
    }

[ExportMethod]
   public void WriteHostName()
    {
        var system1 = Project.Current.FindObject("System1") as FTOptix.System.System;
        system1.Device.Hostname = "Term4RonAA";
		Log.Info("Host Name written = " + system1.Device.Hostname);
    }
	
[ExportMethod]	
	public void ToggleProtectionMode()
    {
        var system1 = Project.Current.FindObject("System1") as FTOptix.System.System;
        system1.Device.ProtectionModeEnabled = !system1.Device.ProtectionModeEnabled;
		Log.Info("Protection Mode Toggled = " + system1.Device.ProtectionModeEnabled);
    }




    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }
}
