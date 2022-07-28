using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace TestMultilangual
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            Document doc = commandData.Application.ActiveUIDocument.Document;
            string doctitle = doc.Title;
            string msg = MyStrings.DocTitleMessage + doctitle;
            TaskDialog.Show(MyStrings.PanelTitle, msg);

            Form1 form = new Form1();
            form.ShowDialog();
            

            return Result.Succeeded;
        }
    }
}
