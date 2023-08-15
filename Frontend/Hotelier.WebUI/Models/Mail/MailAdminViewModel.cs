﻿using System;

namespace Hotelier.WebUI.Models.Mail
{
    public class MailAdminViewModel
    {
        public string? Name { get; set; }
        public string? SenderMail { get; set; }
        public string? ReceiverMail { get; set; }
        public string? Subject { get; set; }
        public string? Body { get; set; }
    }
}
