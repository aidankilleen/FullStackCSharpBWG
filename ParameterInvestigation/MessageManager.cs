using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterInvestigation
{
    internal class MessageManager
    {
        //private ArrayList messages = new ArrayList();
        private List<Message> messages = new List<Message>();

        /*
        private Message[] messages = { 
            new Message{Title="M1", Text="This is M1"},
            new Message{Title="M2", Text="This is M2"},
            new Message{Title="M3", Text="This is M3"},
            new Message{Title="M4", Text="This is M4"},
        };
        */

        public  MessageManager() {

            //messages.Add(new Message { Title = "M1", Text = "This is M1" });
            //messages.Add(new Message { Title = "M2", Text = "This is M2" });
            //messages.Add(new Message { Title = "M3", Text = "This is M3" });
            //messages.Add(new Message { Title = "M4", Text = "This is M4" });
            // messages.Add("this is not a message its a string");
        }

        public void DisplayAll()
        {
            foreach (Message message in messages)
            {
                Console.WriteLine(message);
            }
        }

/*
 *      You can overload methods
 *      (i.e. multiple versions of same method)
 *      as long as the number or types of the
 *      parameters are different
 *      
        public Message GetMessage()
        {
            return messages[0];
        }
*/
        public Message? GetMessage(int n = 0)
        {
            if (messages.Count > 0)
            {
                return (Message)messages[n];
            } else
            {
                return null;
            }
        }

        public void AddMessage(Message message)
        {
            messages.Add(message);
        
        }
    }
}
