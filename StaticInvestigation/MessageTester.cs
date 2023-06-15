using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticInvestigation
{
    public class MessageTester
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Static - Message Counter Investigation");

            for (int i=0; i< 1000; i++)
            {
                Message m = new Message();

            }



        }


    }
}
