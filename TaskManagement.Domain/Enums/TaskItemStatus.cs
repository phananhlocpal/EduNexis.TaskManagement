using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Domain.Enums
{
    public enum TaskItemStatus
    {
        Pending = 1,
        InProgress = 2,
        Completed = 3,
        Overdue = 4
    }
}
