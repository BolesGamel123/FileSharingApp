using FileSharingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FileSharingApp.Areas.Admin.Models
{
    public class ContactUsViewModel: ContactViewModel
    {
        public int Id { get; set; }
        public bool Status { get; set; }

        public DateTime SentDate { get; set; }
    }
}
