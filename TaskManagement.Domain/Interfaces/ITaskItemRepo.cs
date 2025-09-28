using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Domain.Interfaces
{
    public interface ITaskItemRepo
    {
        Task AddAsync(TaskItem taskItem);
        Task<TaskItem?> GetByIdAsync(Guid id);
        Task<List<TaskItem>> GetAllAsync();
        Task UpdateAsync(TaskItem taskItem);
        Task DeleteAsync(TaskItem taskItem);

        Task AddtestGit(TaskItem taskItem);
    }
}
