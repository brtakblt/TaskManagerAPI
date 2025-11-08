using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ENTITY
{
    public class Assignment
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public TaskStatus Status { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public int AssignedToId { get; set; }
        public User AssignedTo { get; set; }

        public int CreatedById { get; set; }
        public User CreatedBy { get; set; }

        public DateTime DueDate { get; set; }

        public ICollection<Commet> Comments { get; set; }
    }
}
