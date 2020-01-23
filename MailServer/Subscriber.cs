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
            while (current != null)
            {
                if (current.Value.GetIsRead() == true)
                {


                    counter++;
                }
                current = current.Next;
            }
            return counter;
        }

        public MailItem LastMessageFrom(string sender)//תחגיל ז
        {
            int didnRead = numMails - HowMuchRead();
            if (didnRead > 0)
            {
                for (int i = 0; i < didnRead; i++)
                {
                    if(mails.Last.Get)
                }
                return mails.Last();
            }
            while(mails != null)
            {
                if(mails.sender)
            }
            return null;
        }

        public string  GetName()
        {
            return name;
        }

    }
}
