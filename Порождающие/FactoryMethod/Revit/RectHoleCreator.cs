using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatterns.Порождающие.FactoryMethod.Revit
{
    internal class RectHoleCreator : HolesCreator
    {
        internal override Hole CreateHole(XYZ xyz)
        {
            return new RectHole(xyz);
        }
    }
}
