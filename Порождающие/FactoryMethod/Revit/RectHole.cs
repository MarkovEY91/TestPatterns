using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatterns.Порождающие.FactoryMethod.Revit
{
    internal class RectHole : Hole
    {
        public RectHole(XYZ xyz) : base(xyz)
        {

        }
    }
}
