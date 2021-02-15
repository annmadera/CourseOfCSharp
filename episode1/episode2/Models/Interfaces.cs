using System;
using System.Collections.Generic;
using System.Text;

namespace Episode2.Models
{
    public interface IEmailSender
    {
        void SendMessage(string receiver, string title, string message);

    }

    public interface IDatabase
    {
        bool IsConnected { get; }
        void Connect();
        User GetUser(string email);
        

    }
    public class EmailSender : IEmailSender
    {
        public void SendMessage(string receiver, string title, string message)
        {
            throw new NotImplementedException();
        }
    }
}
