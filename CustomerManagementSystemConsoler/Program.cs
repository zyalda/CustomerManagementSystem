using CMS.BL;
using CMS.DL;
namespace CustomerManagementSystemConsoler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CustomerManagementSystem program");
            MainMenu();
        }
        private static void MainMenu()
        {
            bool run = true;
            do
            {
                Console.WriteLine("Choose an option!");
                Console.WriteLine("1)Deal with employee.");
                Console.WriteLine("2)Deal with customer.");
                Console.WriteLine("3) Enter 3 to exit!");
                var input = Console.ReadLine();
                var option = Validations.FormatCheckOfInput(input);
                switch (option)
                {
                    case 1:
                        EmployeeMenu();
                        break;
                    case 2:
                        customerMenu();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            } while (run);
        }

        private static void customerMenu()
        {
            Console.WriteLine("Choose an option!");
            Console.WriteLine("1)List all customer.");
            Console.WriteLine("2)Find a customer by id.");
            Console.WriteLine("3)Add a new customer.");
            Console.WriteLine("4)Update a customer by id.");
            Console.WriteLine("5)Delete a customer by id.");
            Console.WriteLine("6)Enter 6 to return to main menu!");
            bool run = true;
            do
            {
                var input = Console.ReadLine();
                var option = Validations.FormatCheckOfInput(input);
                switch (option)
                {
                    case 1:
                        ReadAllCustomers();
                        break;
                    case 2:
                        Console.WriteLine("Enter an id.");
                        var entry = Console.ReadLine();
                        var id = Validations.FormatCheckOfInput(entry);
                        ReadCustomerById(id);
                        break;
                    case 3:
                        Console.WriteLine("Enter an customer with comma between entities.");
                        string item = Console.ReadLine();
                        Customer customer = (Customer)ConsoleCommonFunctions.Newcustomer(item);
                        CreateCustomer(customer);
                        break;
                    case 4:
                        // code block
                        break;
                    case 5:
                        Console.WriteLine("Enter an id.");
                        var customerID = Console.ReadLine();
                        var customId = Validations.FormatCheckOfInput(customerID);
                        DeleteCustomer(customId);
                        break;
                    case 6:
                        run = false;
                        MainMenu();
                        break;
                    default:
                        break;
                }
            } while (run);
        }

        private static void EmployeeMenu()
        {
            Console.WriteLine("Choose an option!");
            Console.WriteLine("1)List all employess.");
            Console.WriteLine("2)Find an employee by id.");
            Console.WriteLine("3)Add a new employee.");
            Console.WriteLine("4)Update a employee by id.");
            Console.WriteLine("5)Delete an employee by id.");
            Console.WriteLine("6)Enter 6 to return to main menu!");
            bool run = true;
            do
            {
                var input = Console.ReadLine();
                var option = Validations.FormatCheckOfInput(input);
                switch (option)
                {
                    case 1:
                        ReadAllEmployees();
                        break;
                    case 2:
                        Console.WriteLine("Enter an id.");
                        var entry = Console.ReadLine();
                        var id = Validations.FormatCheckOfInput(entry);
                        ReadEmployeeById(id);
                        break;
                    case 3:
                        Console.WriteLine("Enter an employee with comma between entities.");
                        string item = Console.ReadLine();
                        Employee employee = (Employee)ConsoleCommonFunctions.NewEmployee(item);
                        CreateEmployee(employee);
                        break;
                    case 4:
                        break;
                    case 5:
                        Console.WriteLine("Enter an id.");
                        var employeeId = Console.ReadLine();
                        var emploId = Validations.FormatCheckOfInput(employeeId);
                        DeleteEmployee(emploId);
                        break;
                    case 6:
                        run = false;
                        MainMenu();
                        break;
                    default:
                        Environment.Exit(0);
                        break;
                }
            } while (run);
        }

        private static void ReadAllEmployees()
        {
            IEnumerable<Employee> employees = DataAccessFactory.CreateEmployeeDataProvider().RetrieveAll();
            ConsoleCommonFunctions.GetListItem(employees);
        }

        private static void ReadEmployeeById(int id)
        {
            IEnumerable<Employee> employee = DataAccessFactory.CreateEmployeeDataProvider().FindById(id);
            ConsoleCommonFunctions.GetListItem(employee);
        }
        private static void CreateEmployee(Employee employee)
        {
            Employee empo = DataAccessFactory.CreateEmployeeDataProvider().Create(employee);
            Console.WriteLine($"Employee with {empo.EmployeeId},{empo.FirstName} {empo.EmailAddress}, {empo.entityState} has been added.");
        }
        private static void DeleteEmployee(int id)
        {
            DataAccessFactory.CreateEmployeeDataProvider().Delete(id);
        }

        private static void ReadAllCustomers()
        {
            IEnumerable<Customer> customers = DataAccessFactory.CreateCustomerDataProvider().RetrieveAll();
            ConsoleCommonFunctions.GetListItem(customers);
        }
        private static void ReadCustomerById(int id)
        {
            IEnumerable<Customer> customer = DataAccessFactory.CreateCustomerDataProvider().FindById(id);
            ConsoleCommonFunctions.GetListItem(customer);
        }
        private static void CreateCustomer(Customer customer)
        {
            Customer custom = DataAccessFactory.CreateCustomerDataProvider().Create(customer);
            Console.WriteLine(@"Customer with:{0} and {1} {2} {3}has been added", custom.CustomerID, custom.FullName, custom.Email, custom.AddressList.Select(x => x.PostalCode).FirstOrDefault());
        }
        private static void DeleteCustomer(int id)
        {
            DataAccessFactory.CreateCustomerDataProvider().Delete(id);
        }
    }
}
