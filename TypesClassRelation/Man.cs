using System;
using System.Collections.Generic;
using System.Text;
/*
 * класс Man 
 */
namespace TypesClassRelation
{
    public class Man
    {
        private string name;

        public  string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string surname;

        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
    }
}
