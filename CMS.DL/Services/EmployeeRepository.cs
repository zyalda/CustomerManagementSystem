using CMS.BL;
using CMS.Common.Interfaces;

namespace CMS.DL.Services
{
    public class EmployeeRepository : IRepositoryData<Employee>
    {
        private FakeDataBase _dataBase;
        public EmployeeRepository()
        {
            _dataBase = new FakeDataBase();
            Changeditems = new List<ILoggable>();
            Entitys = new List<Employee>();
        }

        public List<Employee> Entitys { get; set; }
        public List<ILoggable> Changeditems { private get; set; }

        public Employee Create(Employee employee)
        {
            foreach (Employee item in _dataBase.EmployeeDataList())
            {
                if (item.EmployeeId == employee.EmployeeId)
                {
                    employee = new Employee();
                }
            }
            return employee;
        }

        public IEnumerable<Employee> RetrieveAll()
        {
            return _dataBase.EmployeeDataList();
        }

        public IEnumerable<Employee> FindById(int id)
        {
            foreach (Employee item in _dataBase.EmployeeDataList())
            {
                if (item.EmployeeId == id)
                {
                    Entitys.Add(item);
                }
            }
            return Entitys;
        }
        public void Delete(int id)
        {
            foreach (Employee item in _dataBase.EmployeeDataList())
            {
                if (item.EmployeeId == id)
                {
                    Console.WriteLine(@"Employee with id:{0} and {1} has been removed", item.EmployeeId, item.FullName);
                    _dataBase.EmployeeDataList().Remove(item);
                }
            }
        }
        public bool Save(Employee employee)
        {
            throw new NotImplementedException();
        }

        public Employee Update(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
