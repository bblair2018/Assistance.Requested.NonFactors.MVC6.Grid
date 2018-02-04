using loadingpanel.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loadingpanel.Data
{
    public class EmailSenderSeeder
    {
        #region Helper Methods

        private string createName()
        {
            var firstNames = new string[] { "Kevin", "Jeff", "Abdulla", "Tim", "Jacob", "Rich", "Moises", "Daivd" };
            var lastNames = new string[] { "Cox", "Mansoori ", "Mamuwala", "Perluss", "Herrara", "Smith", "Cuellar", "Rodriguez" };
            Random random1 = new Random();
            Random random2 = new Random();
            int randomNumber1 = random1.Next(0, firstNames.Length);
            int randomNumber2 = random2.Next(0, firstNames.Length);

            return $"{firstNames[randomNumber1]} {lastNames[randomNumber2]}";
        }

        private string createEmail(string Name)
        {
            string[] names = Name.Split(' ');

            return $"{names[0].FirstOrDefault()}{names[1]}@fakeemail.com";
        }

        private string createSubject(int subjectNumber)
        {
            return $"Subject {subjectNumber}";
        }

        private string createMessage(int messageNumber)
        {
            return $"This is message {messageNumber}";
        }

        private DateTime createTimeStampSent(int year, int month, int day, int hour, int minute, int second)
        {
            DateTime fakeTimeStapmp = new DateTime(year, month, day, hour, minute, second);
            return fakeTimeStapmp;
        }

        public EmailItem createFakeEmailItem(int subjectNumber, int messageNumber, int year, int month, int day, int hour, int minute, int second)
        {
            try
            {
                string name = createName();
                string emailAddress = createEmail(name);
                string subject = createSubject(subjectNumber);
                string message = createMessage(messageNumber);
                DateTime timeStamp = createTimeStampSent(year, month, day, hour, minute, second);

                EmailItem fakeEmailItem = new EmailItem();
                fakeEmailItem.fromName = name;
                fakeEmailItem.toEmailAddress = emailAddress;
                fakeEmailItem.toSubject = subject;
                fakeEmailItem.toMessage = message;
                fakeEmailItem.emailSentTimeStamp = timeStamp;

                return fakeEmailItem;
            }
            catch (Exception ex)
            {
                //TODO: Handle this at some time in the future!
                return null;
            }
        }

        #endregion
    }
} 
