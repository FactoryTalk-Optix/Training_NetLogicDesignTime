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

public class _2_Create_Motor_Type : BaseNetLogic
{
    [ExportMethod]
    public void CreateMotorType()
    {
        var motorType = InformationModel.MakeObjectType("MotorType");
        var speed = InformationModel.MakeVariable("Speed", OpcUa.DataTypes.UInt16);
        var running = InformationModel.MakeVariable("Running", OpcUa.DataTypes.Boolean);
        motorType.Add(speed);
        motorType.Add(running);
        Project.Current.Get("Model").Add(motorType);
    }

}
