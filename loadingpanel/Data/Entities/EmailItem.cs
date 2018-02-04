using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loadingpanel.Data.Entities
{
    public class EmailItem
    {
        /// <summary>
        /// The ID of the email.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of the person that is sending the email to the recipient.
        /// </summary>
        public string fromName { get; set; }

        /// <summary>
        /// The email address of the recipient.
        /// </summary>
        public string toEmailAddress { get; set; }

        /// <summary>
        /// The subject of the emails that was sent to the recipient.
        /// </summary>
        public string toSubject { get; set; }

        /// <summary>
        /// The message that was sent to the recipient.
        /// </summary>
        public string toMessage { get; set; }

        /// <summary>
        /// The time the email was sent.
        /// </summary>
        public DateTime emailSentTimeStamp { get; set; }
    }
}
