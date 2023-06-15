using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticInvestigation
{
    public class Message
    {
        public static int Count { get; set; } = 0 ;

        public string Title { get; set; } = "";
        public string Text { get; set; } = "";

        public string[] data = new string[100];


        public Message() {
            Count++;
            //if (Count % 100 == 0)
            //{
                Console.WriteLine($"Created {Count}");

            //}
        }

        ~Message()
        {
            // called when object is destroyed
            Console.WriteLine($"Destructor called { Count }");
            Count--;
        }


        
        public static int GetCount()
        {
            return Count;
        }

    }
}
