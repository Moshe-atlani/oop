using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailServer;

namespace oop1
{
    class Program
    {
        static void Main(string[] args)
        {
            // יצרנו 3 מיילים
            MailItem m1 = new MailItem("eli", "moshe", "ya gever1");
            MailItem m2 = new MailItem("eli", "moshe", "ya gever2");
            MailItem m3 = new MailItem("eli", "moshe", "ya gever3");

            // יצרנו מנוי
            Subscriber mosheManui = new Subscriber("moshe");

            // קראנו את ההודעה הראשונה
            m1.Read(); // באג. לא תופס את זה

            // הוספנו את ההודעות לרשימת הודעות של משה
            mosheManui.AddMail(m1);
            mosheManui.AddMail(m2);
            mosheManui.AddMail(m3);

            Console.WriteLine(mosheManui.HowMuchRead());
        }
    }
}
