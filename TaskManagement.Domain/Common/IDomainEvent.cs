using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Domain.Common
{
    public interface IDomainEvent
    {
        Guid Id { get; }
        DateTime OccuredTime { get; }
        string EventType { get; }
    }
}
