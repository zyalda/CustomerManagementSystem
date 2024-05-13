using CMS.BL;
using CMS.Common.Interfaces;

namespace CMS.DL.Services
{
    public class CustomerRepository : IRepositoryData<Customer>
    {
        private FakeDataBase _dataBase;
        private AddressRepository _addressRepo;
        public CustomerRepository()
        {
            _dataBase = new FakeDataBase();
            _addressRepo = new AddressRepository();
            Changeditems = new List<ILoggable>();
            Entitys = new List<Customer>();
        }

        public List<ILoggable> Changeditems { private get; set; }
        public List<Customer> Entitys { get; set; }

        public IEnumerable<Customer> RetrieveAll()
        {
            List<Customer> customers = [];
            foreach (Customer customer in _dataBase.CustomerDataList())
            {
                customer.AddressList.AddRange(_addressRepo.FindById(customer.CustomerID));
                Entitys.Add(customer);
            }
            return Entitys;
        }

        public bool Save(Customer customer)
        {
            var success = true;
            if (customer.HasChanges)
            {
                if (customer.Isnew)
                {
                    if (customer.IsValid)
                    {
                        success = true;
                    }
                    else
                    {
                        success = false;
                    }
                }
            }
            return success;
        }

        public IEnumerable<Customer> FindById(int customerId)
        {
            foreach (Customer item in _dataBase.CustomerDataList())
            {
                if (item.CustomerID == customerId)
                {
                    item.AddressList.AddRange(_addressRepo.FindById(item.CustomerID));
                    Entitys.Add(item);
                }
            }
            return Entitys;
        }

        public Customer Create(Customer customer)
        {
            foreach (Customer item in _dataBase.CustomerDataList())
            {
                if (item.CustomerID == customer.CustomerID)
                {
                    customer = new Customer();
                }
            }
            return customer;
        }

        public Customer Update(Customer customer)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            foreach (Customer item in _dataBase.CustomerDataList())
            {
                if (item.CustomerID == id)
                {
                    Console.WriteLine(@"Customer with:{0} and {1} {2} {3}has been removed", item.CustomerID, item.FullName, item.Email, item.AddressList.Select(x => x.PostalCode));
                    _dataBase.CustomerDataList().Remove(item);
                }
            }
        }
    }
}
