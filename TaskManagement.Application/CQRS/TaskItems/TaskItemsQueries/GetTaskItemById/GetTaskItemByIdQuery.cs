using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using TaskManagement.Domain.Entities;

namespace TaskManagement.Application.CQRS.TaskItems.TaskItemsQueries.GetAllTaskItems
{
    public class GetTaskItemByIdQuery : IRequest<TaskItem>
    {
        public Guid ID { get; set; }
    }
}
