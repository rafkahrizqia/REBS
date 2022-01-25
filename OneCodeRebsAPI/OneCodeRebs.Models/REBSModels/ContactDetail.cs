using System;
using System.Collections.Generic;

#nullable disable

namespace OneCodeRebs.Models.REBSModels
{
    public partial class ContactDetail
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Abbr { get; set; }
        public string Color { get; set; }
        public byte[] ProfileImage { get; set; }
        public bool? IsPhone { get; set; }
        public string Phone { get; set; }
        public string FormattedPhone { get; set; }
        public string Avatar { get; set; }
        public string Identifier { get; set; }
        public Guid? ProfileId { get; set; }
        public Guid? ChannelsId { get; set; }
        public string Pivot { get; set; }
        public Guid? NotesId { get; set; }
        public Guid? GroupsId { get; set; }
        public Guid? FormattedCustomFieldDataId { get; set; }
        public string DisplayName { get; set; }
        public bool? IsPrivate { get; set; }
        public Guid? CustomFieldValuesId { get; set; }
    }
}
