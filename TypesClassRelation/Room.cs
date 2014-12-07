using System;
using System.Collections.Generic;
using System.Text;

namespace TypesClassRelation
{
    /// <summary>
    /// Помещение в котором работает сотрудник
    /// </summary>
    /// <remarks>
    /// Помещение в котором работает сотрудник
    /// Каждому сотруднику может соответствовать несколько помещений. Пример связиодин - ко - многим
    /// </remarks>
    public class Room
    {
        /// <summary>
        /// номер кмнаты
        /// </summary>
        private int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        public Room(int n)
        {
            number = n;
        }

        public Room()
        {
            throw new System.NotImplementedException();
        }

       
    }
}
