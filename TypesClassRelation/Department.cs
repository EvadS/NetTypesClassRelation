using System;
using System.Collections.Generic;
using System.Text;

namespace TypesClassRelation
{
    /// <summary>
    /// Отдел
    /// </summary>
    /// <remarks>
    /// Предприятие структурировано по отделам. В каждом отделе может
    /// работать один или более человек. Можно сказать, что отдел включает в 
    /// себя одного или более сотрудников. На предприятии могут работать 
    /// сотрудники которые не пренадлежать ни одному из отделов, например директор
    /// </remarks>
    public class Department: Unit
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private List<Employee> employees;

 

        public Department(string n)
        {
            throw new System.NotImplementedException();
        }

        public void addEmployee(Employee pEmployee)
        {
            pEmployee.DepartmentItem = this;
            employees.Add(pEmployee);
        }

        #region Unit Members

        public int  getPersonCount()
        {
            return employees.Count;
        }

        #endregion
    }
}
