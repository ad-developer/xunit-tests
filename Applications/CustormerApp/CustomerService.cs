namespace Applications.CustormerApp
{
	public class CustomerService : ICustomerService
    {
        private readonly IApplicationDBContext _applicationDBContext;

		public CustomerService(IApplicationDBContext applicationDBContext)
		{
            _applicationDBContext = applicationDBContext;
		}

        public int Add(Customer customer)
        {
            var savedCustomer = _applicationDBContext.Customers.Add(customer);
            _applicationDBContext.SaveChanges();

            return savedCustomer.Entity.Id;
        }

        public List<Customer> GetAllCustomers()
        {
            var res = _applicationDBContext.Customers.ToList();

            return res;
        }

        public Customer GetCustomerById(int id)
        {
            var res = _applicationDBContext.Customers
                .Where(p => p.Id == id).FirstOrDefault();

            return res;
        }
    }
}

