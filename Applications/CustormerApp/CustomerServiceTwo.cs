namespace Applications.CustormerApp
{
	public class CustomerServiceTwo : ServiceGeneric<Customer>
	{
		public CustomerServiceTwo(IApplicationDBContext context) : base(context)
		{
		}
	}
}

