using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailServer
{
    public class Subscriber
    {
        private string name;
        private LinkedList<MailItem> mails;
        private int numMails;

        public Subscriber(string name)
        {
            this.name = name;
            this.mails = new LinkedList<MailItem>();
            this.numMails = 0;
        }

        public void AddMail(MailItem mail)
        {
            mails.AddFirst(mail);
            numMails++;
        }

        public int HowMuchRead()
        {
            // לספור כמה מיילים נקראו
            int counter = 0;
            LinkedListNode<MailItem> current = mails.First; // first node
            while(current.Next != null)
            {
                if(current.Value.GetIsRead() == true)
                {
                    counter++;
                }
                current = current.Next; 
            }
            return counter;
        }

    }
}
