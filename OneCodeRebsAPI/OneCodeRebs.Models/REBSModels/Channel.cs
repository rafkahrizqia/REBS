using System;
using System.Collections.Generic;

#nullable disable

namespace OneCodeRebs.Models.REBSModels
{
    public partial class Channel
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Phone { get; set; }
        public string Type { get; set; }
        public string AutoReply { get; set; }
        public string ColorColorColor { get; set; }
        public string NotificationEmail { get; set; }
        public Guid? BusinessHourId { get; set; }
        public Guid? NotificationSound { get; set; }
        public string Status { get; set; }
        public string DisplayName { get; set; }
        public string Text { get; set; }
        public string ShowTicketFields { get; set; }
        public string ShowContactFields { get; set; }
        public Guid? UsersId { get; set; }
        public string Username { get; set; }
        public bool? PasswordIsNull { get; set; }
        public bool? IsPrivate { get; set; }
        public bool? ReassignReopenedTicket { get; set; }
        public bool? ReopenClosedTicketTimeWindowDaysReopenClosedTicketTimeWindowDays { get; set; }

        public virtual User Users { get; set; }
    }
}
