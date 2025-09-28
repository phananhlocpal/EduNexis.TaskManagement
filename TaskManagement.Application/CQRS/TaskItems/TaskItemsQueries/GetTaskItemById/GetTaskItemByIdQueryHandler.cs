using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Domain.Entities;
using TaskManagement.Domain.Interfaces;

namespace TaskManagement.Application.CQRS.TaskItems.TaskItemsQueries.GetAllTaskItems
{
    public class GetTaskItemByIdQueryHandler :
        IRequestHandler<GetTaskItemByIdQuery, Domain.Entities.TaskItem>
    {
        private readonly ITaskItemRepo _taskItemRepo;

        public GetTaskItemByIdQueryHandler(ITaskItemRepo taskItemRepo)
        {
            _taskItemRepo = taskItemRepo;
        }

        public Task<TaskItem> Handle(GetTaskItemByIdQuery request, CancellationToken cancellationToken)
        {
            try
            {
                cancellationToken.ThrowIfCancellationRequested();

                return _taskItemRepo.GetByIdAsync(request.ID);
            }
            catch (Exception ex)
            {
                throw;
            }

        }
    }
}
