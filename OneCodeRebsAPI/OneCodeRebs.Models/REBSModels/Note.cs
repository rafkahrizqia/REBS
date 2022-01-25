using System;
using System.Collections.Generic;

#nullable disable

namespace OneCodeRebs.Models.REBSModels
{
    public partial class Note
    {
        public Note()
        {
            Companies = new HashSet<Company>();
        }

        public Guid Id { get; set; }
        public string Contact { get; set; }
        public Guid? UserId { get; set; }
        public string Note1 { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
    }
}
