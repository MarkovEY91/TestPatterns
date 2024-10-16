using Autodesk.Revit.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPatterns.Порождающие.FactoryMethod.Revit
{

    /// <summary>
    /// Клиентский код
    /// 
    /// Преимущества
    /// 1. Если потребуется создать новый тип отверстий, то достаточно создать новый класс отверстия и класс новой фабрики
    /// 2. Клиентский код ничего не знает о деталях реализации создания отверстий. Он просто вызывает фабрику и получает нужный объект.
    /// 3. Если меняется логика создания отверстий, то достаточно внести изменения в фабрики, при этом не трогая клиентский код.
    /// </summary>
    internal static class Client
    {
        internal static void CreateHoleUsingFactory(Document doc, HolesEnum holesEnum, XYZ location)
        {
            using (Transaction t = new Transaction(doc, "Создание отверстий"))
            {
                t.Start();

                HolesCreator factory = HolesFactory.GetHolesCreator(holesEnum);

                factory.CreateHole(location);

                t.Commit();
            } 
        }
    }
}
