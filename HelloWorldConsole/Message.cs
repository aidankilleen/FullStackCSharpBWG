using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsole
{
    internal class Message
    {
        private string _text;

        public string Text { 
            get { 
                return _text; 
            } 
            set
            {
                if (value.Length > 0)
                {
                    _text = value;
                } else
                {
                    Console.WriteLine("Invalid value");
                }
            }
        } 

        public string Title { get; set; }


        /*
        public string GetText()
        {
            return text;
        }
        public void SetText(string text)
        {
            if (text.Length > 0)
            {
                this.text = text;
            }
        }
        */

        public Message()
        {

        }
        public Message(string title, string text)
        {
            Title = title;
            Text = text;
        }

        public void Display()
        {
            Console.WriteLine(ToString());
        }

        public override string? ToString()
        {
            return "==============================\n" +
                   $"{ Title }\n" +
                   $"{ Text }\n" +
                   "==============================\n";
        }
    }
}
