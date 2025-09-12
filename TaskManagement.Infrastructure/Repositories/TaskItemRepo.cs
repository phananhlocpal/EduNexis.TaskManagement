using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Infrastructure.Repositories
{
    public class TaskItemRepo : Domain.Interfaces.ITaskItemRepo
    {
        public Task AddAsync(TaskItem taskItem)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(TaskItem taskItem)
        {
            throw new NotImplementedException();
        }

        public Task<List<TaskItem>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TaskItem?> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(TaskItem taskItem)
        {
            throw new NotImplementedException();
        }
    }
}
