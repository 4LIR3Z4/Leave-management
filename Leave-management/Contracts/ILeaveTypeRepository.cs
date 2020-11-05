using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Leave_management.Data;

namespace Leave_management.Contracts
{
    interface ILeaveTypeRepository: IRepositoryBase<LeaveType>
    {
        ICollection<LeaveType> GetEmployeesByLeaveType(int id);
    }
}
