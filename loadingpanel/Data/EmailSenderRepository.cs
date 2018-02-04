using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using loadingpanel.Data.Entities;

namespace loadingpanel.Data
{
    public class EmailSenderRepository : IEmailSenderRepository
    {
        public IEnumerable<EmailItem> GetAllEmailItems()
        {
            EmailSenderSeeder seeder = new EmailSenderSeeder();
            List<EmailItem> sendList = new List<EmailItem>();

            //First Email Item
            EmailItem firstEmailItem = seeder.createFakeEmailItem(1, 1, 1973, 6, 9, 13, 07, 44);
            sendList.Add(firstEmailItem);

            //Setup for creating the random emails.
            double incremenetor = 1.0;
            int counter = 1;
            Random randomNumber = new Random();

            for (int j = 1; j <= 12; j++)
            {
                for (int i = 0; i < Math.Round(100 * incremenetor); i++)
                {
                    sendList.Add(seeder.createFakeEmailItem(counter,    //Subject Number
                                        counter,                        //Message Number
                                        2017,                           //Year
                                        j,                              //Month
                                        randomNumber.Next(1, 28),       //Day
                                        randomNumber.Next(6, 23),       //Hour
                                        randomNumber.Next(1, 60),       //Minute
                                        randomNumber.Next(1, 60)));     //Second
                    counter++;
                }

                incremenetor += 0.1;
            }

            return sendList;
        }
    }
}
