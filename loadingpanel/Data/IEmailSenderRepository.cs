using loadingpanel.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loadingpanel.Data
{
    public interface IEmailSenderRepository
    {
        IEnumerable<EmailItem> GetAllEmailItems();
    }
}
