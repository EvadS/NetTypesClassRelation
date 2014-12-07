using System;
using System.Collections.Generic;
using System.Text;



namespace TypesClassRelation
{
    public class Employee : Man
    {
        private string position;

        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        private IdCard card;

        public IdCard Card
        {
            get { return card; }
            set { card = value; }
        }

        public Employee() { }
        public Employee(string n, string s, string p)
        {
            Name = n;
            Surname = s;
            position = p;
        }

        List<Room> room;

      

        public void DeleteRoom(Room proom)
        {
            int index = room.IndexOf(proom);

            room.RemoveAt(index);
        }

        public void setRoom(Room newRoom)
        {
            room.Add(newRoom);
        }

        public List<Room> getRoom()
        {
            return room;
        }

        private Department departmentItem;

        public Department DepartmentItem
        {
            get { return departmentItem; }
            set { departmentItem = value; }
        }
    }
}
