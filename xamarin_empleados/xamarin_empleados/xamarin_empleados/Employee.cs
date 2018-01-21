using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net.Attributes;

namespace xamarin_empleados
{
   public  class Employee
    {
        [PrimaryKey, AutoIncrement]
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime ContractDate { get; set; }

        public decimal Salary { get; set; }

        public bool Active { get; set; }

        public string FullName { get { return string.Format("{0} {1}", FirstName, LastName); } }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3} {4}", EmployeeId, FirstName, LastName, ContractDate, Salary);
            return base.ToString();
        }

    }
}
