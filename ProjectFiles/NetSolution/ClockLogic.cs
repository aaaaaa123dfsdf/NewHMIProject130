#region Using directives
using System;
using CoreBase = FTOptix.CoreBase;
using FTOptix.HMIProject;
using UAManagedCore;
using FTOptix.UI;
using FTOptix.NetLogic;
using FTOptix.RAEtherNetIP;
using FTOptix.CommunicationDriver;
using FTOptix.WebUI;
using FTOptix.System;
#endregion

public class ClockLogic : BaseNetLogic
{
	public override void Start()
	{
		periodicTask = new PeriodicTask(UpdateTime, 1000, LogicObject);
		periodicTask.Start();
	}

	public override void Stop()
	{
		periodicTask.Dispose();
		periodicTask = null;
	}

	private void UpdateTime()
	{
		LogicObject.GetVariable("Time").Value = System.DateTime.Now;
		LogicObject.GetVariable("UTCTime").Value = System.DateTime.UtcNow;
	}

	private PeriodicTask periodicTask;
}
