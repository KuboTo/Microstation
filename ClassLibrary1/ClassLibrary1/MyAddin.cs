using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Bentley.Internal.MicroStation.Elements;


namespace ClassLibrary1
{
    internal sealed class MyAddin:Bentley.MicroStation.AddIn
    {
        private MyAddin(System.IntPtr mdlDesc) : base(mdlDesc)
        {
            
        }
        protected override int Run(string[] commandLine)
        {
            //string sWinFrameworkPath = RuntimeEnvironment.GetRuntimeDirectory();
            //MessageBox.Show("Framework Path =" + sWinFrameworkPath);
            CreateElement.LineAndLineString();
            CreateElement.ShapeAndComplexShape();
            CreateElement.TextAndTextNode();
            CreateElement.CellAndSharedCell();
            CreateElement.LinearAndAngularDimension();
            CreateElement.CurveAndBsplineCurve();
            CreateElement.ConeAndBsplineSurface();
            return 0;

        }
    }
}
