using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourtVillaBank.Model.Model
{
    public abstract class AuditableBaseEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public DateTime DateTime { get; set; } = DateTime.Now;
        public DateTime CreatedAt { get; set; }
        public string ModifiedAt { get; set;}
        
    }
}
