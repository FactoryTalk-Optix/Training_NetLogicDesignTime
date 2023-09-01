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

public class _3_Create_Motor_Instances : BaseNetLogic
{
    [ExportMethod]
    public void CreateMotorInstances()
    {
        var motorInstancesFolder = InformationModel.Make<Folder>("MotorInstances");
        Project.Current.Get("Model").Add(motorInstancesFolder);
        for (int i = 1; i <= 3; i++)
        {
            var motorType = Project.Current.Get("Model/MotorType");
            var motorInstance = InformationModel.MakeObject("Motor" + i, motorType.NodeId);
            motorInstancesFolder.Add(motorInstance);
        }
    }
}
