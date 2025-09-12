using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Domain.Common;
using TaskManagement.Domain.Enums;
using TaskManagement.Domain.Events;

namespace TaskManagement.Domain.Entities;

public class TaskItem : AggregateRoot
{
    public string Title { get; private set; }
    public string Description { get; private set; }
    public DateTime? DueDate { get; private set; }
    public TaskItemStatus Status { get; private set; } = TaskItemStatus.Pending;

    public TaskItem() : base()
    {

    }

    public TaskItem(string title, string description, DateTime? dueDate, TaskItemStatus status, Guid id, string createdBy) : base(id, createdBy)
    {
        Title = title;
        Description = description;
        DueDate = dueDate;
        Status = status;
        CreatedBy = createdBy;
        CreatedAt = DateTime.UtcNow;

        AddDomainEvent(new TaskItemEvents.TaskItemCreated(title, description, dueDate, createdBy, CreatedAt));
    }

    public void Update(string title, string description, DateTime? dueDate, TaskItemStatus status, string modifiedBy)
    {
        Title = title;
        Description = description;
        DueDate = dueDate;
        Status = status;
        this.ChangeModifyDate(modifiedBy);

        AddDomainEvent(new TaskItemEvents.TaskItemUpdated(this.Id, title, description, dueDate, modifiedBy, this.ModifyAt.Value));
    }
}
