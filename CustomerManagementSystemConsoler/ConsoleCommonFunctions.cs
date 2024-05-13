using CMS.BL;
using CMS.Common;
using CMS.Common.Interfaces;

namespace CustomerManagementSystemConsoler
{
    internal static class ConsoleCommonFunctions
    {
        internal static void GetListItem(IEnumerable<ILoggable> loggable)
        {
            if (loggable.Any())
            {
                List<ILoggable> changeditems = new List<ILoggable>();
                changeditems.AddRange(loggable);
                changeditems.WriteToFile();
            }
            else
            {
                Console.WriteLine("The item was not found");
            }
        }

        internal static ILoggable NewEmployee(string? input)
        {
            Employee employee = new Employee();
            var dd = input.Split(',');
            for (int i = 0; i < input.Split(",").Length; i++)
            {
                employee.EmployeeId = Convert.ToInt32(dd[0]);
                employee.FirstName = dd[1];
                employee.LastName = dd[2];
                employee.EmailAddress = dd[3];
                employee.Isnew = true;
            }
            return employee;
        }
        internal static ILoggable Newcustomer(string? input)
        {
            Customer customer = new Customer();
            var dd = input.Split(',');
            for (int i = 0; i < input.Split(",").Length; i++)
            {
                customer.CustomerID = Convert.ToInt32(dd[0]);
                customer.FirstName = dd[1];
                customer.LastName = dd[2];
                customer.Email = dd[3];
                customer.Isnew = true;
            }
            return customer;
        }
    }
}
