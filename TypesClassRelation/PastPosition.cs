using System;
using System.Collections.Generic;
using System.Text;

/*
 * пример Композиции
 */
namespace TypesClassRelation
{  
    /// <summary>
    /// Прежняя занимаемая должность на предприятии
    /// </summary>
    public class PastPosition
    {
        private int name;

        public int Name
        {
            get { return name; }
            set { name = value; }
        }
        private Department departmentItem;

        public Department DepartmentItem
        {
            get { return departmentItem; }
            set { departmentItem = value; }
        }

        public PastPosition(string position, Department dep)
        {
            throw new System.NotImplementedException();
        }
    }
}
