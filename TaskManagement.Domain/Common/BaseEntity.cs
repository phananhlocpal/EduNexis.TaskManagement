using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Domain.Common
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifyAt { get; set; }
        public string? ModifyBy { get; set; }
        public bool IsDeleted { get; set; } = false;

        public BaseEntity()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
            CreatedBy = "system"; 
        }

        public BaseEntity(Guid id, string createdBy)
        {
            id = id;
            CreatedAt = DateTime.UtcNow;
            CreatedBy = createdBy;
        }

        public void ChangeModifyDate(string modifyBy)
        {
            ModifyAt = DateTime.UtcNow;
            ModifyBy = modifyBy;
        }
    }
}
