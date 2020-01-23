using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailServer
{
    public class MailItem//התוכן של פריט הדואר האחרונה 
    {
        private string receiver;
        private string sender;//שם השולח
        private string content;
        private bool isRead;

        public MailItem(string receiver , string sender, string content)
        {
            this.receiver = receiver;
            this.sender = sender;
            this.content = content;
            this.isRead = false;
        }

        public void Read()
        {
            this.isRead = true;
        }

        public bool GetIsRead()
        {
            return this.isRead;
        }
        public string GetSender()//תחגיל ז
        {
            return sender;
        }
    }
}
