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

public class _1_Create_Simple_Variables : BaseNetLogic
{
    [ExportMethod]
    public void CreateVariables()
    {
        var myFolder = Project.Current.Get<Folder>("Model/Variables");
        if (myFolder != null)
        {
            myFolder.Delete();
        }
        myFolder = InformationModel.Make<Folder>("Variables");
        Project.Current.Get("Model").Add(myFolder);
        for (int i = 1; i <= 3; i++)
        {
            var myVar = InformationModel.MakeVariable("Variable" + i, OpcUa.DataTypes.UInt16);
            myFolder.Add(myVar);
        }
    }

}
