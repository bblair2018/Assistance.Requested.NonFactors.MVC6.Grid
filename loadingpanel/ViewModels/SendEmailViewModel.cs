using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loadingpanel.ViewModels
{
    public class SendEmailViewModel
    {
        public string Name { get; set; }
        public string Email { get; set; }
    
        public string Subject { get; set; }
        public string Message { get; set; }
        public DateTime TimeStampSent { get; set; }
    }
}
