using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.Data.DbModels.Contracts
{
    public interface IUnitOfWork:IDisposable
    {
        void Save();
    }
}
