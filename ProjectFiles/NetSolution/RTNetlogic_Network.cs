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
using System.Reflection;
//using System.Collections.Generic;
#endregion

public class RTNetlogic_Network : BaseNetLogic
{

public override void Start()
    {
        //Insert code to be executed when the user-defined logic is started
    }

[ExportMethod]
   public void Read_NetworkVariables()
    {
        var system1 = Project.Current.FindObject("System1") as FTOptix.System.System;
        FTOptix.System.NetworkInterface lanInterface = system1.NetworkInterfaces.Get("LAN");
        Log.Info("LAN DHCP Enabled = " + lanInterface.DHCPClientEnabled);
        Log.Info("LAN IP address = " + lanInterface.IPAddress);
        Log.Info("LAN Mask = " + lanInterface.Mask);
        Log.Info("LAN DNS1 = " + lanInterface.DNS1);
        Log.Info("LAN DNS2 = " + lanInterface.DNS2);
        Log.Info("LAN DNS2 = " + lanInterface.DefaultGateway);

        FTOptix.System.NetworkInterface wanInterface = system1.NetworkInterfaces.Get("WAN");
        Log.Info("WAN DHCP Enabled = " + wanInterface.DHCPClientEnabled);
        Log.Info("WAN IP address = " + wanInterface.IPAddress);
        Log.Info("WAN Mask = " + wanInterface.Mask);
        Log.Info("WAN DNS1 = " + wanInterface.DNS1);
        Log.Info("WAN DNS2 = " + wanInterface.DNS2);
        Log.Info("WAN DNS2 = " + wanInterface.DefaultGateway);
         
    }


[ExportMethod]
   public void ToggleDHCP_LAN()
    {
        var system1 = Project.Current.FindObject("System1") as FTOptix.System.System;
        FTOptix.System.NetworkInterface lanInterface = system1.NetworkInterfaces.Get("LAN");
        lanInterface.DHCPClientEnabled = !lanInterface.DHCPClientEnabled;
        Log.Info("LAN DHCP after toggle = " + lanInterface.DHCPClientEnabled);
    }

[ExportMethod]
   public void ToggleDHCP_WAN()
    {
        var system1 = Project.Current.FindObject("System1") as FTOptix.System.System;
        Log.Info("system1 = " + system1);
        FTOptix.System.NetworkInterface wanInterface = system1.NetworkInterfaces.Get("WAN");
        wanInterface.DHCPClientEnabled = !wanInterface.DHCPClientEnabled;
        Log.Info("WAN DHCP after toggle = " + wanInterface.DHCPClientEnabled);
    }

[ExportMethod]
   public void WriteIPandMask_LAN()
    {
        var system1 = Project.Current.FindObject("System1") as FTOptix.System.System;
        Log.Info("system1 = " + system1);
        FTOptix.System.NetworkInterface lanInterface = system1.NetworkInterfaces.Get("LAN");
        lanInterface.IPAddress = "192.168.1.5";
        lanInterface.Mask = "255.255.255.0";
    }

[ExportMethod]
   public void WriteIPandMask_WAN()
    {
        var system1 = Project.Current.FindObject("System1") as FTOptix.System.System;
        Log.Info("system1 = " + system1);
        FTOptix.System.NetworkInterface wanInterface = system1.NetworkInterfaces.Get("WAN");
        wanInterface.IPAddress = "192.168.2.5";
        wanInterface.Mask = "255.255.252.0";
    }

[ExportMethod]
   public void WriteDNSandGateway_LAN()
    {
        var system1 = Project.Current.FindObject("System1") as FTOptix.System.System;
        Log.Info("system1 = " + system1);
        FTOptix.System.NetworkInterface lanInterface = system1.NetworkInterfaces.Get("LAN");
        lanInterface.DNS1 = "192.1.1.1";
        lanInterface.DNS2 = "192.1.1.1";
        lanInterface.DefaultGateway = "192.168.1.0";
    }

[ExportMethod]
   public void WriteDNSandGateway_WAN()
    {
        var system1 = Project.Current.FindObject("System1") as FTOptix.System.System;
        Log.Info("system1 = " + system1);
        FTOptix.System.NetworkInterface wanInterface = system1.NetworkInterfaces.Get("WAN");
        wanInterface.DNS1 = "192.2.2.2";
        wanInterface.DNS2 = "192.2.2.2";
        wanInterface.DefaultGateway = "192.168.2.0";
    }
    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }
}
