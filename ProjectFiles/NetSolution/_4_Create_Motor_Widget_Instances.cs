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

public class _4_Create_Motor_Widget_Instances : BaseNetLogic
{
    [ExportMethod]
    public void CreateMotorWidgetInstances()
    {
        // NOTE: the "MotorWidget" type with "MotorAlias" alias, 
        // must be already available at UI/Widgets
        for (int i = 1; i <= 3; i++)
        {
            var motorWidgetType = Project.Current.Get("UI/Widgets/MotorWidget");
            var motorWidgetInstance = InformationModel.MakeObject("MotorWidget" + i, motorWidgetType.NodeId);
            Project.Current.Get("UI/MainWindow").Children.Add(motorWidgetInstance);

            var motorWidget = Project.Current.Get<Panel>("UI/MainWindow/MotorWidget" + i);
            motorWidget.SetAlias("MotorAlias", Project.Current.Get("Model/MotorInstances/Motor" + i));
            motorWidget.LeftMargin = (motorWidget.Width + 5) * (i - 1);
            motorWidget.TopMargin = 150;
        }
    }
}
