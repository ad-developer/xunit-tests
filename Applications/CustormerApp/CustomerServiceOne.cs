namespace Applications.CustormerApp
{
	public class CustomerServiceOne : ICustomerService
    {
        private readonly IApplicationDBContext _applicationDBContext;

		public CustomerServiceOne(IApplicationDBContext applicationDBContext)
		{
            _applicationDBContext = applicationDBContext;
		}

        public int Add(Customer customer)
        {
            _applicationDBContext.Customers.Add(customer);
            _applicationDBContext.SaveChanges();

            return customer.Id;
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

