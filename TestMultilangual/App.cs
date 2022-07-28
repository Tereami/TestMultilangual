using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.ApplicationServices;

namespace TestMultilangual
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class App : IExternalApplication
    {
        public static string assemblyPath = "";
        public static string assemblyFolder = "";
        public static string localFolder = "";


        public Result OnStartup(UIControlledApplication application)
        {
            assemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            assemblyFolder = System.IO.Path.GetDirectoryName(assemblyPath);

            string tabName = "BIM-STARTER TEST";
            try { application.CreateRibbonTab(tabName); } catch { }
            RibbonPanel panel1 = application.CreateRibbonPanel(tabName, MyStrings.PanelTitle);
            PushButton btn = panel1.AddItem(new PushButtonData(
                "CheckLanguage",
                MyStrings.ButtonName,
                assemblyPath,
                "TestMultilangual.Command")
                ) as PushButton;

            return Result.Succeeded;
        }
        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }
    }
}
