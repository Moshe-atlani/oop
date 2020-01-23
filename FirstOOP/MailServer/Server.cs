using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailServer
{
    class Server
    {
        private string serverName;
        private LinkedList<Subscriber> subscribers;
        private int currentCount;

        public Server(string name)
        {
            this.serverName = name;
            this.subscribers = new LinkedList<Subscriber>();
            this.currentCount = 0;
        }

        public void Foo(MailItem item)
        {
            //string receiver = item.GetSender();
            //while (subscribers != null)
            //{
            //    if (subscribers.v == receiver)
            //    {
            //        subscribers.AddFirst(item);
            //        return;
            //    }
            //}

            LinkedListNode<Subscriber> current = subscribers.First; // first node
            Subscriber currentSub = null;
            while (current != null)
            {
                currentSub = current.Value;
                currentSub.
                current = current.Next;
            }
            return counter;
        }
    }
}
