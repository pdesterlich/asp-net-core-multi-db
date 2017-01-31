using System;
using System.Collections.Generic;
using MyApp.models;

namespace MyApp.repo
{
    public interface IUnitOfWork: IDisposable
    {
        ICollection<Customer> GetCustomers();
    }
}