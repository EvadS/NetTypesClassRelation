using System;
using System.Collections.Generic;
using System.Text;

/*
 * Зависимость  как тип отношений между объектами
 */
namespace TypesClassRelation
{
    public class Menu
    {
        private static  int i;
        public static void ShowEmployees(TypesClassRelation.Employee[] employee)
        {
            System.Console.WriteLine("Список сотрудников");

            for (i = 0; i < employee.Length; i++)
            {
                System.Console.WriteLine(employee[i].Name + " - " +
                    employee[i].getPastPosition()[0]);
            }


        }
    }
}
