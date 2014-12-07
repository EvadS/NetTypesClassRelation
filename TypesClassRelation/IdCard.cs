using System;
using System.Collections.Generic;
using System.Text;

/*
 * Иденфикационная карта сотрудника (пропуск)
 * каждому сотруднику соответствует только одна карточка
 * для демонстрации бинарной ассоциации
 */
namespace TypesClassRelation
{
    public class IdCard
    {
        private DateTime dateExpire;

        public DateTime DateExpire
        {
            get { return dateExpire; }
            set { dateExpire = value; }
        }
        private int number;

        public int Number
        {
            get { return number; }
            set { number = value; }
        }
    }
}
