using CMS.BL;

namespace CMS.DL.Services
{
    internal class FakeDataBase
    {
        internal FakeDataBase()
        {
        }
        public List<Employee> EmployeeDataList()
        {
            return new List<Employee>()
            {
                new Employee()
                {
                    EmployeeId = 11,
                    FirstName = "John", LastName = "Test",
                    EmailAddress = "test@test.com"},
                new Employee()
                {
                    EmployeeId = 12,
                    FirstName = "zeena", LastName = "Smith",
                    EmailAddress = "zeena@smith.com"},
                new Employee()
                {
                    EmployeeId = 13,
                    FirstName = "zeenalena", LastName = "poal",
                    EmailAddress = "zeenalena@poal.com"
                },
            };
        }
        public List<Customer> CustomerDataList()
        {
            AddressRepository addresses = new AddressRepository();
            return new List<Customer>()
            {
            new Customer()
            {
                CustomerID = 1,
                FirstName = "John", LastName = "Test",
                Email = "test@test.com"},
            new Customer()
            {
                CustomerID = 2,
                FirstName = "zeena", LastName = "Smith",
                Email = "zeena@smith.com"},
            new Customer()
            {
                CustomerID = 3,
                FirstName = "zeenalena", LastName = "poal",
                Email = "zeenalena@poal.com"},
            };
        }
        public List<Address> AddressDataList()
        {
            return new List<Address>()
            {
                new Address()
                {
                    AddressID = 1,
                    CustomerID = 2,
                    AddressType = "Home",
                    StreetLine_1 = "Arvikagatan 1A",
                    PostalCode = "000 00",
                    City = "Arvika",
                    Country = "Sweden",
                },
                new Address()
                {
                    AddressID = 2,
                    CustomerID = 2,
                    AddressType = "Jobb",
                    StreetLine_1 = "Magasinggatan 9A",
                    PostalCode = "000 11",
                    City = "Arvika",
                    Country = "Sweden",
              },
                new Address()
                {
                    AddressID = 3,
                    CustomerID = 3,
                    AddressType = "Jobb",
                    StreetLine_1 = "Jobbgatan 2A",
                    PostalCode = "000 22",
                    City = "Arvika",
                    Country = "Sweden",
              }
            };
        }
    }
}
