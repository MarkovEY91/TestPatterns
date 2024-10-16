using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatterns.Порождающие.FactoryMethod.Revit
{
    internal abstract class HolesCreator
    {
        internal abstract Hole CreateHole(XYZ xyz);
    }
}
