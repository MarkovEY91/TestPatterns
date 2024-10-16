using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatterns.Порождающие.FactoryMethod.Revit
{
    internal class HolesFactory
    {
        internal static HolesCreator GetHolesCreator(HolesEnum holesEnum)
        {
            if (holesEnum == HolesEnum.Rect)
            {
                return new RectHoleCreator();
            }
            else if (holesEnum == HolesEnum.Circ)
            {
                return new CircHoleCreator();
            }

            throw new ArgumentException("Ошибка");

        }



    }
}
