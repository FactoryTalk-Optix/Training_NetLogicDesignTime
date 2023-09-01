#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.HMIProject;
using FTOptix.NativeUI;
using FTOptix.UI;
using FTOptix.NetLogic;
using FTOptix.CoreBase;
using FTOptix.Core;
using System.Linq;
#endregion

public class _6_Cleanup_Project : BaseNetLogic
{
    [ExportMethod]
    public void DeleteModelVariables()
    {
        //Clear MotorInstances in MotorInstances folder
        if (Project.Current.Get("Model/MotorInstances") != null)
            Project.Current.Get("Model/MotorInstances").Children.Clear();
        
        //Clear all variables in Model Folder
        Project.Current.Get("Model").Children.Clear();

        //Clear all MotorWidgets in MainWindow page
        var panel = Project.Current.Get("UI/MainWindow").Children.OfType<Panel>();
        foreach (var widget in panel)
            widget.Delete();
    }
}
