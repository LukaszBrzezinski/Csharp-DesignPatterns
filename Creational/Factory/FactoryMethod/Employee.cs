using System;

namespace Factory.FactoryMethod
{
    public class Employee
    {
        public string Name { get; }
        public string Surname { get; }
        public decimal Salary { get; }
        private readonly DateTime _createDate;

        private Employee(string name, string surname, decimal salary)
        {
            Name = name;
            Surname = surname;
            Salary = salary;
            _createDate = DateTime.UtcNow;
        }

        #region FactoryMethods

        public static Employee CreateHeadOfDepartment(string name, string surname)
        {
            return new Employee(name, surname, 10000);
        }

        public static Employee CreateProgramer(string name, string surname)
        {
            return new Employee(name, surname, 3000);
        }

        #endregion


        // Other logic
        public override string ToString()
        {
            return $"{nameof(_createDate)}: {_createDate}, {nameof(Name)}: {Name}, {nameof(Surname)}: {Surname}, {nameof(Salary)}: {Salary}";
        }
    }
}
