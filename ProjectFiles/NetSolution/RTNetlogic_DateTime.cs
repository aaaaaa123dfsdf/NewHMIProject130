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
using System.Threading;
using System.Collections.Generic;
#endregion

public class RTNetlogic_DateTime : BaseNetLogic
{
    
    
[ExportMethod]    
    public void Read_DateTimeVariables_HMI55()
    {
        var system1 = Project.Current.FindObject("System1") as FTOptix.System.System;
        Log.Info("system1 = " + system1);

        var syncMode2 = system1.DateAndTime.SynchronizationMode;
        Log.Info("Sync Mode - from Object =" + syncMode2);

        var timeZone2 = system1.DateAndTime.TimeZone;
        Log.Info("time zone - from Object =" + timeZone2);

        var remoteNTPServer2 = system1.DateAndTime.RemoteNTPServer;
        Log.Info("RemoteNTP server - from Object =" + remoteNTPServer2);

        var localNTPServer2 = system1.DateAndTime.LocalNTPServerInterfaces[0];
        Log.Info("LocalNTP Server index 0 - from Object =" + localNTPServer2);

        var dateTime2 = system1.DateAndTime.DateTime;
        Log.Info("Date Time - from Object =" + dateTime2); 
    }

[ExportMethod]    
    public void Read_DateTimeVariables_HMI80()
    {
        var system1 = Project.Current.FindObject("System1") as FTOptix.System.System;
        Log.Info("system1 = " + system1);

        var syncMode2 = system1.DateAndTime.SynchronizationMode;
        Log.Info("Sync Mode - from Object =" + syncMode2);

        var timeZone2 = system1.DateAndTime.TimeZone;
        Log.Info("time zone - from Object =" + timeZone2);

        var remoteNTPServer2 = system1.DateAndTime.RemoteNTPServer;
        Log.Info("RemoteNTP server - from Object =" + remoteNTPServer2);

        var localNTPServer2 = system1.DateAndTime.LocalNTPServerInterfaces[0];
        Log.Info("LocalNTP Server index 0 - from Object =" + localNTPServer2);

        var localNTPServer2a = system1.DateAndTime.LocalNTPServerInterfaces[1];
        Log.Info("LocalNTP Server index 1- from Object =" + localNTPServer2a);

        var dateTime2 = system1.DateAndTime.DateTime;
        Log.Info("Date Time - from Object =" + dateTime2);
        
    }


[ExportMethod]
    public void WriteRemoteNTP()
    {
        var system1 = Project.Current.FindObject("System1") as FTOptix.System.System;
        
        var remoteNTPServer2 = system1.DateAndTime.RemoteNTPServer;
        Log.Info("RemoteNTP server before write - from Object =" + remoteNTPServer2);

        system1.DateAndTime.RemoteNTPServer = "193.204.114.232";
        Thread.Sleep(2000);
        Log.Info("RemoteNTP server after write - from Object =" + system1.DateAndTime.RemoteNTPServer);
    }

    [ExportMethod]
    public void WriteTimeZone()
    {
        var system1 = Project.Current.FindObject("System1") as FTOptix.System.System;
        
        var timeZone = system1.DateAndTime.TimeZone;
        Log.Info("TimeZone before write - from Object =" + timeZone);

        system1.DateAndTime.TimeZone = "America/Vancouver";
        Log.Info("TimeZone after write - from Object =" + system1.DateAndTime.TimeZone);
    }

    [ExportMethod]
    public void WriteDateTime()
    {
        var system1 = Project.Current.FindObject("System1") as FTOptix.System.System;

        var dateTime = system1.DateAndTime.DateTime;
        Log.Info("DateTime before write - from Object =" + dateTime);

        system1.DateAndTime.DateTime = new System.DateTime(2023,04,16,12,12,12);
        Log.Info("DateTime after write - from Object =" + system1.DateAndTime.DateTime);
    }

    [ExportMethod]
    public void WriteLocalNTP_LAN()
    //   Only works on HMI55 terminal due terminal having only 1 port and how arrays are structured
    {
        var system1 = Project.Current.FindObject("System1") as FTOptix.System.System;

        List<string> listOfEnabledLocalNTPServerInterfaces = new();
        listOfEnabledLocalNTPServerInterfaces.Add("LAN");
        system1.DateAndTime.LocalNTPServerInterfaces = listOfEnabledLocalNTPServerInterfaces.ToArray();
        Log.Info("Local NTP after write - from Object =" + system1.DateAndTime.LocalNTPServerInterfaces[0]);
        listOfEnabledLocalNTPServerInterfaces.Clear();

    }

    [ExportMethod]
    public void WriteLocalNTP_LAN_WAN()
    //   Only works on HMI80 terminal due terminal having 2 ports and how arrays are structured
    {
        var system1 = Project.Current.FindObject("System1") as FTOptix.System.System;

        List<string> listOfEnabledLocalNTPServerInterfaces = new();
        
        listOfEnabledLocalNTPServerInterfaces.Add("LAN");
        listOfEnabledLocalNTPServerInterfaces.Add("WAN");

        system1.DateAndTime.LocalNTPServerInterfaces = listOfEnabledLocalNTPServerInterfaces.ToArray();
        Log.Info("Local NTP [0] after write - from Object =" + system1.DateAndTime.LocalNTPServerInterfaces[0]);
        Log.Info("Local NTP [1] after write - from Object =" + system1.DateAndTime.LocalNTPServerInterfaces[1]);
        
        listOfEnabledLocalNTPServerInterfaces.Clear();

    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined logic is stopped
    }
}
