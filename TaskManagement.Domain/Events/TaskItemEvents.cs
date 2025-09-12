using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Domain.Common;

namespace TaskManagement.Domain.Events
{
    public class TaskItemEvents
    {
        public class TaskItemCreated : IDomainEvent
        {
            public string Title { get; }
            public string Description { get;  }
            public DateTime? DueDate { get;  }
            public string CreatedBy { get;  }
            public DateTime CreatedAt { get;  }

            public Guid Id { get;  }

            public DateTime OccuredTime { get; }

            public string EventType { get; }

            public TaskItemCreated(string title, string description, DateTime? dueDate, string createdBy, DateTime createdAt)
            {
                Title = title;
                Description = description;
                DueDate = dueDate;
                CreatedBy = createdBy;
                CreatedAt = createdAt;
                Id = Guid.NewGuid();
                OccuredTime = DateTime.UtcNow;
                EventType = nameof(TaskItemCreated);
            }
        }

        public class TaskItemUpdated : IDomainEvent
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTime? DueDate { get; set; }
            public string UpdatedBy { get; set; }
            public DateTime UpdatedAt { get; set; }

            public Guid Id { get; }

            public DateTime OccuredTime { get; }

            public string EventType { get; }

            public TaskItemUpdated(Guid id, string title, string description, DateTime? dueDate, string updatedBy, DateTime updatedAt)
            {
                Id = id;
                Title = title;
                Description = description;
                DueDate = dueDate;
                UpdatedBy = updatedBy;
                UpdatedAt = updatedAt;
                OccuredTime = DateTime.UtcNow;
                EventType = nameof(TaskItemUpdated);
            }
        }

        public class TaskItemDeleted
        {
            public Guid TaskItemId { get; set; }
            public string DeletedBy { get; set; }
            public DateTime DeletedAt { get; set; }

            public TaskItemDeleted(Guid taskItemId, string deletedBy, DateTime deletedAt)
            {
                TaskItemId = taskItemId;
                DeletedBy = deletedBy;
                DeletedAt = deletedAt;
            }
        }
    }
}
