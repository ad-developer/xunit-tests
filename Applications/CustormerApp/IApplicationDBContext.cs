using System;
using Microsoft.EntityFrameworkCore;

namespace Applications.CustormerApp
{
	public interface IApplicationDBContext
	{
        DbSet<Customer> Customers { get; }
        int SaveChanges();
    }
   
}

