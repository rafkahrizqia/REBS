using System;
using System.Collections.Generic;

#nullable disable

namespace OneCodeRebs.Models.REBSModels
{
    public partial class Company
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Abbr { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Color { get; set; }
        public Guid? UserId { get; set; }
        public Guid? NotesId { get; set; }
        public Guid? CustomFieldsId { get; set; }
        public Guid? ContactsId { get; set; }
        public Guid? CustomFieldsValuesId { get; set; }

        public virtual Note Notes { get; set; }
        public virtual User User { get; set; }
    }
}
