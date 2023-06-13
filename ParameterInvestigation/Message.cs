using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParameterInvestigation
{
    internal class Message
    {
        public string Title { get; set; } = "";
        public string Text { get; set; } = "";

        public override string? ToString()
        {
            return "=========================\n" +
                    Title + "\n" +
                    Text + "\n" +
                    "=========================\n";
        }
    }


}
