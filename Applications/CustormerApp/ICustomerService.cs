namespace Applications.CustormerApp
{
	public interface ICustomerService
	{
		int Add(Customer customer);

		Customer GetCustomerById(int id);

		List<Customer> GetAllCustomers();
	}
}

