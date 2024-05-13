using CMS.BL;
using CMS.Common.Interfaces;

namespace CMS.DL.Services
{
    public class AddressRepository : IRepositoryData<Address>
    {
        private FakeDataBase _dataBase;

        public AddressRepository()
        {
            _dataBase = new FakeDataBase();
            Entitys = new List<Address>();
        }
        public List<Address> Entitys { get; set; }
        public IEnumerable<Address> RetrieveAll()
        {
            return _dataBase.AddressDataList();
        }

        public IEnumerable<Address> FindById(int customerID)
        {
            foreach (Address address in RetrieveAll())
            {
                if (address.CustomerID == customerID)
                {
                    Entitys.Add(address);
                }
            }
            return Entitys;
        }
        public bool Save(Address address)
        {
            return true;
        }

        public Address Create(Address address)
        {
            throw new NotImplementedException();
        }

        public Address Update(Address address)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
