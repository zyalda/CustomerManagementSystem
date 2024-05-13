using CMS.BL;
using CMS.Common.Interfaces;
using CMS.DL.Services;

namespace CMS.DL
{
    public class DataAccessFactory
    {
        public static IRepositoryData<Customer> CreateCustomerDataProvider()
        {
            return new CustomerRepository();
        }

        public static IRepositoryData<Employee> CreateEmployeeDataProvider()
        {
            return new EmployeeRepository();
        }

        //public static Employee CreateEmployee() { return new Employee(); }
        //public static Customer CreateCustomer() => new Customer();
    }
}
