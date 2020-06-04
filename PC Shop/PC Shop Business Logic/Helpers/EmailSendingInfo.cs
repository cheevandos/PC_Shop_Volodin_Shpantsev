using PC_Shop_Business_Logic.Enums;
using System;

namespace PC_Shop_Business_Logic.Helpers
{
    public class EmailSendingInfo
    {
        public string FilePath { get; set; }
        public string RecipientName { get; set; }
        public string RecipientMail { get; set; }
        public string SenderName { get; set; }
        public string SenderMail { get; set; }
        public string SenderPassword { get; set; }
        public string MessageSubject { get; set; }
        public string MessageText { get; set; }
        public ReportType ReportType { get; set; }
        public DateTime SendingDate { get; set; }
    }
}
