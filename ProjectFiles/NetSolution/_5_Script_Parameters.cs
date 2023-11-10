#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.NativeUI;
using FTOptix.UI;
using FTOptix.Core;
using FTOptix.CoreBase;
using FTOptix.NetLogic;
#endregion

public class _5_Script_Parameters : BaseNetLogic
{
    [ExportMethod]
    public void ReadParameters()
    {
        string varName = LogicObject.GetVariable("Variable_Name").Value;
        string folderName = LogicObject.GetVariable("Folder_Name").Value;
        Log.Info(LogicObject.BrowseName, "Variable_Name = " + varName);
        Log.Info(LogicObject.BrowseName, "Folder_Name = " + folderName);
    }

}
