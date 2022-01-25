using System;
using System.Collections.Generic;

#nullable disable

namespace OneCodeRebs.Models.REBSModels
{
    public partial class User
    {
        public User()
        {
            Companies = new HashSet<Company>();
            Notes = new HashSet<Note>();
        }

        public Guid Id { get; set; }
        public Guid? AgencyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Abbr { get; set; }
        public string Phone { get; set; }
        public string Color { get; set; }
        public string LocaleCode { get; set; }
        public string Status { get; set; }
        public string Text { get; set; }
        public bool? IsOnline { get; set; }
        public string UserStatus { get; set; }
        public bool? ChatStatus { get; set; }
        public string VoipStatus { get; set; }
        public string VoipDevice { get; set; }
        public byte[] ProfileImage { get; set; }
        public string Authorization { get; set; }
        public bool? IsPrimary { get; set; }
        public string Timezone { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool? TwoFactorAuthentificationEnabled { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
    }
}
